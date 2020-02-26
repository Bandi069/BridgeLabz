// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Manager.cs" company="Bridgelabz">
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
    public class Manager : IEmployeeManager
    {
        private RepositoryInterface EmployeeRepositary;
        /// <summary>
        /// This is Constructor of Manager
        /// </summary>
        /// <param name="Repositary"></param>
        public Manager(RepositoryInterface EmployeeRepositary)
        {
            this.EmployeeRepositary = EmployeeRepositary;
        }
        /// <summary>
        /// This is add employee manager method
        /// </summary>
        /// <param name="addemployee"></param>
        /// <returns></returns>
        public string AddEmployee(ModelClass addemployee)
        {
            if (EmployeeRepositary.AddEmployee(addemployee))
            {
                return "Employee added to the list Successfully";
            }
            return "Employee not added to the list";
        }
        /// <summary>
        /// This is Update Employee method
        /// </summary>
        /// <param name="updateemployee"></param>
        /// <returns></returns>
        public string UpdateEmp(EmployeeRepositary updateemployee)
        {
            if (EmployeeRepositary.UpdateEmployee(updateemployee))
            {
                return "In the list Employee Updated Successfully";
            }
            return "Employee Not Updated in the list";
        }
        /// <summary>
        /// This is Delete employee Method
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        public string Delete(int EmployeeId)
        {
            if (Repository.DeleteEmployee(EmployeeId))
            {
                return "In the list Employee Delete Successfully";
            }
            return "Employee Not Deleted in the list";
        }
        /// <summary>
        /// This is retrieve of lemployee ist
        /// </summary>
        /// <returns></returns>
        public List<ModelClass> Retrieve()
        {
            return Repository.GetEmployeeData();

        }

       
    }
}
