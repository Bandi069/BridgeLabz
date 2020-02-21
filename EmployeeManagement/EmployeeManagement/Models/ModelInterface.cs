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

        //ConnectionString ConnectionObj = new ConnectionString();
        string connectionstring = ConnectionString.ConnectionName();
        public IEnumerable<ModelClass> GetyllEmployees()
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

                }
            }

        }
    }
}



