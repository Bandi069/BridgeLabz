using EmployeeManagement.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    /// <summary>
    /// This is interface of Employee Manager
    /// </summary>
    public interface IEmployeeManager
    {
        string AddEmployee(Repository addemployee);
        string UpdateEmp(Repository updateemployee);
        string Delete(int employeeid);
    }
}
