using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        /// This is Login Asynchronous Task 
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = FindEmailid(loginModel.Emailid);
            if (user != null && await CheckPasswordAsync(loginModel.Emailid, loginModel.Password))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
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
                    Console.WriteLine("Exception Occurs" + e.Message);
                }
            }
            return "Incorrect Email or Password";
        }
        /// <summary>
        /// This is Task for resetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public Task ResetPassword(ResetPassword resetPassword)
        {
            RegistrationModel Resetobj = context.Register.Where(UserName => UserName.Emailid == resetPassword.Emailid).SingleOrDefault();
            Resetobj.Password = resetPassword.Password;
            var user = context.Register.Find(resetPassword.Emailid);
            user.Password = resetPassword.Password;
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// This is Task method for Forgot password
        /// </summary>
        /// <param name="forgotPasswordModel"></param>
        /// <returns></returns>
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            //// RegistrationModel Forgotobj = context.Register.Where(UserName => UserName.Emailid == forgotPasswordModel.Emailid).FirstOrDefault();
            var userForgetPassword = FindEmailid(forgotPasswordModel.Emailid);

            return null;
        }
        public Task FindEmailid(string email)
        {
            var userRegistration = context.Login.Where(obj => obj.Emailid == email).SingleOrDefault();
            IdentityUser IUser = new IdentityUser() { Email = userRegistration.Emailid };

            return Task.Run(() => IUser);
        }
        public Task<bool> CheckPasswordAsync(string email, string password)
        {
            bool checkobj = context.Login.Where(UserName => UserName.Password == password && UserName.Emailid == email).SingleOrDefault().Emailid == email ? true : false;
            return Task.Run(() => checkobj);
        }
    }

}

