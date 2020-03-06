using Microsoft.AspNet.Identity.EntityFramework;
using Model.UserModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = FindEmailid(loginModel.Emailid);
            if (user != null && await CheckPasswordAsync(loginModel.Emailid,loginModel.Password))
            {
                try
                {

                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception occurs"+e.Message);
                }
            }
            return null;
        }
        public Task<string> ResetPassword(ResetPassword resetPassword)
        {
            return null;
        }

        public Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            return null;
        }
        public Task FindEmailid(string email)
        {
            RegistrationModel userRegistration = context.UserData.Where(obj => obj.Emailid == email).SingleOrDefault();
            IdentityUser IUser = new IdentityUser()
            {
                Email = userRegistration.Emailid
            };

            return Task.Run(()=>IUser);
        }
        public Task<bool> CheckPasswordAsync(string email,string password)
        {
            bool checkobj = context.UserData.Where(username => username.Password == password).SingleOrDefault();
            return Task.Run(()=> checkobj);
        }
    }
}
