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
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;
        public AccountController(IAccountManager accountManager)
        {
            this.accountManager = accountManager;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var result = this.accountManager.Login(loginModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.BadRequest("Invalid Login");
        }
        [HttpPost]
        [Route("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPassword resetPassword)
        {
            var result = this.accountManager.ResetPassword(resetPassword);
            if (result != null)
            {
                return this.Ok( result);
            }
            return this.BadRequest("Invalid Request");
        }
        [HttpPost]
        [Route("forgotpassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            var result = this.accountManager.ForgotPassword(forgotPasswordModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.BadRequest("Invalid password");
        }
    }
}