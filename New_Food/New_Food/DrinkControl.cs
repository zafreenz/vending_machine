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
    public partial class DrinkControl : UserControl
    {
        public DrinkControl()
        {
            InitializeComponent();
        }

        private void DrinkControl_Load(object sender, EventArgs e)
        {
            cmbDrink.Items.Clear();

            cmbDrink.Items.Add("Coca Cola");
            cmbDrink.Items.Add("Pepsi");
            cmbDrink.Items.Add("Sprite");
            cmbDrink.Items.Add("100 Plus");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
