using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Maintenance1
{
    internal class DB
    {

        public MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=Mysql.123@h;database=test");
        public DB() { }

        public void openconnection()
        {
            MySqlConnection conn = new MySqlConnection();
           
            conn.Open();
        }
        public void closeconnection()
        {
            MySqlConnection conn = new MySqlConnection();

            conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
