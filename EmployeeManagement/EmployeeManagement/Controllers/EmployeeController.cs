// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Manager;
    using EmployeeManagement.Models;
    using EmployeeManagement.Repositary;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Employee manager 
        /// </summary>
        private IEmployeeManager EmpManager;
        /// <summary>
        /// Constructor for Employee Controller
        /// </summary>
        /// <param name="EmpManager"></param>
        public EmployeeController(IEmployeeManager EmpManager)
        {
            this.EmpManager = EmpManager;
        }
        /// <summary>
        /// This is Action for Add employee
        /// </summary>
        /// <param name="addemployee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Create")]
        public IActionResult AddEmployee([FromBody]ModelClass addemployee)
        {
            try
            {
                var result = EmpManager.AddEmployee(addemployee);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// This is update action of employee data
        /// </summary>
        /// <param name="updateemployee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        public ActionResult UpdateEmp(ModelClass updateemployee)
        {
            try
            {
                var result = EmpManager.UpdateEmployee(updateemployee);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// This is Delete action of employee data from the database
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Delete")]
        public ActionResult DeleteEmployee(int EmployeeID)
        {
            try
            {
                var result = EmpManager.DeleteEmployee(EmployeeID);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// This is Get employee data action 
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Show")]
        public ActionResult GetEmployeeData(int EmployeeID)
        {
            try
            {
                var result = EmpManager.Retrieve();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}