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
        BindingSource inventoryBindingSource = new BindingSource();
        public ManageInventoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

            dataGridView1.ClearSelection();
            //clear info from information panel too
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // dummy data
            InventoryDAO inventoryDAO = new InventoryDAO();
            ActiveInventoryItems a1 = new ActiveInventoryItems
            {
                ItemID = 1,
                ItemCode = "000 000",
                ItemName = "Test1",
                DisplayName = "Display1",
                Description = "For Testing",
                DateAdded = "05-20-2024",
                DP = 100,
                SRP = 150,
                VAT = 0.12,
                EffectivePrice = 150 / (1 - 0.12),
                Quantity = 10
            };
            ActiveInventoryItems a2 = new ActiveInventoryItems
            {
                ItemID = 2,
                ItemCode = "000 001",
                ItemName = "Test2",
                DisplayName = "Display2",
                Description = "For Testing",
                DateAdded = "05-20-2024",
                DP = 200,
                SRP = 250,
                VAT = 0.12,
                EffectivePrice = 250 / (1 - 0.12),
                Quantity = 40
            };

            inventoryDAO.inventory.Add(a1);
            inventoryDAO.inventory.Add(a2);

            // connect list to grid view
            inventoryBindingSource.DataSource = inventoryDAO.inventory;
            dataGridView1.DataSource = inventoryBindingSource;
            dataGridView1.Select();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox7.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                textBox7.Text = "empty";
            }

        }
    }
}
