using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.InterfaceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.UserModel;

namespace Fundoo.Controllers
{
    /// <summary>
    /// This is Account Controller Class
    /// </summary>
    //[Route("api/[controller]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// Account 
        /// </summary>
        private readonly IAccountManager accountManager;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="accountManager">The account manager.</param>
        public AccountController(IAccountManager accountManager)
        {
            this.accountManager = accountManager;
        }
        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("accountregistration")]
        public async Task<IActionResult> Registration([FromBody]RegistrationModel registrationModel)
        {
            try
            {
                var result = await this.accountManager.Registration(registrationModel);
                return this.Ok(new { result });
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("accountlogin")]
        public IActionResult NormalLogin(string email, string password)
        {
            try
            {
                var loginModel = new LoginModel
                {
                    Email=email,
                    Password=password
                };
                var result = this.accountManager.Login(loginModel);
                if (result != null)
                {
                    return this.Ok(new { result });
                }
                else
                {
                    return BadRequest("Invalid login");
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPassword">The reset password.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("resetpassword")]
        public async Task<IActionResult> ResetPassword([FromBody]ResetPassword resetPassword)
        {
            var result = this.accountManager.ResetPassword(resetPassword);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.BadRequest("Invalid Request");
        }
        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="forgotPasswordModel">The forgot password model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("forgotpassword")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPasswordModel forgotPasswordModel)
        {
            var result = this.accountManager.ForgotPassword(forgotPasswordModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.BadRequest("Invalid password");
        }
        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("googlelogin")]
        public async Task<IActionResult> GoogleLogin(LoginModel loginModel)
        {
            var result = this.accountManager.GoogleLogin(loginModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.BadRequest("Invalid google login");
        }
        /// <summary>
        /// Facebooks the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("facebooklogin")]
        public async Task<IActionResult> FacebookLogin(LoginModel loginModel)
        {
            var result = this.accountManager.FacebookLogin(loginModel);
            try
            {
                if (result != null)
                {
                    return this.Ok(new { result });
                }
                return this.BadRequest();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("logout")]
        public string Logout(LoginModel loginModel)
        {
            var result = this.accountManager.Logout(loginModel);
            return result;
        }
    }
}