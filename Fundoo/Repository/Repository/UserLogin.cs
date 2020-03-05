using Model.UserModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserLogin : IRepositoryuser
    {
        public UserLogin()
        {
        }
        public Task<string> LoginAsynChr(LoginModel loginModel)
        {
            
            return null;
        }
        Task<string> IRepositoryuser.ResetPassword(ResetPassword resetPassword)
        {
            return null;
        }

        Task<string> IRepositoryuser.ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            return null;
        }
    }

    
}
