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
    public partial class MineralWaterMenu : UserControl
    {
        public MineralWaterMenu()
        {
            InitializeComponent();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(901);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(902);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(903);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(904);
            pd.Show();
            this.FindForm().Hide();
        }
    }
}
