// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeManagement.Repositary
{
    using EmployeeManagement.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// This is Repository Class 
    /// All CRUD Operations done in this class
    /// </summary>
    public class Repository : RepositoryInterface
    {
        /// <summary>
        /// THis is Sql Connection 
        /// </summary>
        private SqlConnection connect;
        /// <summary>
        /// Model class Object
        /// </summary>
        ModelClass Modelobj = new ModelClass();
        public static string ConnectionName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeManagement;Integrated Security=True"
;

        /// <summary>
        /// This is method for connection
        /// </summary>
        public void Connect()
        {
            // string ConnectionName = ConfigurationManager.ConnectionStrings[0].ConnectionString;
           // string ConnectionName = "Server=(Localdb)//MSSQLLocaldb;Database=EmployeeManagement;integrated Security=SSPI";
            connect = new SqlConnection(ConnectionName);
        }
        /// <summary>
        /// This is Model Class for getting all empoyees data
        /// </summary>
        /// <returns></returns>
        public List<ModelClass> GetAllEmloyees()
        {
            Connect(); //// Calling Sql connection by Connect method
            List<ModelClass> employeeslist = new List<ModelClass>();
            SqlCommand command = new SqlCommand("ViewEmployees", connect);//// Sql Stored Procedure
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open(); //// For Open the Connection
            adapter.Fill(dataTable);
            connect.Close(); //// For Open the Connection
            //// Employee list to get all the data
            employeeslist = (from DataRow data in dataTable.Rows
                             select new ModelClass()
                             {
                                 EmployeeID = Convert.ToInt32(data["EmployeeID"]),
                                 FirstName = Convert.ToString(data["FirstName"]),
                                 LastName = Convert.ToString(data["LastName"]),
                                 PhoneNumber = Convert.ToString(data["PhoneNumber"]),
                                 EmailID = Convert.ToString(data["EmailID"]),

                             }).ToList();
            //// ruturning the employee list from sql database
            return employeeslist;
        }

        /// <summary>
        /// THis is Add Employee Method in Repository  Class
        /// </summary>
        /// <param name="Modelobj"></param>
        /// <returns></returns>
        public bool AddEmployee(ModelClass Modelobj)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionName))
            {
                SqlCommand cal = new SqlCommand("AddNewEmpDetails", sqlConnection);
                cal.CommandType = CommandType.StoredProcedure;
                
                cal.Parameters.AddWithValue("@EmployeeID", Modelobj.EmployeeID);
                cal.Parameters.AddWithValue("@FirstName", Modelobj.FirstName);
                cal.Parameters.AddWithValue("@LastName", Modelobj.LastName);
                cal.Parameters.AddWithValue("@EmailID", Modelobj.EmailID);
                cal.Parameters.AddWithValue("@PhoneNumber", Modelobj.PhoneNumber);
                sqlConnection.Open();
                var i=cal.ExecuteNonQuery();
                sqlConnection.Close();
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


