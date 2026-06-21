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
    public partial class YogurtMenu : UserControl
    {
        public YogurtMenu()
        {
            InitializeComponent();
        }

        private void YogurtMenu_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(201);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(202);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(203);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(204);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(205);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(206);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(207);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(208);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
