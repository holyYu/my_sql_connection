using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace my_sql_connection.myclass
{
    internal class class_connection
    {
        public MySqlConnection connectdb;

        public class_connection()
        {
            string host = "localhost";
            string database = "studentdb";
            string username = "root";
            string password = "";
            string port = "3306";

            string connection_string = "datasource =" + host + ";database=" + database + "; port=" + port + "; username=" + username + ";" +
                "password=" + password + "; SslMode =none;";

            connectdb = new MySqlConnection(connection_string);
        }
    }
}
