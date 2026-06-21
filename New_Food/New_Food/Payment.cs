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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblItemValue.Text = CartManager.GetTotalQuantity() + " items";
            lblTotalValue.Text = "RM " + CartManager.GetTotal().ToString("0.00");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!rbtnCash.Checked && !rbtnCard.Checked && !rbtnWallet.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string paymentMethod = rbtnCash.Checked ? "Cash" :
                                    rbtnCard.Checked ? "Debit / Credit Card" : "E-Wallet";

            // TODO: lepas ni boleh update stockQty dalam database, then clear cart

            Receipt receiptForm = Application.OpenForms.OfType<Receipt>().FirstOrDefault();

            if (receiptForm != null)
            {
                receiptForm.Show();
                receiptForm.BringToFront();
            }
            else
            {
                Receipt receipt = new Receipt();
                receipt.Show();
            }

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

            this.Hide();
        }

        private void Payment_Activated(object sender, EventArgs e)
        {
            lblItemValue.Text = CartManager.GetTotalQuantity() + " items";
            lblTotalValue.Text = "RM " + CartManager.GetTotal().ToString("0.00");
        }
    }
}
