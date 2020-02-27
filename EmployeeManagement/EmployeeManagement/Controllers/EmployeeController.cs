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
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeManager EmpManager;

        public EmployeeController(IEmployeeManager EmpManager)
        {
            this.EmpManager = EmpManager;
        }
        public ActionResult AddEmployee(ModelClass Emp)
        {
            try
            {
                var result = EmpManager.Addemployee(Emp);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost]
        [Route("Update")]
        public ActionResult Updateemployee(ModelClass Emp)
        {
            try
            {
                var result = EmpManager.UpdateEmp(Emp);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}