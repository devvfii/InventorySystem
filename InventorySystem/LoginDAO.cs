using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    internal class LoginDAO
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        bool debug_mode;

        public UserObject user_details;

        public LoginDAO(bool debugging)
        {
            debug_mode = debugging;
        }
        public LoginDAO()
        {
            debug_mode = false;
        }

        public void open_connection()
        {
            connection = new MySqlConnection("server=localhost;userid=root;password='d28018d6ba!';database=system");
            try
            {
                if (debug_mode)
                {
                    Debug.WriteLine("Connecting to MySQL...");
                    connection.Open();
                    Debug.WriteLine("Successful");
                }
                else
                {
                    connection.Open();
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error");
                Debug.WriteLine(ex.ToString());
            }
        }

        public void close_connection()
        {
            connection.Close();
            if (debug_mode)
            {
                Debug.WriteLine("Done.");
            }
        }

        public bool verify_login(string username, string password)
        {
            open_connection();

            command = new MySqlCommand("SELECT * FROM permissions WHERE user_name='" + username + "' AND pass='" + password + "' LIMIT 1", connection);

            using (reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    user_details = new UserObject
                    {
                        user_id = reader.GetInt32(0),
                        user_branch = reader.GetString(1),
                        user_division = reader.GetString(2),
                        user_fullname = reader.GetString(3),
                        user_level = reader.GetInt32(6)
                    };
                    close_connection();

                    return true;
                }
            }

            close_connection();
            return false;
        }
    }
}
