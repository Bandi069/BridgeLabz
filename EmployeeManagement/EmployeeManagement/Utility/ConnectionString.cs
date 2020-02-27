// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectionString.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------


namespace EmployeeManagement
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using System.Configuration;
    using Microsoft.IdentityModel.Protocols;
    /// <summary>
    /// This is Conncetion String class in utility folder
    /// </summary>
    public class ConnectionString
    {
        /// <summary>
        /// This is method for connection
        /// </summary>
        public void Connect()
        {
            // string ConnectionName = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            string ConnectionName = "database=.;databse=EmployeeManagement;integrated Security=SSPI";
            SqlConnection connect = new SqlConnection(ConnectionName);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT *from Employee", connect);
                connect.Open();//// this is open for connection
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

