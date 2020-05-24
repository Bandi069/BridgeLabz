using Manager.InterfaceManager;
using Model.UserModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// This is account manager class
    /// </summary>
    public class AccountManager : IAccountManager
    {
        /// <summary>
        /// This is readonly IRepository  instance
        /// </summary>
        private readonly IRepositoryuser repositoryuser;
       
        
        /// <summary>
        /// This is constructor of Account Manager class  by passig IRepository
        /// </summary>
        /// <param name="repositoryuser"></param>
        public AccountManager(IRepositoryuser repositoryuser)
        {
            this.repositoryuser = repositoryuser;
        }
        /// <summary>
        /// Registrations the specified login model.
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public async  Task<bool> Registration(RegistrationModel registrationModel )
        {
          await this.repositoryuser.Registration(registrationModel);
            return true;
        }
        /// <summary>
        /// This is Task for Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Login(LoginModel loginModel)
        {
            var result = this.repositoryuser.Login(loginModel);
            return result;
        }
        /// <summary>
        /// This is Async Task for Reset Password
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public async Task<string> ResetPassword(ResetPassword resetPassword)
        {
          return  await this.repositoryuser.ResetPassword(resetPassword);
        }
        
        /// <summary>
        /// This is async task for ForgotPassword
        /// </summary>
        /// <param name="forgotPasswordModel"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            return await this.repositoryuser.ForgotPassword(forgotPasswordModel);
             
        }
        /// <summary>
        /// This is task for Google Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<string> GoogleLogin(LoginModel loginModel)
        {
            var result = this.repositoryuser.GoogleLogin(loginModel);
            return result;
        }
        /// <summary>
        /// This is Task for FaceBook Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<string> FacebookLogin(LoginModel loginModel)
        {
            var result = this.repositoryuser.FacebookLogin(loginModel);
            return result;
        }
        /// <summary>
        /// This is method for logout
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Logout(LoginModel loginModel)
        {
            var result = this.repositoryuser.Logout(loginModel);
            return result;
        }
    }
}
