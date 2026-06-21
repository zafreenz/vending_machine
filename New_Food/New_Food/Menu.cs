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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MiMilbl_Click(object sender, EventArgs e)
        {

        }

        private void PopoMurukulbl_Click(object sender, EventArgs e)
        {

        }

        private void snacksMenu1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void snacksMenu1_Load_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = true;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = true;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = true;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = true;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = true;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = true;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void allFoodsMenu1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = true;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = true;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = true;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = true;
            yogurtMenu1.Visible = false;
            allDrinksMenu1.Visible = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            snacksMenu1.Visible = false;
            breadMenu1.Visible = false;
            candiesMenu1.Visible = false;
            nutsMenu1.Visible = false;
            biscuitMenu1.Visible = false;
            allFoodsMenu1.Visible = false;

            carbonatedMenu1.Visible = false;
            juiceMenu1.Visible = false;
            milkMenu1.Visible = false;
            mineralWaterMenu1.Visible = false;
            yogurtMenu1.Visible = true;
            allDrinksMenu1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCart cartForm = Application.OpenForms.OfType<MyCart>().FirstOrDefault();

            if (cartForm != null)
            {
                cartForm.Show();
                cartForm.BringToFront();
            }
            else
            {
                MyCart cart = new MyCart();
                cart.Show();
            }

            this.Hide(); // tutup/sorok Menu form
        }
    }
}
