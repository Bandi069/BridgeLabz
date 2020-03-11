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
        public async Task<bool> ResetPassword(ResetPassword resetPassword)
        {
            await this.repositoryuser.ResetPassword(resetPassword);
            return true;
        }
        public async Task<bool> CheckPassword(string email, string password)
        {
            await this.repositoryuser.CheckPassword(email,password);
            return true;
        }
        public async Task<bool> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            await this.repositoryuser.ForgotPassword(forgotPasswordModel);
            return true;
        }

        public Task<string> GoogleLogin(LoginModel loginModel)
        {
            var result = this.repositoryuser.GoogleLogin(loginModel);
            return result;
        }
        public Task<string> FacebookLogin(LoginModel loginModel)
        {
            var result = this.repositoryuser.FacebookLogin(loginModel);
            return result;
        }
        public string Logout(LoginModel loginModel)
        {
            var result = this.repositoryuser.Logout(loginModel);
            return result;
        }

      
    }
}
