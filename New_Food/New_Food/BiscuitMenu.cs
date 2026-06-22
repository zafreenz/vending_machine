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
    public partial class BiscuitMenu : UserControl
    {
        public BiscuitMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(301);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(304);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(305);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(306);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(307);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(308);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(309);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(302);
            pd.Show();
            this.FindForm().Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(303);
            pd.Show();
            this.FindForm().Hide();
        }

        private void BiscuitMenuLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
