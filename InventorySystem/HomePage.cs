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
    public partial class HomePage : Form
    {
        // Form objects
        public static HomePage mainpage; 

        public LoginForm login = new LoginForm();
        public ManageInventoryForm inventory = new ManageInventoryForm();

        public UserObject logged_user;

        //SQL
        MySqlConnection connection;
        MySqlCommand command;

        public HomePage()
        {
            InitializeComponent();
            mainpage = this;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventory.ShowDialog();
            this.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
