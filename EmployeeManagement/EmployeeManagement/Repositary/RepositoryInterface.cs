using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositary
{
    /// <summary>
    /// This is Interface 
    /// </summary>
    public interface RepositoryInterface
    {

        void AddEmployee(ModelClass ModelObj);
        void UpdateEmployee(ModelClass ModelObj);
        void DeleteEmployee(int EmployeeID);
        void GetEmployeeData(int EmployeeID);

    }
}
