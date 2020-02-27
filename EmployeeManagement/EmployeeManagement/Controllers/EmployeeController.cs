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
        /// 
        /// </summary>
        private IEmployeeManager EmpManager;

        public EmployeeController(IEmployeeManager EmpManager)
        {
            this.EmpManager = EmpManager;
        }
        [HttpPost]
        [Route("/Create")]
        public ActionResult AddEmployee(Repository addemployee)
        {
            try
            {
                var result = EmpManager.AddEmployee(addemployee);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost]
        [Route("Update")]
        public ActionResult UpdateEmp(Repository updateemployee)
        {
            try
            {
                var result = EmpManager.UpdateEmp(updateemployee);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("Delete")]
        public ActionResult DeleteEmployee(int EmployeeID)
        {
            try
            {
                var result = EmpManager.Delete(EmployeeID);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("Show")]
        public ActionResult GetEmployeeData(int EmployeeID)
        {
            try
            {
                var result = EmpManager.Retrieve();
              return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }
    }
}