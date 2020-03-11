using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
    public interface IAccountManager
    {
        Task<string> Login(LoginModel loginModel);
        Task ResetPassword(ResetPassword resetPassword);
        Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel);
        Task<bool> CheckPassword(string email, string password);
        string Logout(LoginModel loginModel);
        Task<string> GoogleLogin(LoginModel loginModel);
        Task<string> FacebookLogin(LoginModel loginModel);
    }
}
