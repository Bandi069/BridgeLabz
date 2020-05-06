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
        public UserLogin(UserContext context,IConfiguration configuration)
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
        public  Task<int> Registration(RegistrationModel registrationModel)
        { 
            RegistrationModel registration = new RegistrationModel()
            {
                FirtsName = registrationModel.FirtsName,
                LastName = registrationModel.LastName,
                Emailid = registrationModel.Emailid,
                Password = registrationModel.Password
            };
            var register = this.context.Register.Add(registration);
            var res= this.context.SaveChanges();
            return Task.Run(() => res);
        }

        /// <summary>
        /// This is Login Asynchronous Task 
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Login(LoginModel loginModel)
        {
            //var user = FindEmailid(loginModel.Emailid);
            //if (user != null && await CheckPassword(loginModel.Emailid, loginModel.Password))
            //{
            //    try
            //    {
            //        var tokenDescriptor = new SecurityTokenDescriptorool> Registration(RegistrationModel registrationModel)
        
            //        {
            //            Subject = new ClaimsIdentity(new Claim[]
            //        {
            //            new Claim("Emailid",loginModel.Emailid)
            //        }),
            //        };
            //        var tokenHandler = new JwtSecurityTokenHandler();
            //        var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            //        var token = tokenHandler.WriteToken(securityToken);
            //        var Cache = loginModel.Emailid;
            //        return token;
            //    }
            //    catch (Exception e)
            //    {
            //        throw new Exception(e.Message);
            //    }
            //}
            //return "Incorrect Email or Password";
            if (FindEmailid(loginModel.Emailid))
            {
                if (CheckPassword(loginModel.Emailid, loginModel.Password))
                {
                    var key = configuration["Jwt:key"];
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:_url"],
                        audience: configuration["Jwt:_url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr);
                    var FinalToken = new JwtSecurityTokenHandler().WriteToken(token);
                    //// this.distributedCache.SetString("Token", FinalToken);
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
                string password = resetPassword.Password;
            RegistrationModel Resetobj = this.context.Register.Where(UserName => UserName.Emailid == resetPassword.Emailid).SingleOrDefault();
                if (Resetobj != null)
                {
                    Resetobj.Password = resetPassword.Password;
                    var user = this.context.Register.Find(resetPassword.Emailid);
                    user.Password = resetPassword.Password;
                    await Task.Run(() => this.context.SaveChanges());
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
            string email = forgotPasswordModel.Emailid;
            //// RegistrationModel Forgotobj = context.Register.Where(UserName => UserName.Emailid == forgotPasswordModel.Emailid).FirstOrDefault();
            var userForgetPassword = FindEmailid(forgotPasswordModel.Emailid);
            if (userForgetPassword != null)
            {
                string Message = email;
                MessageQueue Myqueue;
                
                if (MessageQueue.Exists(@".\private$\Myqueue"))
                {
                    Myqueue = new MessageQueue(@".\private$\Myqueue");
                }
                else
                {
                    Myqueue = MessageQueue.Create(@".\private$\Myqueue");
                }
                Message message = new Message();
                message.Formatter = new BinaryMessageFormatter();
                message.Body = userForgetPassword;
                message.Label = "MsmqMessage";
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
                var toEmailaddress = new MailAddress(forgotPasswordModel.Emailid);
                string subject = "Reset Password";
                string body = "To Reset password";
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
        /// This is TAsk for Finding EmailId 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool FindEmailid(string email)
        {
            var userRegistration = context.Register.Where(obj => obj.Emailid == email).SingleOrDefault();
            if(userRegistration!=null)
            {
                return true;
            }
            else { return false; }
            //IdentityUser IUser = new IdentityUser() { Email = userRegistration.Emailid };

            //return Task.Run(() => IUser);

        }

        /// <summary>
        /// This is Task for ChackPassword
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(string email, string password)
        {
            var checkobj = this.context.Register.Where(UserName => UserName.Password == password && UserName.Emailid == email).SingleOrDefault().Emailid == email ? true : false;
            //return Task.Run(() => checkobj);
            if (checkobj!=null)
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
                var cacheKey = loginModel.Emailid;
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
        public async Task<bool> GoogleLogin(LoginModel loginModel)
        {
            var GoogleUser = this.context.Register.Where(UserName => UserName.Emailid == loginModel.Emailid && UserName.Password == loginModel.Password).SingleOrDefault();
            if (GoogleUser != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Emailid", GoogleUser.Emailid)
                    }),
                    Expires = DateTime.UtcNow.AddHours(24) 
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var chacheKey = loginModel.Emailid;
                return true;
            }
            else
            {
                RegistrationModel registration = new RegistrationModel();
                registration.Emailid = loginModel.Emailid;
                registration.Password = "sanVedha2212";
                context.Register.Add(registration);
                context.SaveChanges();
                var googleuser = FindEmailid(loginModel.Emailid);
                if (googleuser != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Emailid", GoogleUser.Emailid)
                    }),
                        Expires = DateTime.UtcNow.AddHours(24)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var chacheKey = loginModel.Emailid;
                    return true;
                }
            }
            await this.context.SaveChangesAsync();
            return false;
        }

        /// <summary>
        /// This is Task for Facebook Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<bool> FacebookLogin(LoginModel loginModel)
        {
            var FacebookUser = context.Register.Where(UserName => UserName.Emailid == loginModel.Emailid && UserName.Password == loginModel.Password).SingleOrDefault();
            if (FacebookUser != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Emailid", FacebookUser.Emailid)
                    }),
                    Expires = DateTime.UtcNow.AddHours(24)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var chacheKey = loginModel.Emailid;
                return true;
            }
            else
            {
                RegistrationModel registration = new RegistrationModel();
                registration.Emailid = loginModel.Emailid;
                registration.Password = "sanvedha2212";
                context.Register.Add(registration);
                context.SaveChanges();
                var facebookuser = FindEmailid(loginModel.Emailid);
                if (facebookuser != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Emailid", FacebookUser.Emailid)
                    }),
                        Expires = DateTime.UtcNow.AddDays(7)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var chacheKey = loginModel.Emailid;
                    return true;
                }
            }
            await context.SaveChangesAsync();
            return false;
        }
    }
}

