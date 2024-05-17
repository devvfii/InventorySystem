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
    public partial class HomePage : Form
    {
        public LoginForm login = new LoginForm();
        public ManageInventoryForm inventory = new ManageInventoryForm();
        public HomePage()
        {
            InitializeComponent();
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
    }
}
