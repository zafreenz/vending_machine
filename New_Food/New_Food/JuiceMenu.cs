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
    public partial class JuiceMenu : UserControl
    {
        public JuiceMenu()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(701);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(702);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(703);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(704);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(705);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(706);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(707);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
