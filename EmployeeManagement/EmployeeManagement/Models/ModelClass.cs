using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class ModelClass 
    {
        [Required(ErrorMessage = "*EmployeeID Required")]
        public int EmployeeID { get; set; }
        [Required (ErrorMessage = "*FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*Email ID Required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "*PhoneNumber Required")]
        public string PhoneNumber { get; set; }
        
    }
}
