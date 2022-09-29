using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FitnessApp440.Helper
{

    // This class is connections to the SQL Database
    public static class SqlConnection
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sdm;

        public static void EstablishConnection()
        {
             String ConnectionResult;

            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "107.180.1.16";
                builder.UserID = "440fall20224";
                builder.Password = "440fall20224";
                builder.Database = "440fall20224";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                ConnectionResult = " Database Connectioi Successful";

            }
            catch(Exception ex)
            {
                ConnectionResult = "Connection Failed";
            }
        }
    }
}

