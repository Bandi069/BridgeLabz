// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Manager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeManagement.Manager
{
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

        }
    }
}
