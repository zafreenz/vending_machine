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
    public partial class MilkMenu : UserControl
    {
        public MilkMenu()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(801);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(802);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(803);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(804);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(805);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(806);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(807);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(808);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(809);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
