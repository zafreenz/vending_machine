using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "sarah" && password == "123")
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
