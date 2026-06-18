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
    public partial class MyCart : Form
    {
        public MyCart()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all items from your cart?",
                "Clear Cart",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dgvItem.Rows.Clear();

                // If your grid is bound to a data source (like a DataTable or List), use this instead:
                // cartList.Clear(); 
                // dgvCart.DataSource = null;

                lblSubtotalValue.Text = "RM 0.00";
                lblTotalValue.Text = "RM 0.00";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
