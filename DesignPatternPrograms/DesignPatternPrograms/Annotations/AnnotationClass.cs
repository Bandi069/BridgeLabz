using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatternPrograms.Annotations
{
    class AnnotationClass
    { 

        private string Customername;
        [Required (ErrorMessage ="Name Should not Null")]
        [StringLength(20)]
        [RegularExpression(@"[A-Z]{20}$")]
        private string EmployeeName
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
