using Microsoft.AspNet.Identity.EntityFramework;
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
        /// <summary>
        /// This is UserLogin Constructor by passing UserContext
        /// </summary>
        /// <param name="context"></param>
        public UserLogin(UserContext context)
        {
            this.context = context;
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
        public Task Registration(RegistrationModel registrationModel)
        {
            RegistrationModel registration = new RegistrationModel()
            {
                FirtsName = registrationModel.FirtsName,
                LastName = registrationModel.LastName,
                Emailid = registrationModel.Emailid,
                Password = registrationModel.Password
            };

            return null;
        }
        /// <summary>
        /// This is Login Asynchronous Task 
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> Login(LoginModel loginModel)
        {
            var user = FindEmailid(loginModel.Emailid);
            if (user != null && await CheckPassword(loginModel.Emailid, loginModel.Password))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Emailid",loginModel.Emailid)
                    }),
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var Cache = loginModel.Emailid;
                    return token;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return "Incorrect Email or Password";
        }
        /// <summary>
        /// This is Task for resetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public async Task ResetPassword(ResetPassword resetPassword)
        {
            RegistrationModel Resetobj = this.context.Register.Where(UserName => UserName.Emailid == resetPassword.Emailid).SingleOrDefault();
            Resetobj.Password = resetPassword.Password;
            var user = this.context.Register.Find(resetPassword.Emailid);
            user.Password = resetPassword.Password;
            await Task.Run(() => this.context.SaveChanges());
        }
        /// <summary>
        /// This is Task method for Forgot password
        /// </summary>
        /// <param name="forgotPasswordModel"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            //// RegistrationModel Forgotobj = context.Register.Where(UserName => UserName.Emailid == forgotPasswordModel.Emailid).FirstOrDefault();
            var userForgetPassword = FindEmailid(forgotPasswordModel.Emailid);
            if (userForgetPassword != null)
            {
                var fromemailaddress = new MailAddress("bandivenu89@gmail.com");
                var Password = "sanVedha2212";
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
                using (var message = new MailMessage(fromemailaddress, toEmailaddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(message);
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
        public Task FindEmailid(string email)
        {
            var userRegistration = context.Register.Where(obj => obj.Emailid == email).SingleOrDefault();
            IdentityUser IUser = new IdentityUser() { Email = userRegistration.Emailid };

            return Task.Run(() => IUser);
        }
        /// <summary>
        /// This is Task for ChackPassword
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Task<bool> CheckPassword(string email, string password)
        {
            bool checkobj = context.Register.Where(UserName => UserName.Password == password && UserName.Emailid == email).SingleOrDefault().Emailid == email ? true : false;
            return Task.Run(() => checkobj);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        /// <summary>
        /// This is asyn Task for Google Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> GoogleLogin(LoginModel loginModel)
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
                return token;
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
                    return token;
                }
            }
            await this.context.SaveChangesAsync();
            return "User Not Existed";
        }
        /// <summary>
        /// This is Task for Facebook Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> FacebookLogin(LoginModel loginModel)
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
                return token;
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
                    return token;
                }
            }
            await context.SaveChangesAsync();
            return "User Not Existed";
        }
    }
}

