using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatternPrograms.Annotations
{
    class EmployeeAnnotations
    {
        public void Employee()
        {
            
            AnnotationClass annotationObj = new AnnotationClass();
            annotationObj.EmployeeName = "";
            var context = new ValidationContext(annotationObj,null);
            var validationresult = new List<ValidationResult>();
            bool BoolValid = Validator.TryValidateObject(annotationObj, context,ValidationResult,true);
            Console.WriteLine(BoolValid);
        }
    }
}
