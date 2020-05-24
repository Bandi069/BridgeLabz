// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserLogin.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using Experimental.System.Messaging;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using Repository.IRepository;
using Repository.UserDbContext;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// This is UserLogin class
    /// </summary>
    public class UserLogin : IRepositoryuser
    {
        /// <summary>
        /// This is readonly private UserContext
        /// </summary>
        private readonly UserContext context;
        private readonly IConfiguration configuration;
        /// <summary>
        /// This is UserLogin Constructor by passing UserContext
        /// </summary>
        /// <param name="context"></param>
        public UserLogin(UserContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogin"/> class.
        /// </summary>
        public UserLogin()
        {
        }

        /// <summary>
        /// This is Registration Task
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public Task<int> Registration(RegistrationModel registrationModel)
        {
            RegistrationModel registration = new RegistrationModel()
            {
                FirstName = registrationModel.FirstName,
                LastName = registrationModel.LastName,
                Email = registrationModel.Email,
                Password = registrationModel.Password
            };
            var register = this.context.Register.Add(registration);
            var res = this.context.SaveChanges();
            return Task.Run(() => res);
        }

        /// <summary>
        /// This is Login Asynchronous Task 
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Login(LoginModel loginModel)
        {

            if (FindEmail(loginModel.Email))
            {
                if (CheckPassword(loginModel.Email, loginModel.Password))
                {
                    var key = configuration["Jwt:key"];
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:url"],
                        audience: configuration["Jwt:url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr);
                    var FinalToken = new JwtSecurityTokenHandler().WriteToken(token);
                    //// this.distributedCache.SetString("Token", FinalToken);
                    this.context.SaveChanges();
                    return FinalToken;
                }
            }
            return "login failed";
        }

        /// <summary>
        /// This is Task for resetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public async Task<string> ResetPassword(ResetPassword resetPassword)
        {
            string email = resetPassword.Email;
            string password = resetPassword.Password;
            RegistrationModel Resetobj = this.context.Register.Where(UserName => UserName.Email == resetPassword.Email).SingleOrDefault();
            if (Resetobj != null)
            {
                Resetobj.Password = resetPassword.Password;
                var user = this.context.Register.Find(resetPassword.Email);
                user.Password = resetPassword.Password;
                await Task.Run(() => this.context.SaveChangesAsync());
                return "Succesfull";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This is Task method for Forgot password
        /// </summary>
        /// <param name="forgotPasswordModel"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            var email = forgotPasswordModel.Email;
            var userForgetPassword = FindEmail(email);
            if (userForgetPassword == true)
            {
                string Message = forgotPasswordModel.Email;
                MessageQueue Myqueue;

                if (MessageQueue.Exists(@".\private$\Myqueue"))
                {
                    Myqueue = new MessageQueue(@".\private$\Myqueue");
                }
                else
                {
                    Myqueue = MessageQueue.Create(@".\private$\Myqueue");
                }
                Message message = new Message()
                {

                    Formatter = new BinaryMessageFormatter(),
                    Body = userForgetPassword,
                    Label = "MsmqMessage"
                };
                Myqueue.Send(Message);

                if (Message.Contains(email))
                {
                    message.Priority = MessagePriority.High;
                }
                else
                {
                    message.Priority = MessagePriority.Low;
                }
                var fromemailaddress = new MailAddress("bandivenu89@gmail.com");
                var Password = "sanVedha2212$";
                var toEmailaddress = new MailAddress(forgotPasswordModel.Email);
                string subject = "Fundoo Account Reset Password ";
                string body = "To Reset password click on the below link " + " http://localhost:4200/resetpassword";
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromemailaddress.Address, Password)
                };
                using (var messages = new MailMessage(fromemailaddress, toEmailaddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        Myqueue.Send(Message);

                        smtp.Send(messages);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                await Task.Run(() => this.context.SaveChangesAsync());
                return "Sucess";
            }
            return null;
        }

        /// <summary>
        /// This is TAsk for Finding Email 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool FindEmail(string email)
        {
            var userRegistration = context.Register.Where(obj => obj.Email == email).FirstOrDefault();
            if (userRegistration != null)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// This is Task for ChackPassword
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(string email, string password)
        {
            var checkobj = context.Register.Where(UserName => UserName.Password == password && UserName.Email == email).FirstOrDefault();
            if (checkobj != null)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// This is Logout Method
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Logout(LoginModel loginModel)
        {
            try
            {
                var cacheKey = loginModel.Email;
                ConnectionMultiplexer connectionmulti = ConnectionMultiplexer.Connect("172.40.1.77:6379");
                IDatabase database = connectionmulti.GetDatabase();
                database.KeyDelete(cacheKey);
                return "Account Logout ";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// This is asyn Task for Google Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> GoogleLogin(LoginModel loginModel)
        {
            var GoogleUser = this.context.Register.Where(UserName => UserName.Email == loginModel.Email && UserName.Password == loginModel.Password).SingleOrDefault();
            if (GoogleUser != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Email", GoogleUser.Email)
                    }),
                    Expires = DateTime.UtcNow.AddHours(24)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var chacheKey = loginModel.Email;
                return token;
            }
            else
            {
                RegistrationModel registration = new RegistrationModel();
                registration.Email = loginModel.Email;
                registration.Password = "sanVedha2212";
                context.Register.Add(registration);
                context.SaveChanges();
                var googleuser = FindEmail(loginModel.Email);
                if (googleuser != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Email", GoogleUser.Email)
                    }),
                        Expires = DateTime.UtcNow.AddHours(24)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var chacheKey = loginModel.Email;
                    return token;
                }
            }
            await this.context.SaveChangesAsync();
            return default;
        }

        /// <summary>
        /// This is Task for Facebook Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> FacebookLogin(LoginModel loginModel)
        {
            var FacebookUser = context.Register.Where(UserName => UserName.Email == loginModel.Email && UserName.Password == loginModel.Password).SingleOrDefault();
            if (FacebookUser != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Email", FacebookUser.Email)
                    }),
                    Expires = DateTime.UtcNow.AddHours(24)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var chacheKey = loginModel.Email;
                return token;
            }
            else
            {
                RegistrationModel registration = new RegistrationModel();
                registration.Email = loginModel.Email;
                registration.Password = "sanvedha2212";
                context.Register.Add(registration);
                context.SaveChanges();
                var facebookuser = FindEmail(loginModel.Email);
                if (facebookuser != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Email", FacebookUser.Email)
                    }),
                        Expires = DateTime.UtcNow.AddDays(7)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var chacheKey = loginModel.Email;
                    return token;
                }
            }
            await context.SaveChangesAsync();
            return default;
        }
    }
}

