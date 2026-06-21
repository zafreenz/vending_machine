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
    public partial class SnacksMenu : UserControl
    {
        public SnacksMenu()
        {
            InitializeComponent();
           
        }

        private void SnacksMenuLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Snacks4GB_Enter(object sender, EventArgs e)
        {

        }

        private void Snacks1GB_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(111);
            pd.Show();
            this.FindForm().Hide();
        }

        private void Snacks8GB_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(101);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(102);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(103);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(104);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(105);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(106);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(107);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(108);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(112);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(109);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(110);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
