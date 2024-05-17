using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class ManageInventoryForm : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        public ManageInventoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;userid=root;password='d28018d6ba!';database=system");

            try
            {
                System.Diagnostics.Debug.WriteLine("Connecting to MySQL...");
                connection.Open();
                System.Diagnostics.Debug.WriteLine("Successful");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            connection.Close();
            System.Diagnostics.Debug.WriteLine("Done.");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                textBox13.Enabled = false;
                textBox12.Enabled = true;
            }
            else
            {
                textBox13.Enabled = true;
                textBox12.Enabled = false;
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Enabled)
            {
                textBox13.Text = "CUSTOM";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //unselect any from datagridview
        }
    }
}
