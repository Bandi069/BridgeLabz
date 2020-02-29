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
            //// This is list of Employees
            List<ModelClass> listEmployee = new List<ModelClass>();
            //// This is for Sql Connection
            SqlCommand cmd = new SqlCommand("ViewEmployees", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open(); //// To open the Connection
            SqlDataReader reader = cmd.ExecuteReader();//// To Read the Excutable file
            while (reader.Read())
            {

                Modelobj.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                Modelobj.FirstName = reader["FirstName"].ToString();
                Modelobj.LastName = reader["LastName"].ToString();
                Modelobj.EmailID = reader["EmailID"].ToString();
                Modelobj.PhoneNumber = reader["Phone Number"].ToString();

            }
            connect.Close(); //// Closinng Connection
            return listEmployee;
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
            Cmd.Parameters.AddWithValue("@EmployeeID", Modelobj.EmployeeID);
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


