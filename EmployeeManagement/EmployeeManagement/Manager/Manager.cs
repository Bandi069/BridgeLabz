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
        private RepositoryInterface Repositary;
        /// <summary>
        /// This is Constructor of Manager
        /// </summary>
        /// <param name="Repositary"></param>
        public Manager(RepositoryInterface Repositary)
        {
            this.Repositary = Repositary;
        }
        public string AddEmployee(Repository addemployee)
        {
            if (Repositary.AddEmployee(addemployee))
            {
                return "Employee added to the list Successfully";
            }
            return "Employee not added to the list";
        }

        public string UpdateEmp(Repository updateemployee)
        {
            if (Repository.UpdateEmployee(updateemployee))
            {
                return "In the list Employee Updated Successfully";
            }
            return "Employee Not Updated in the list";
        }
        public string Delete(int EmployeeId)
        {
            if (Repository.DeleteEmployee(EmployeeId))
            {
                return "In the list Employee Delete Successfully";
            }
            return "Employee Not Deleted in the list";
        }
        public List<ModelClass> Retrieve()
        {
            return Repository.GetEmployeeData();

        }
    }
}
