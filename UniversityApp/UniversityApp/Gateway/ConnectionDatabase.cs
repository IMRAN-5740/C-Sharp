using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UniversityApp.Gateway
{
    public class ConnectionDatabase
    {
        private SqlConnection connection;
        public SqlConnection GetConnection()
        {
            connection = new SqlConnection("Data Source=MOHAMMAD-IMRAN;Initial Catalog=University_Info;Persist Security Info=True;User ID=sa;Password=imran");
            if(connection.State==ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }
            return connection;
        }
        public void CloseConnection()
        {
            if(connection != null)
            {
                connection.Close ();
            }
        }
    }
}