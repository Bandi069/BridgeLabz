using Model.UserModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserLogin : IRepositoryuser
    {
        private readonly UserContext context;
        public UserLogin(UserContext context)
        {
            this.context = context;
        }
        public async Task<string> LoginAsynChr(LoginModel loginModel)
        {
            var user = FindEmailid(loginModel.Emailid);

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
        public Task FindEmailid(string emailid)
        {
            RegistrationModel userRegistration;
            return null;
        }
    }
}
