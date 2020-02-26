using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatternPrograms.Annotations
{
    /// <summary>
    /// This is Annotation Class
    /// </summary>
    public class AnnotationClass
    {
        private string Customername;

        [Required(ErrorMessage = "Name Should not Null"), MaxLength(20)]
        [RegularExpression(@"^[A-Z]{1,20}[0-9]{1,5}$", ErrorMessage = "Enter Uppercase Letters and Numbers Only")]
        //// Employee Name Property
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
