using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    /// <summary>
    /// This is Fog=rgotpassword Model Class
    /// </summary>
    public class ForgotPasswordModel
    {
        
        private string email;
        [EmailAddress]
        public string Email { get => email; set => email = value; }

        
    }
}
