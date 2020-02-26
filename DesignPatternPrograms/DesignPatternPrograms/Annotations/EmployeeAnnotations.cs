using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatternPrograms.Annotations
{
    /// <summary>
    /// This is Employee Annotations Class
    /// </summary>
    public class EmployeeAnnotations
    {
        /// <summary>
        /// This Method of Employee
        /// </summary>
        public void Employee()
        {    //// This is object for Annotation Class        
            AnnotationClass annotationObj = new AnnotationClass();
            annotationObj.EmployeeName = "KKLJKL6524";
            //// validationcontext by passing annotationobj
            var context = new ValidationContext(annotationObj);
            //// List of VAlidationResult to store the values
            var validationresult = new List<ValidationResult>();
            //// This gives true or false of validation
            bool BoolValid = Validator.TryValidateObject(annotationObj, context, validationresult, true);
            Console.WriteLine(BoolValid);
            //// foreach to print validation error message
            foreach(var errorresult in validationresult)
            {
                Console.WriteLine(errorresult.ErrorMessage);
            }
        }
    }
}
