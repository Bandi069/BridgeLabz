using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    public class UserRegistration
    {
        [Required]
        public string UserName{ get; set; }
        [Required]
        public string EmailID { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
