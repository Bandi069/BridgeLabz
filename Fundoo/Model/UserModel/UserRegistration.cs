using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    /// <summary>
    /// This is User Registartion Model Class
    /// </summary>
    public class UserRegistration
    {
        private string firtsname;
        private string lastname;
        private string emailid;
        private string password;
        private string confirmPassword;
        [Required]
        public string LastName { get => lastname; set => lastname = value; }
        [Required]
        public string FirtsName { get => firtsname; set => firtsname = value; }
        [Required]
        public string Emailid { get => emailid; set => emailid = value; }
        [Required]
        [StringLength(14,MinimumLength =8,ErrorMessage ="Password Length should be 8Characters")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password Not Matched")]
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
    }
}
