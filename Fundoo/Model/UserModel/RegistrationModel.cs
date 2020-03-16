// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegistrationModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    /// <summary>
    /// This is User Registartion Model Class
    /// </summary>
    public class RegistrationModel
    {
        /// <summary>
        /// This is private string variable firstname
        /// </summary>
        private string firtsname;
        /// <summary>
        /// This is private string variable Lastname
        /// </summary>
        private string lastname;
        /// <summary>
        /// This is private string variable emailid
        /// </summary>
        private string emailid;
        /// <summary>
        /// This is private string  variable Password
        /// </summary>
        private string password;
        /// <summary>
        /// This is  FirstName Property
        /// </summary>
        [Required]
        public string FirtsName { get => firtsname; set => firtsname = value; }
        /// <summary>
        /// This is LastName Property
        /// </summary>
        [Required]
        public string LastName { get => lastname; set => lastname = value; }
        /// <summary>
        /// This is Emailid Property
        /// It is a Primary key
        /// </summary>
        [Key]
        [Required]
        public string Emailid { get => emailid; set => emailid = value; }
        /// <summary>
        /// This is Password Property
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password Length should be Min 8 Characters")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        
    }
}
