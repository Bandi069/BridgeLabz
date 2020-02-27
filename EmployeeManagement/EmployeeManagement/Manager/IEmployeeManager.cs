using EmployeeManagement.Models;
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
        string AddEmployee(ModelClass Emp);
        string UpdateEmployee(ModelClass Emp);
        string DeleteEmployee(int EmployeeID);
        List<ModelClass> Retrieve();
    }
}
