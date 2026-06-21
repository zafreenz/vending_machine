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
    public partial class BreadMenu : UserControl
    {
        public BreadMenu()
        {
            InitializeComponent();
        }

        private void Jagunglbl_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(401);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(402);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(403);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(404);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(405);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(406);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(407);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
