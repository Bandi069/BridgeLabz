using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    /// <summary>
    /// This is IRepositoryuser Interface
    /// </summary>
    public interface IRepositoryuser
    {
        /// <summary>
        /// Registrations the specified registration model.
        /// </summary>
        /// <param name="registrationModel">The registration model.</param>
        /// <returns></returns>
        Task<int> Registration(RegistrationModel registrationModel);
        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        string Login(LoginModel loginModel);
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPassword">The reset password.</param>
        /// <returns></returns>
        Task<string> ResetPassword(ResetPassword resetPassword);
        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="forgotPasswordModel">The forgot password model.</param>
        /// <returns></returns>
        Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel);
        /// <summary>
        /// Checks the password.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool CheckPassword(string email, string password);
        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        string Logout(LoginModel loginModel);
        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<bool> GoogleLogin(LoginModel loginModel);
        /// <summary>
        /// Facebooks the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<bool> FacebookLogin(LoginModel loginModel);
    }
}
