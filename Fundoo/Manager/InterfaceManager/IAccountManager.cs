using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
    /// <summary>
    /// THis is Interface class for Account Manager
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// Registrations the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<bool> Registration(RegistrationModel registrationModel);

        /// <summary>
        /// This is login 
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        string Login(LoginModel loginModel);
        /// <summary>
        /// This is for reset the password
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        Task<bool> ResetPassword(ResetPassword resetPassword);
        /// <summary>
        /// This is for Forget Password
        /// </summary>
        /// <param name="forgotPasswordModel"></param>
        /// <returns></returns>
        Task<bool> ForgotPassword(ForgotPasswordModel forgotPasswordModel);
        /// <summary>
        /// Checks the password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        //bool CheckPassword(string email, string password);

        /// <summary>
        /// For Logout
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        string Logout(LoginModel loginModel);
        /// <summary>
        /// For google Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        Task<bool> GoogleLogin(LoginModel loginModel);
        /// <summary>
        /// for Facebook Login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        Task<bool> FacebookLogin(LoginModel loginModel);
    }
}
