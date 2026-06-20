using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Food
{
    public partial class salesReport : Form
    {
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\VendingMachine.mdf;
              Integrated Security=True";
        public salesReport()
        {
            InitializeComponent();
        }

        private void salesReport_Load(object sender, EventArgs e)
        {
            radioButton12.Checked = true;
            comboBox1.Items.Add("Today");
            comboBox1.Items.Add("Weekly");
            comboBox1.Items.Add("Monthly");
            comboBox1.Items.Add("All");

            comboBox1.SelectedIndex = 0; // Default Today
        }

        private void LoadTop3Products()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = 
                    @"SELECT TOP 3 p.productName,
                    SUM(t.quantity) AS TotalSold
                    FROM dbo.[Transaction] t
                    INNER JOIN Product p
                    ON t.product_id = p.product_id
                    GROUP BY p.productName
                    ORDER BY TotalSold DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                int rank = 1;

                while (dr.Read())
                {
                    string product = dr["productName"].ToString() +
                        " (" + dr["TotalSold"].ToString() + ")";

                    if (rank == 1)
                        textBox9.Text = product;

                    else if (rank == 2)
                        textBox10.Text = product;

                    else if (rank == 3)
                        textBox11.Text = product;
                    
                    rank++;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            switch (comboBox1.Text)
            {
                case "Today":
                    dateTimePicker1.Value = today;
                    dateTimePicker2.Value = today;
                    break;

                case "Weekly":
                    dateTimePicker1.Value = today.AddDays(-(int)today.DayOfWeek);
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(6);
                    break;

                case "Monthly":
                    dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
                    dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
                    break;

                case "All":
                    dateTimePicker1.Value = new DateTime(2000, 1, 1);
                    dateTimePicker2.Value = today;
                    break;
            }
        }

        private int GetTodayTransaction()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = 
                    @"SELECT COUNT(*)
                    FROM dbo.[Transaction] t
                    INNER JOIN Payment p
                    ON t.payment_id = p.payment_id
                    WHERE CAST(p.[date] AS DATE) = CAST(GETDATE() AS DATE)";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetWeeklyTransaction()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = 
                    @"SELECT COUNT(*)
                    FROM dbo.[Transaction] t
                    INNER JOIN Payment p
                    ON t.payment_id = p.payment_id
                    WHERE p.[date] >= DATEADD(DAY,-7,GETDATE())";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetMonthlyTransaction()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = 
                    @"SELECT COUNT(*)
                    FROM dbo.[Transaction] t
                    INNER JOIN Payment p
                    ON t.payment_id = p.payment_id
                    WHERE MONTH(p.[date]) = MONTH(GETDATE())
                    AND YEAR(p.[date]) = YEAR(GETDATE())";
                
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            string filter = comboBox1.Text;

            if (filter == "Today")
            {
                textBox5.Text = GetTodayTransaction().ToString();
            }
            else if (filter == "Weekly")
            {
                textBox6.Text = GetWeeklyTransaction().ToString();
            }
            else if (filter == "Monthly")
            {
                textBox7.Text = GetMonthlyTransaction().ToString();
            }
            else if (filter == "All")
            {
                textBox5.Text = GetTodayTransaction().ToString();
                textBox6.Text = GetWeeklyTransaction().ToString();
                textBox7.Text = GetMonthlyTransaction().ToString();
            }
            LoadTop3Products();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dashboard_admin da = new dashboard_admin();
            da.Show();
            this.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Restock r = new Restock();
            r.Show();
            this.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            settings_admin sa = new settings_admin();
            sa.Show();
            this.Hide();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginAdmin1 login = new LoginAdmin1();
                login.Show();
            }
        }
    }
}