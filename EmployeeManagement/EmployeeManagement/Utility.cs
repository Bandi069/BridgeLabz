using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace EmployeeManagement
{
    public class Utility    
    {
        public static void Connection()
        {
           // string ConnectionName = ConfigurationManager.ConnectionStrings[0].ConnectionString;
           string ConnectionName = "database=.;databse=EmployeeManagement;integrated Security=SSPI";
            SqlConnection connect = new SqlConnection(ConnectionName);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT *from Employee", connect);
                connect.Open();
                cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("Exception Occurs");
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
