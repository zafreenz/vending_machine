using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Food
{
    public partial class ManageFood : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VendingMachine.mdf;Integrated Security=True";
        public ManageFood()
        {
            InitializeComponent();
        }
        private void ManageFood_Load(object sender, EventArgs e)
        {
            radioButtonManageFood.Checked = true;
            comboBox1.Items.Add("Snacks");
            comboBox1.Items.Add("Bread");
            comboBox1.Items.Add("Nuts");
            comboBox1.Items.Add("Biscuit");
            comboBox1.Items.Add("Candies");

            AddGridButtons();

            comboBox1.SelectedIndex = 0;
            LoadData();
        }
        private void AddGridButtons()
        {
            dataGridView1.Columns.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Name = "Edit";

            dataGridView1.Columns.Add(edit);

            DataGridViewButtonColumn del = new DataGridViewButtonColumn();
            del.HeaderText = "Delete";
            del.Text = "Delete";
            del.UseColumnTextForButtonValue = true;
            del.Name = "Delete";

            dataGridView1.Columns.Add(del);
        }
        private void LoadData()
        {
            if (comboBox1.SelectedItem == null)
                return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT ProductName, Price, StockQty 
                                 FROM Product 
                                 WHERE Category = @cat";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@cat", comboBox1.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = dataGridView1.Columns[e.ColumnIndex].Name;
            string name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (col == "Edit")
            {
                MessageBox.Show("Edit function (next step upgrade)");
            }
            else if (col == "Delete")
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Product WHERE ProductName = @name", con);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully");
                LoadData();
            }
        }

        private void radioButtonDashboard_CheckedChanged(object sender, EventArgs e)
        {
            //dashboard_admin f = new dashboard_admin();
            //f.Show();
            //this.Hide();
        }
        private void radioButtonManageDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonManageDrink.Checked) return;

            new ManageDrink().Show();
            this.Hide();
        }
        private void radioButtonManageFood_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonManageFood.Checked) return;
        }

        private void radioButtonRestock_CheckedChanged(object sender, EventArgs e)
        {
            //Restock f = new Restock();
            //f.Show();
            //this.Hide();
        }

        private void radioButtonSalesReport_CheckedChanged(object sender, EventArgs e)
        {
            //salesReport f = new salesReport();
            //f.Show();
            //this.Hide();
        }

        private void radioButtonSetting_CheckedChanged(object sender, EventArgs e)
        {
            //settings_admin f = new settings_admin();
            //f.Show();
            //this.Hide();
        }

        private void radioButtonLogout_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
