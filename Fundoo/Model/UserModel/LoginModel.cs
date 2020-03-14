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
        /// <summary>
        /// The emailid
        /// </summary>
        private string emailid;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        [Key]
        public string Emailid { get => emailid; set => emailid = value; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get => password; set => password = value; }
    }
}
