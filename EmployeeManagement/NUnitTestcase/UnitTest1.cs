using EmployeeManagement.Controllers;
using EmployeeManagement.Manager;
using EmployeeManagement.Models;
using EmployeeManagement.Repositary;
using NUnit.Framework;
using System;

namespace NUnitTestcase
{
    /// <summary>
    /// This is NUnit Test Cases Class
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// This is test case for Add Employee
        /// </summary>
        [Test]
        public void AddEmployee()
        {
           
                var emplo = new ModelClass();
                emplo.EmployeeID = 1234;
                emplo.FirstName = "Venu";
                emplo.LastName = "ssff";
                emplo.EmailID = "Vfse@hsjd.com";
                emplo.PhoneNumber = "7894561023";
                var objmanager = new EmployeeManager();
               Assert.IsNotNull( objmanager.AddEmployee(emplo));
      
        }
        /// <summary>
        /// This is Test Case for Update Employee
        /// </summary>
        [Test]
        public void UpdateEmployee( )
        {
            try
            {
                var employ = new ModelClass();
                employ.EmployeeID = 134;
                employ.FirstName = "Hello";
                employ.LastName = "helooo";
                employ.EmailID = "bandi@hhh.com";
              employ.PhoneNumber = "9845102367";
               //var objmanager = new EmployeeManager();
               //Assert.NotNull( objmanager.UpdateEmployee(employ));
               
            }
            catch (Exception e)
            {
                Assert.AreEqual("SqlException", e.GetType().FullName);
            }
        }
        /// <summary>
        /// This is Test Case for DeleteEmployee
        /// </summary>
        [Test]
        public void DeleteEmployee()
        {
            var deleteemp = new ModelClass();
            deleteemp.EmployeeID = 1234;
            var objmanager = new EmployeeManager();
            objmanager.DeleteEmployee(deleteemp);
            Assert.False(objmanager.DeleteEmployee(deleteemp));
        }
        /// <summary>
        /// This is Test case for Retrieving the employee list
        /// </summary>
        [Test]
        public void Retrieve()
        {
            try
            {
                var retrieveemp = new ModelClass();
                retrieveemp.EmployeeID = 1245;
                retrieveemp.FirstName = "helop";
                retrieveemp.LastName = "heklasd";
                retrieveemp.EmailID = "Venu@jdj.com";
                retrieveemp.PhoneNumber = "7410258963";
                // var objmanager = new EmployeeManager();
                //  objmanager.Retrieve();
            }
            catch (Exception E)
            {
                Assert.AreEqual("excepotion", E.GetType().Name);
            }
        }
    }
}