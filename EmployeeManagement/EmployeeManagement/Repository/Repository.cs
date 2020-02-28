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
        ModelClass ModelObj = new ModelClass();
        /// <summary>
        /// This is method for connection
        /// </summary>
        public void Connect()
        {
            // string ConnectionName = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            string ConnectionName = "database=.;databse=EmployeeManagement;integrated Security=SSPI";
            connect = new SqlConnection(ConnectionName);
        }
        /// <summary>
        /// This is enumerable Model Class for getting all empoyees data
        /// </summary>
        /// <returns></returns>
        public List<ModelClass> GetAllEmloyees()
        {
            Connect();
            //// This is list of Employees
            List<ModelClass> listEmployee = new List<ModelClass>();
            //// This is for Sql Connection
            SqlCommand cmd = new SqlCommand("ViewEmployees", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open(); //// To open the Connection
            SqlDataReader reader = cmd.ExecuteReader();//// To Read the Excutable file
            while (reader.Read())
            {

                ModelObj.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                ModelObj.FirstName = reader["FirstName"].ToString();
                ModelObj.LastName = reader["LastName"].ToString();
                ModelObj.EmailID = reader["EmailID"].ToString();
                ModelObj.PhoneNumber = reader["Phone Number"].ToString();
               
            }
            connect.Close(); //// Closinng Connection
            return listEmployee;
        }
        public bool AddEmployee(ModelClass ModelObj)
        {
            Connect();
            SqlCommand Cmd = new SqlCommand("AddEmployee", connect);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@EmployeeID", ModelObj.EmployeeID);
            Cmd.Parameters.AddWithValue("@FirstName", ModelObj.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", ModelObj.LastName);
            Cmd.Parameters.AddWithValue("@EmailID", ModelObj.EmailID);
            Cmd.Parameters.AddWithValue("@PhoneNumber", ModelObj.PhoneNumber);
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
        public bool UpdateEmployee(ModelClass ModelObj)
        {
            SqlCommand Command = new SqlCommand("Update Employee", connect);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@EmployeeId", ModelObj.EmployeeID);
            Command.Parameters.AddWithValue("@FirstName", ModelObj.FirstName);
            Command.Parameters.AddWithValue("@LastName", ModelObj.LastName);
            Command.Parameters.AddWithValue("@EmailID", ModelObj.EmailID);
            Command.Parameters.AddWithValue("@PhoneNumber", ModelObj.PhoneNumber);
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

            SqlCommand DeleteCommand = new SqlCommand("Delete Employee", connect);
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            DeleteCommand.Parameters.AddWithValue("@EmployeeId",EmployeeID);
            connect.Open();
            int i = DeleteCommand.ExecuteNonQuery();
            connect.Close();
            if (i > 0)
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


