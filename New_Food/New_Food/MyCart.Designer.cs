namespace New_Food
{
    partial class MyCart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colItem,
            this.colQty,
            this.colPrice,
            this.colSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(112, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(395, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(205, 43);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Selected Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(109, 317);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(84, 20);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(113, 422);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(185, 43);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed to Payment";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(406, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add More";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(697, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(109, 349);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Payment:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValue.Location = new System.Drawing.Point(278, 317);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(71, 20);
            this.lblSubtotalValue.TabIndex = 9;
            this.lblSubtotalValue.Text = "RM 0.00";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(279, 349);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(71, 20);
            this.lblTotalValue.TabIndex = 10;
            this.lblTotalValue.Text = "RM 0.00";
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No.";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Unit Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            // 
            // MyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyCart";
            this.Text = "My Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}