using System;
using System.Collections.Generic;
using System.Text;

namespace Model.UserModel
{
    public class Userlogin
    {
        private int id;
        private string emailid;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Emailid { get => emailid; set => emailid = value; }
        public string Password { get => password; set => password = value; }
    }
}
