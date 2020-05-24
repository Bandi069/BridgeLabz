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
        private string firstName;
        /// <summary>
        /// This is private string variable Lastname
        /// </summary>
        private string lastName;
        /// <summary>
        /// This is private string variable emailid
        /// </summary>
        private string email;
        /// <summary>
        /// This is private string  variable Password
        /// </summary>
        private string password;
        /// <summary>
        /// This is  FirstName Property
        /// </summary>
        [Required]
        public string FirstName { get => firstName; set => firstName = value; }
        /// <summary>
        /// This is LastName Property
        /// </summary>
        [Required]
        public string LastName { get => lastName; set => lastName = value; }

        /// <summary>
        /// This is Emailid Property
        /// It is a Primary key
        /// </summary>
        [Key]
        [Required]
        public string Email { get => email; set => email = value; }
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
