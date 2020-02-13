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

    public class EmployeeProp : Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
        public int EmployeeID { get; set; }
    }
}
