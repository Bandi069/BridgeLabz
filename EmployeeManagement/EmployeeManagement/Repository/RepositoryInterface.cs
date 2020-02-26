// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryInterface.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------


namespace EmployeeManagement.Repositary
{
    using EmployeeManagement.Manager;
    using EmployeeManagement.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// This is Interface 
    /// </summary>
    public interface RepositoryInterface
    {
        /// <summary>
        ///This is Add employee model interface 
        /// </summary>
        /// <param name="ModelObj"></param>
        void AddEmployee(ModelClass ModelObj);
        /// <summary>
        /// This is update Employee
        /// </summary>
        /// <param name="ModelObj"></param>
        void UpdateEmployee(ModelClass ModelObj);
        /// <summary>
        /// This is Delete Employee
        /// </summary>
        /// <param name="EmployeeID"></param>
        void DeleteEmployee(int EmployeeID);
        /// <summary>
        /// This is Get Employee Data
        /// </summary>
        /// <param name="EmployeeID"></param>
        void GetEmployeeData(int EmployeeID);
       
    }
}
