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
      // ConnectionString ConnectionObj = new ConnectionString();
        string connectionstring = ConnectionString.Connect();

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
            using(SqlConnection Connect=new SqlConnection(connectionstring))
            {
                SqlCommand Cmd = new SqlCommand();

            }
          //  return;
        }
    }
}



