
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
        /// This is model class object
        /// </summary>
        ModelClass ModelObj = new ModelClass();
        // ConnectionString ConnectionObj = new ConnectionString();
        public string connectionstring = ConnectionString.Connect();
        /// <summary>
        /// This is enumerable Model Class for getting all empoyees data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ModelClass> GetAllEmloyees()
        {
            //// This is list of Employees
            List<ModelClass> listEmployee = new List<ModelClass>();
            ///This is for Sql Connection
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
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
                    listEmployee.Add(ModelObj);
                }
                connect.Close(); //// Closinng Connection
            }
            return listEmployee;
        }
        /// <summary>
        /// This is method for Add Employee
        /// </summary>
        /// <param name="ModelObj"></param>
        public void AddEmployee(ModelClass ModelObj)
        {
            //// Sql Connection
            using (SqlConnection Connect = new SqlConnection(connectionstring))
            {
                SqlCommand Cmd = new SqlCommand("AddEmployee", Connect);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@EmployeeID", ModelObj.EmployeeID);
                Cmd.Parameters.AddWithValue("@FirstName", ModelObj.FirstName);
                Cmd.Parameters.AddWithValue("@LastName", ModelObj.LastName);
                Cmd.Parameters.AddWithValue("@EmailID", ModelObj.EmailID);
                Cmd.Parameters.AddWithValue("@PhoneNumber", ModelObj.PhoneNumber);
                Connect.Open();
                Cmd.ExecuteNonQuery();
                Connect.Close();

            }

        }
        /// <summary>
        /// This is method for Update Employee
        /// </summary>
        /// <param name="ModelObj"></param>
        public void UpdateEmployee(ModelClass ModelObj)
        {
            using (SqlConnection Connect = new SqlConnection(connectionstring))
            {
                SqlCommand Command = new SqlCommand("Update Employee", Connect);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@EmployeeId", ModelObj.EmployeeID);
                Command.Parameters.AddWithValue("@FirstName", ModelObj.FirstName);
                Command.Parameters.AddWithValue("@LastName", ModelObj.LastName);
                Command.Parameters.AddWithValue("@EmailID", ModelObj.EmailID);
                Command.Parameters.AddWithValue("@PhoneNumber", ModelObj.PhoneNumber);
                Connect.Open();
                Command.ExecuteNonQuery();
                Connect.Close();
            }
        }
        /// <summary>
        /// This is Method for delete the employee from Database
        /// </summary>
        /// <param name="EmployeeID"></param>
        public void DeleteEmployee(int EmployeeID)
        {
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                SqlCommand DeleteCommand = new SqlCommand("Delete Employee", connect);
                DeleteCommand.CommandType = CommandType.StoredProcedure;
                DeleteCommand.Parameters.AddWithValue("@EmployeeId", ModelObj.EmployeeID);
                connect.Open();
                DeleteCommand.ExecuteNonQuery();
                connect.Close();
            }

        }
        /// <summary>
        /// This is Method for Get Employee Data
        /// </summary>
        /// <param name="EmployeeID"></param>
        public void GetEmployeeData(int EmployeeID)
        {
            //// This is for Sql Connection
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID= " + EmployeeID;
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                connect.Open();//// To open the Connection
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    ModelObj.EmployeeID = Convert.ToInt32(Reader["EmployeeId"]);
                    ModelObj.FirstName = Reader["FirstName"].ToString();
                    ModelObj.LastName = Reader["LastName"].ToString();
                    ModelObj.EmailID = Reader["EmailID"].ToString();
                    ModelObj.PhoneNumber = Reader["PhoneNumber"].ToString();
                }
                connect.Close();
            }
        }

    }
}
