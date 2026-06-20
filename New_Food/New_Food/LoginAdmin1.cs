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
    public partial class LoginAdmin1 : Form
    {
        public LoginAdmin1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\ASUS\source\repos\vending_machine\New_Food\New_Food\VendingMachine.mdf;
    Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Admin WHERE username=@user AND password=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Restock fr = new Restock();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!");
                }
            }
        }
    }
}
