﻿
using System;
using System.Text;
using Jose;
using Manager.InterfaceManager;
using Manager.Manager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repository.IRepository;
using Repository.Repository;
using Repository.UserDbContext;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace Fundoo
{
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var Jwtsettings = new JwtSettings();
            //Configuration.Bind(key: nameof(Jwtsettings), Jwtsettings);
            //services.AddSingleton(Jwtsettings);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IRepositoryuser, UserLogin>();
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<UserContext>();
            services.AddDbContext<UserContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));
            var appSettingSection = this.Configuration.GetSection("AppSetting");
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<UserContext>()
                .AddDefaultTokenProviders();
            services.Configure<DataProtectionTokenProviderOptions>(option => option.TokenLifespan = TimeSpan.FromHours(1));

            var secretKey = Configuration["Jwt:Key"];
            var symmerticKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            // services.Configure<AppSetting>(appSettingSection);
            services.AddAuthentication(configureOptions: con =>
            {
                con.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               // con.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                con.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(conf =>
                {
                    conf.SaveToken = true;
                    conf.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                      //  IssuerSigningKey =true,
                        //new SymmetricSecurityKey(key: Encoding.ASCII.GetBytes("JwtSettings:Secret")),
                        ValidateIssuer = true,
                       // ValidateAudience = false,
                       
                        //ValidateLifetime = true,
                        ValidIssuer=Configuration["Jwt:_url"],
                        ValidAudience=Configuration["Jwt:_url"],
                        IssuerSigningKey=symmerticKey,
                        RequireExpirationTime = true
                    };
                });
            services.AddCors(Co => Co.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                //builder.WithOrigins("http://localhost:44349");
            }));
            
            services.AddSwaggerGen(con =>
            {
                con.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "FundooNotes API",
                    Version = "v1"
                });
                con.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "jwt Authorization using header scheme",
                    Name = "Authorization",
                    In = "header",
                    Type = "apikey",
                });
                con.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            services.Configure<IISOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseSwagger();
          app.UseSwaggerUI(Con =>
            {
                Con.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI v1");
            });
                   
        }
    }
}