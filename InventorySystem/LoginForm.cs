using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        LoginDAO loginDAO;
        public LoginForm()
        {
            InitializeComponent();
            loginDAO = new LoginDAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginDAO.verify_login(textBox1.Text, textBox2.Text))
            {
                // get user info as object and pass onto homepage
                HomePage home = new HomePage();
                home.logged_user = loginDAO.user_details;
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login details invalid");
                textBox2.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
