using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginModel
    {
        private string emailid;
        private string password;
        [Key]
        public string Emailid { get => emailid; set => emailid = value; }
        public string Password { get => password; set => password = value; }
    }
}
