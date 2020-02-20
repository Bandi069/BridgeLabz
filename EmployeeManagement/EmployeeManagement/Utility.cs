using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeManagement
{
    public class Utility
    {
        public static void Connection()
        {
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
