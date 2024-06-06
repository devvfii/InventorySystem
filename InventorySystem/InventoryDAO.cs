using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    internal class InventoryDAO
    {
        MySqlConnection connection;
        MySqlCommand command;

        public void openConnection()
        {
            connection = new MySqlConnection("server=localhost;userid=root;password='d28018d6ba!';database=system");
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                connection.Open();
                Debug.WriteLine("Successful");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error");
                Debug.WriteLine(ex.ToString());
            }
        }

        public void closeConnection()
        {
            connection.Close();
            Debug.WriteLine("Done.");
        }

        // make get List function from database instead
        public List<ActiveInventoryItems> inventory = new List<ActiveInventoryItems>();
    }
}
