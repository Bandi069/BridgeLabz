/*using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.PrototypeDesignpattern
{
    /// <summary>
    /// This is ProtoType Operations Class
    /// </summary>
    public class ProtoTypeOperation
    {
        /// <summary>
        /// Method for Cloning 
        /// </summary>
        public void CloneOperation()
        {
            ////object creation for the Employeeposition
            EmployeePosition EmployeeObj = new EmployeePosition();
            Console.WriteLine("Enter Employee ID ");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Employee Name");
            string EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter employee Department");
            string EmployeeDepartment = Console.ReadLine();
            EmployeeObj.EmployeeName = EmployeeName;
            EmployeeObj.EmployeeDepartment = EmployeeDepartment;
            EmployeeObj.EmployeeID = EmployeeID;

            EmployeeObj.GetDetails();
            EmployeePosition EmployeeClone = (EmployeePosition)EmployeeObj.Clone();

        }

    }
}
*/