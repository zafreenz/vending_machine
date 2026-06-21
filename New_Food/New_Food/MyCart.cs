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
            //Payment payment = new Payment();
            //payment.Show();
            //this.Hide();

            // Optional: check kalau cart kosong, jangan benarkan proceed
            //if (dgvItem.Rows.Count == 0)
            //{
            //    MessageBox.Show("Your cart is empty. Please add items first.");
            //   return;
            //}

            Payment paymentForm = Application.OpenForms.OfType<Payment>().FirstOrDefault();

            if (paymentForm != null)
            {
                paymentForm.Show();
                paymentForm.BringToFront();
            }
            else
            {
                Payment payment = new Payment();
                payment.Show();
            }

            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            // ambil row yang diklik
            DataGridViewRow selectedRow = dgvItem.SelectedRows[0];

            // ambil "No." dari row tu (column index 0), tukar jadi index dalam List (No. - 1)
            int rowIndex = Convert.ToInt32(selectedRow.Cells[0].Value) - 1;

            if (rowIndex >= 0 && rowIndex < CartManager.Items.Count)
            {
                CartManager.Items.RemoveAt(rowIndex);
                RefreshCart();
            }
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
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();

            if (menuForm != null)
            {
                menuForm.Show();
                menuForm.BringToFront();
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
            }

            this.Hide();
        }

        private void MyCart_Load(object sender, EventArgs e)
        {
            RefreshCart();
        }

        private void RefreshCart()
        {
            dgvItem.Rows.Clear();

            int no = 1;
            foreach (var item in CartManager.Items)
            {
                dgvItem.Rows.Add(
                    no++,
                    item.ItemName,
                    item.Quantity,
                    "RM " + item.UnitPrice.ToString("0.00"),
                    "RM " + item.Subtotal.ToString("0.00")
                );
            }

            decimal total = CartManager.GetTotal();
            lblSubtotalValue.Text = "RM " + total.ToString("0.00");   // ✅ tukar dari lblSubtotal
            lblTotalValue.Text = "RM " + total.ToString("0.00");
        }

        private void MyCart_Activated(object sender, EventArgs e)
        {
            RefreshCart();
        }
    }
}
