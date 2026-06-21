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
    public partial class CandiesMenu : UserControl
    {
        public CandiesMenu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Candies4GB_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(501);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(502);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(503);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(504);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(505);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(506);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(507);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(508);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(509);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
