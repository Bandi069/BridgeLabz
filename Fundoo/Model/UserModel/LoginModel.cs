using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    /// <summary>
    /// This is Login Model Class
    /// </summary>
    public class LoginModel
    {

        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
