using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace New_Food
{
    public partial class settings_admin : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                           AttachDbFilename=C:\Users\ASUS\source\repos\vending_machine\New_Food\New_Food\VendingMachine.mdf;
                           Integrated Security=True";

        public settings_admin()
        {
            InitializeComponent();

            currpasstxt.UseSystemPasswordChar = true;
            newpasstxt.UseSystemPasswordChar = true;
            confirmpasstxt.UseSystemPasswordChar = true;

            this.Load += settings_admin_Load;
        }

        private void settings_admin_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = "SELECT username, password FROM Admin WHERE admin_id = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        fullnametxt.Text = dr["username"].ToString();

                        
                        
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void savechangesbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullnametxt.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newpasstxt.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (newpasstxt.Text != confirmpasstxt.Text)
            {
                MessageBox.Show("Password does not match!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query =
                        "UPDATE Admin SET username=@username, password=@password WHERE admin_id=1";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", fullnametxt.Text);
                    cmd.Parameters.AddWithValue("@password", newpasstxt.Text);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        currpasstxt.Text = newpasstxt.Text;

                        newpasstxt.Clear();
                        confirmpasstxt.Clear();

                        MessageBox.Show(
                            "Profile updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No record was updated.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dashboard_admin frm = new dashboard_admin();
            frm.Show();
            this.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Restock r = new Restock();
            r.Show();
            this.Hide();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            salesReport rs = new salesReport();
            rs.Show();
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

        private void settings_admin_Load_1(object sender, EventArgs e)
        {
            radioButton13.Checked = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Event kosong boleh biar atau delete jika tak guna
        private void dashlbl_Click(object sender, EventArgs e) { }
        private void mngdrnkLbl_Click(object sender, EventArgs e) { }
        private void mngfoodLbl_Click(object sender, EventArgs e) { }
        private void restocklbl_Click(object sender, EventArgs e) { }
        private void salesreportlbl_Click(object sender, EventArgs e) { }
        private void settinglbl_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void fullnamelbl_Click(object sender, EventArgs e) { }
        private void currpasslbl_Click(object sender, EventArgs e) { }
        private void confirmpasslbl_Click(object sender, EventArgs e) { }
        private void newpasslbl_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void fullnametxt_TextChanged(object sender, EventArgs e) { }
        private void currpasstxt_TextChanged(object sender, EventArgs e) { }
        private void newpasstxt_TextChanged(object sender, EventArgs e) { }
        private void confirmpasstxt_TextChanged(object sender, EventArgs e) { }
    }
}