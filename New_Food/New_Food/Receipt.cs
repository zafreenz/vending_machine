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
    public partial class Receipt : Form
    {
        private int secondsLeft = 15;
        public Receipt()
        {
            InitializeComponent();
        }

        private void lblTQ_Click(object sender, EventArgs e)
        {

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            if (secondsLeft > 0)
            {
                lblCountdown.Text = $"Returning to home in {secondsLeft} seconds...";
            }
            else
            {
                countdownTimer.Stop();

                First home = new First();
                home.Show();

                this.Close();
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            countdownTimer.Interval = 1000;
            countdownTimer.Start();

            lblCountdown.Text = $"Returning to home in {secondsLeft} seconds...";

            dgvItem.Rows.Clear();

            foreach (var item in CartManager.Items)
            {
                dgvItem.Rows.Add(item.ItemName + " (x" + item.Quantity + ")", "Dispensed ✓");
            }

            // lepas dispense, clear cart sebab transaksi dah selesai
            CartManager.Clear();
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {

        }
    }
}
