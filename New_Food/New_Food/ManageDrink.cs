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
    public partial class ManageDrink : Form
    {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\VendingMachine.mdf;
        Integrated Security=True";

        public ManageDrink()
        {
            InitializeComponent();
        }

        private void ManageDrink_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Carbonated");
            comboBox1.Items.Add("Juices");
            comboBox1.Items.Add("Snack");
            comboBox1.Items.Add("Milk");

            AddGridButtons();
        }
        private void AddGridButtons()
        {
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.HeaderText = "Edit";
                edit.Text = "Edit";
                edit.UseColumnTextForButtonValue = true;
                edit.Name = "Edit";

                dataGridView1.Columns.Add(edit);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn del = new DataGridViewButtonColumn();
                del.HeaderText = "Delete";
                del.Text = "Delete";
                del.UseColumnTextForButtonValue = true;
                del.Name = "Delete";

                dataGridView1.Columns.Add(del);
            }
        }
        private void LoadData()
        {
            if (comboBox1.Text == "")
                return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT ProductName, Price, StockQty FROM Product WHERE Category = @cat";

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
                MessageBox.Show("Edit function (next step kita upgrade)");
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

                MessageBox.Show("Deleted from database");

                LoadData();
            }
        }
    }
}
