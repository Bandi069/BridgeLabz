using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.PrototypeDesignpattern
{
    /// <summary>
    /// Employee interface 
    /// </summary>
    public interface Employee
    {
        /// <summary>
        /// Cloning method of Employee
        /// </summary>
        /// <returns></returns>
        Employee Clone();

        /// <summary>
        /// For getting the details 
        /// </summary>
        void GetDetails();
    }
    /// <summary>
    /// Prototype Class
    /// </summary>
    public class ProtoType { }
    /// <summary>
    /// Property Class 
    /// </summary>
    public class EmployeePosition : Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
        public int EmployeeID { get; set; }

    }
    /// <summary>
    /// Clonning method
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        //// Shallow Copy
        return object MemberwiseClone();
    }
    /// <summary>
    /// Method for Getting Details
    /// </summary>
    public void GetDetails()
    {
        Console.WriteLine("Employee-\n ID" + this.EmployeeID + "\nEmployee Name :" + this.EmployeeName + "\nEmployee Department" + this.EmployeeDepartment);

    }
}
