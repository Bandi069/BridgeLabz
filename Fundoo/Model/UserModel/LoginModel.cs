using System;
using System.Collections.Generic;
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

        public string Emailid { get => emailid; set => emailid = value; }
        public string Password { get => password; set => password = value; }
    }
}
