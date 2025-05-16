using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _2025_04_10_MySQLKapcsolat
{
    class DataBaseConnection
    {
        public static MySqlConnection connection = new MySqlConnection();

        private static string server = "localhost"; //127.0.0.1
        private static string userid = "root";
        private static string password = "";
        private static string database = "webshop";

        public static MySqlConnection DataSource()
        {
            connection = new MySqlConnection(
                $"server={server}; pwd={password}; database={database}; uid={userid}");
            return connection;
        }

        public bool ConnOpen()
        {
            try
            {
                DataSource();
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConnClose()
        {
            try
            {
                DataSource();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> TableNames()
        {
            List<string> tableNames = null;
            if (ConnOpen())
            {
                //SHOW TABLES;
                tableNames = new List<string>();
                string command = "show tables";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tableNames.Add(reader[0].ToString());
                }
                ConnClose();
            }
            return tableNames;
        }

        public List<List<string>> TablaAdatai(string tablaNev)
        {
            List<List<string>> datas = null;
            if (ConnOpen())
            {
                //Select * from termekek
                datas = new List<List<string>>();
                string command = "Select * from "+tablaNev;
                MySqlCommand cmd = new MySqlCommand(command, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<string> st = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        st.Add(reader[i].ToString());
                    }
                    datas.Add(st);
                }
                ConnClose();
            }
            return datas;
        }


    }
}
