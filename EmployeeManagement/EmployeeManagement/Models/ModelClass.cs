using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class ModelClass : ModelInterface
    {
        public int EmpplyeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmaidlID { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmployeeAddress { get; set; }
    }
}
