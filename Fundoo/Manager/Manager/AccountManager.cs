using Manager.InterfaceManager;
using Model.UserModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class AccountManager : IAccountManager
    {
        private readonly IRepositoryuser repositoryuser;
        public AccountManager()
        {

        }
        public AccountManager(IRepositoryuser repositoryuser)
        {
            this.repositoryuser = repositoryuser;
        }
        public Task<string> Login(LoginModel loginModel)
        {
            var result = this.repositoryuser.Login(loginModel);
            return result;
        }
        public Task<bool> CheckPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<string> FacebookLogin(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> GoogleLogin(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

       

        public string Logout(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
