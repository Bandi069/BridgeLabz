using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatternPrograms.Annotations
{
    class AnnotationClass
    { 

        private string Customername;
        [Required (ErrorMessage ="Name Should not Null"),MaxLength(20)]
       
        [RegularExpression(@"^[A-Z]{1,20}[0-9]{1,5}$",ErrorMessage ="Enter Uppercase Letters and Numbers Only")]
        public string EmployeeName
        {
            get
            {
                return Customername;
            }
            set
            {
                Customername = value;
            }
            
        }

    }
}
