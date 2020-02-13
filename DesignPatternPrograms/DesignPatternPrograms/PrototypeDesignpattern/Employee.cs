using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.PrototypeDesignpattern
{
   public interface Employee
    {
        Employee Clone();

        void GetDetails();
   }
    public class ProtoType { }

    public class EmployeePosition : Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
        public int EmployeeID { get; set; }
    }
    public Employee Clone()
    {
        return (Employee)MemberwiseClone();
    }
    public void GetDetails()
    {
        Console.WriteLine("Employee-\n ID" + this.EmployeeID + "\nEmployee Name :" + this.EmployeeName + "\nEmployee Department" + this.EmployeeDepartment);

    }
}
