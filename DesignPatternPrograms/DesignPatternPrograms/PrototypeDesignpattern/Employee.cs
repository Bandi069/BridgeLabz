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

    class EmployeeProp
    {
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
    }
}
