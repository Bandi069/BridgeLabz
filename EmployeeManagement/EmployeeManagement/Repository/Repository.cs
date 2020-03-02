// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositary
{
    /// <summary>
    /// This is Repository Class 
    /// All CRUD Operations done in this class
    /// </summary>
    public class Repository : RepositoryInterface
    {
        private SqlConnection connect;
        ModelClass Modelobj = new ModelClass();
        /// <summary>
        /// This is method for connection
        /// </summary>
        public void Connect()
        {
            // string ConnectionName = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            string ConnectionName = "Server=(Localdb)\\MSSQLLocaldb;Database=EmployeeManagement;integrated Security=SSPI";
            connect = new SqlConnection(ConnectionName);
        }
        /// <summary>
        /// This is Model Class for getting all empoyees data
        /// </summary>
        /// <returns></returns>
        public List<ModelClass> GetAllEmloyees()
        {
            Connect();
            List<ModelClass> employeeslist = new List<ModelClass>();
            SqlCommand command = new SqlCommand("ViewEmployees", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open();
            adapter.Fill(dataTable);
            connect.Close();

            employeeslist = (from DataRow data in dataTable.Rows

                         select new ModelClass()
                         {
                             EmployeeID = Convert.ToInt32(data["EmployeeID"]),
                             FirstName = Convert.ToString(data["FirstName"]),
                             LastName = Convert.ToString(data["LastName"]),
                             PhoneNumber = Convert.ToString(data["PhoneNumber"]),
                             EmailID = Convert.ToString(data["EmailID"]),
                            
                         }).ToList();

            return employeeslist;
        }
        /// <summary>
        /// THis is Add Employee Method in Repository  Class
        /// </summary>
        /// <param name="Modelobj"></param>
        /// <returns></returns>
        public bool AddEmployee(ModelClass Modelobj)
        {
            Connect();
            SqlCommand Cmd = new SqlCommand("AddNewEmpDetails", connect);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@FirstName", Modelobj.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", Modelobj.LastName);
            Cmd.Parameters.AddWithValue("@EmailID", Modelobj.EmailID);
            Cmd.Parameters.AddWithValue("@PhoneNumber", Modelobj.PhoneNumber);
            connect.Open();
            int v = Cmd.ExecuteNonQuery();
            connect.Close();
            if (v >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// This is method for Update Employee
        /// </summary>
        /// <param name="ModelObj"></param>
        public bool UpdateEmployee(ModelClass Modelobj)
        {
            Connect();
            SqlCommand Command = new SqlCommand("UpdateEmployee", connect);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@EmployeeID", Modelobj.EmployeeID);
            Command.Parameters.AddWithValue("@FirstName", Modelobj.FirstName);
            Command.Parameters.AddWithValue("@LastName", Modelobj.LastName);
            Command.Parameters.AddWithValue("@EmailID", Modelobj.EmailID);
            Command.Parameters.AddWithValue("@PhoneNumber", Modelobj.PhoneNumber);
            connect.Open();
            int v = Command.ExecuteNonQuery();
            connect.Close();
            if (v >= 1)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This is Method for delete the employee from Database
        /// </summary>
        /// <param name="EmployeeID"></param>
        public bool DeleteEmployee(int EmployeeID)
        {
            Connect();
            SqlCommand DeleteCommand = new SqlCommand("DeleteEmployee", connect);
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            DeleteCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            connect.Open();
            int i = DeleteCommand.ExecuteNonQuery();
            connect.Close();
            if (i >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


