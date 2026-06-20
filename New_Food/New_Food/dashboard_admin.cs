using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace New_Food
{
    public partial class dashboard_admin : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\Users\ASUS\source\repos\vending_machine\New_Food\New_Food\VendingMachine.mdf;
Integrated Security=True";

        public dashboard_admin()
        {
            InitializeComponent();
        }
        private void LoadDashboard()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // TOTAL DRINK
                string drinkQuery =
                    "SELECT COUNT(*) FROM Product WHERE Category IN ('Carbonated','Juices','Milk','Mineral Water','Yogurt')";

                SqlCommand drinkCmd = new SqlCommand(drinkQuery, conn);

                lblDrink.Text = drinkCmd.ExecuteScalar().ToString();


                // TOTAL FOOD
                string foodQuery =
                    "SELECT COUNT(*) FROM Product WHERE Category IN ('Snack','Bread','Nuts','Biscuit','Candies')";

                SqlCommand foodCmd = new SqlCommand(foodQuery, conn);

                lblFood.Text = foodCmd.ExecuteScalar().ToString();


                // LOW STOCK
                string lowStockQuery =
                    "SELECT COUNT(*) FROM Product WHERE StockQty <= 5";

                SqlCommand lowCmd = new SqlCommand(lowStockQuery, conn);

                lblLowStock.Text = lowCmd.ExecuteScalar().ToString();
            }
        }
        private void dashboard_admin_Load(object sender, EventArgs e)
        {
            radioButton8.Checked = true;

            LoadDashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void welcomeadminLbl_Click(object sender, EventArgs e)
        {

        }

        private void settinglbl_Click(object sender, EventArgs e)
        {
            settings_admin frm = new settings_admin();
            frm.Show();
            this.Hide();
        }

        private void dashlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            settings_admin frm = new settings_admin();
            frm.Show();
            this.Hide();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            salesReport fr = new salesReport();
            fr.Show();
            this.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
           Restock r = new Restock();
            r.Show();
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

        

        private void lblDrink_Click(object sender, EventArgs e)
        {

        }
    }
}
