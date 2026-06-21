namespace New_Food
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPaymentSuccessful = new System.Windows.Forms.Label();
            this.lblTQ = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaymentSuccessful
            // 
            this.lblPaymentSuccessful.AutoSize = true;
            this.lblPaymentSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentSuccessful.Location = new System.Drawing.Point(364, 59);
            this.lblPaymentSuccessful.Name = "lblPaymentSuccessful";
            this.lblPaymentSuccessful.Size = new System.Drawing.Size(301, 36);
            this.lblPaymentSuccessful.TabIndex = 0;
            this.lblPaymentSuccessful.Text = "Payment Successful";
            // 
            // lblTQ
            // 
            this.lblTQ.AutoSize = true;
            this.lblTQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTQ.Location = new System.Drawing.Point(445, 107);
            this.lblTQ.Name = "lblTQ";
            this.lblTQ.Size = new System.Drawing.Size(135, 29);
            this.lblTQ.TabIndex = 1;
            this.lblTQ.Text = "Thank You!";
            this.lblTQ.Click += new System.EventHandler(this.lblTQ_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colStatus});
            this.dgvItem.Location = new System.Drawing.Point(113, 192);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(789, 150);
            this.dgvItem.TabIndex = 2;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(365, 445);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(319, 25);
            this.lblCountdown.TabIndex = 3;
            this.lblCountdown.Text = "Returning to home in 0 second(s)....";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.lblTQ);
            this.Controls.Add(this.lblPaymentSuccessful);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentSuccessful;
        private System.Windows.Forms.Label lblTQ;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Timer countdownTimer;
    }
}