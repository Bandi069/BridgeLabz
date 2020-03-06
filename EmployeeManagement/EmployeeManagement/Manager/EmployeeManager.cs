// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Manager
{
    using EmployeeManagement.Models;
    using EmployeeManagement.Repositary;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// This is Manager Class
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// Employee repository
        /// </summary>
        private readonly RepositoryInterface EmployeeRepositary;
        /// <summary>
        /// This is Constructor of Manager
        /// </summary>
        /// <param name="Repositary"></param>
        public EmployeeManager(RepositoryInterface EmployeeRepositary)
        {
            this.EmployeeRepositary = EmployeeRepositary;
        }

        public EmployeeManager()
        {
        }

        /// <summary>
        /// This is Add Employee Method
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public async Task<bool> AddEmployee(ModelClass Emp)
        {
             this.EmployeeRepositary.AddEmployee(Emp);
                return true;
            //if (EmployeeRepositary.AddEmployee(Emp))
            //{
            //    return true; //// Added employee to the list
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool DeleteEmployee(ModelClass deleteemp)
        {
            return false;
        }

        /// <summary>
        /// This is Update Employee method
        /// </summary>
        /// <param name="updateemployee"></param>
        /// <returns></returns>
        public bool UpdateEmployee(ModelClass Emp)
        {
            bool result = this.EmployeeRepositary.UpdateEmployee(Emp);
            return result;
            //if (EmployeeRepositary.UpdateEmployee(Emp))
            //{
            //    return "In the list Employee Updated Successfully";
            //}
            //return "Employee Not Updated in the list";
        }
        /// <summary>
        /// This is Delete employee Method
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int EmployeeID)
        {
            bool result = this.EmployeeRepositary.DeleteEmployee(EmployeeID);
            return result;
            /* if (EmployeeRepositary.DeleteEmployee(EmployeeID))
             {
                 return "In the list Employee Delete Successfully";
             }
             return "Employee Not Deleted in the list";*/
        }
        /// <summary>
        /// This is retrieve of lemployee ist
        /// </summary>
        /// <returns></returns>
        public List<ModelClass> Retrieve()
        {
            return EmployeeRepositary.GetAllEmloyees();
        }

    }
}
