// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelClass.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// This is Model Class 
    /// </summary>
    public class ModelClass
    {
        /// <summary>
        /// This is integer property of Employee ID
        /// </summary>
        [Required(ErrorMessage = "*EmployeeID Required")]
        public int EmployeeID { get; set; }
        /// <summary>
        /// This is String property of FirstName
        /// </summary>
        [Required(ErrorMessage = "*FirstName Required")]
        public string FirstName { get; set; }
        /// <summary>
        /// This is string property of Last Name
        /// </summary>
        [Required(ErrorMessage = "*LastName Required")]
        public string LastName { get; set; }
        /// <summary>
        /// This is string Email ID property 
        /// </summary>
        [Required(ErrorMessage = "*Email ID Required")]
        public string EmailID { get; set; }
        /// <summary>
        /// This is string property of Phone Number
        /// </summary>
        [Required(ErrorMessage = "*PhoneNumber Required")]
        public string PhoneNumber { get; set; }

    }
}
