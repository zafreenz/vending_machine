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
    public partial class settings_admin : Form
    {   

        public settings_admin()
        {
            InitializeComponent();
            this.Load += settings_admin_Load;
        }

        private void settings_admin_Load(object sender, EventArgs e)
        {
     
        }

        private void dashlbl_Click(object sender, EventArgs e)
        {
            dashboard_admin frm = new dashboard_admin();
            frm.Show();
            this.Hide();
        }

        private void mngdrnkLbl_Click(object sender, EventArgs e)
        {

        }

        private void mngfoodLbl_Click(object sender, EventArgs e)
        {

        }

        private void restocklbl_Click(object sender, EventArgs e)
        {

        }

        private void salesreportlbl_Click(object sender, EventArgs e)
        {

        }

        private void settinglbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fullnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void fullnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void currpasslbl_Click(object sender, EventArgs e)
        {

        }

        private void currpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpasslbl_Click(object sender, EventArgs e)
        {

        }

        private void confirmpasstxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void savechangesbtn_Click(object sender, EventArgs e)
        {
            if (newpasstxt.Text != confirmpasstxt.Text)
            {
                MessageBox.Show("Password does not match!");
                return;
            }

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VendingMachine.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "UPDATE Admin SET username=@username, password=@password WHERE admin_id=1";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", fullnametxt.Text);
                cmd.Parameters.AddWithValue("@password", newpasstxt.Text);

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Rows affected: " + rows);

                string checkQuery = "SELECT username, password FROM Admin WHERE admin_id = 1";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

                SqlDataReader dr = checkCmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show(
                        "After Update:\nUsername = " +
                        dr["username"].ToString() +
                        "\nPassword = " +
                        dr["password"].ToString()
                    );
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
