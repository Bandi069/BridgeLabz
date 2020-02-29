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
        /// <summary>
        /// This is Add Employee 
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        string AddEmployee(ModelClass Emp);
        /// <summary>
        /// This is update the employee data
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        string UpdateEmployee(ModelClass Emp);
        /// <summary>
        /// This is for delete the employee data
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        string DeleteEmployee(int EmployeeID);
        /// <summary>
        /// This is for retrieving the employee data
        /// </summary>
        /// <returns></returns>
        List<ModelClass> Retrieve();
    }
}
