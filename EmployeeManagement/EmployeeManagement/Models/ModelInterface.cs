using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface ModelInterface
    {

    }

    public class EmployeeModel
    {
        ModelClass ModelObj = new ModelClass();
        // ConnectionString ConnectionObj = new ConnectionString();
        public string connectionstring = ConnectionString.Connect();

        public IEnumerable<ModelClass> GetAllEmloyees()
        {
            List<ModelClass> listEmployee = new List<ModelClass>();
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("ViewEmployees", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ModelClass ModelObj = new ModelClass();
                    ModelObj.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    ModelObj.FirstName = reader["FirstName"].ToString();
                    ModelObj.LastName = reader["LastName"].ToString();
                    ModelObj.EmailID = reader["EmailID"].ToString();
                    ModelObj.PhoneNumber = reader["Phone Number"].ToString();
                    listEmployee.Add(ModelObj);
                }
                connect.Close();
            }
            return listEmployee;
        }
        public void AddEmployee(EmployeeModel employee)
        {
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
        public void UpdateEmployee(EmployeeModel employee)
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
        public void GetEmployeeData(int EmployeeID)
        {
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID= " + EmployeeID;
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                SqlDataReader Reader = command.ExecuteReader();
                while(Reader.Read())
                {
                    ModelObj.EmployeeID = Convert.ToInt32(Reader["EmployeeId"]);
                    ModelObj.FirstName = Reader["FirstName"].ToString();
                    ModelObj.LastName = Reader["LastName"].ToString();
                    ModelObj.EmailID = Reader["EmailID"].ToString();
                    ModelObj.PhoneNumber = Reader["PhoneNumber"].ToString();
                    
                }
            }
            
        }
    }
}



