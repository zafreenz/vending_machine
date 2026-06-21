namespace New_Food
{
    partial class ManageFood
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.welcomeadminLbl = new System.Windows.Forms.Label();
            this.radioButtonRestock = new System.Windows.Forms.RadioButton();
            this.radioButtonManageDrink = new System.Windows.Forms.RadioButton();
            this.radioButtonManageFood = new System.Windows.Forms.RadioButton();
            this.radioButtonSalesReport = new System.Windows.Forms.RadioButton();
            this.radioButtonSetting = new System.Windows.Forms.RadioButton();
            this.radioButtonLogout = new System.Windows.Forms.RadioButton();
            this.radioButtonDashboard = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(248, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 424);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 240);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Food";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // welcomeadminLbl
            // 
            this.welcomeadminLbl.AutoSize = true;
            this.welcomeadminLbl.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeadminLbl.Location = new System.Drawing.Point(242, 12);
            this.welcomeadminLbl.Name = "welcomeadminLbl";
            this.welcomeadminLbl.Size = new System.Drawing.Size(213, 35);
            this.welcomeadminLbl.TabIndex = 13;
            this.welcomeadminLbl.Text = "Manage Food";
            // 
            // radioButtonRestock
            // 
            this.radioButtonRestock.AutoSize = true;
            this.radioButtonRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRestock.Location = new System.Drawing.Point(26, 219);
            this.radioButtonRestock.Name = "radioButtonRestock";
            this.radioButtonRestock.Size = new System.Drawing.Size(129, 22);
            this.radioButtonRestock.TabIndex = 11;
            this.radioButtonRestock.TabStop = true;
            this.radioButtonRestock.Text = "Restock Item";
            this.radioButtonRestock.UseVisualStyleBackColor = true;
            this.radioButtonRestock.CheckedChanged += new System.EventHandler(this.radioButtonRestock_CheckedChanged);
            // 
            // radioButtonManageDrink
            // 
            this.radioButtonManageDrink.AutoSize = true;
            this.radioButtonManageDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManageDrink.Location = new System.Drawing.Point(26, 121);
            this.radioButtonManageDrink.Name = "radioButtonManageDrink";
            this.radioButtonManageDrink.Size = new System.Drawing.Size(133, 22);
            this.radioButtonManageDrink.TabIndex = 13;
            this.radioButtonManageDrink.TabStop = true;
            this.radioButtonManageDrink.Text = "Manage Drink";
            this.radioButtonManageDrink.UseVisualStyleBackColor = true;
            this.radioButtonManageDrink.CheckedChanged += new System.EventHandler(this.radioButtonManageDrink_CheckedChanged);
            // 
            // radioButtonManageFood
            // 
            this.radioButtonManageFood.AutoSize = true;
            this.radioButtonManageFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManageFood.Location = new System.Drawing.Point(26, 172);
            this.radioButtonManageFood.Name = "radioButtonManageFood";
            this.radioButtonManageFood.Size = new System.Drawing.Size(132, 22);
            this.radioButtonManageFood.TabIndex = 12;
            this.radioButtonManageFood.TabStop = true;
            this.radioButtonManageFood.Text = "Manage Food";
            this.radioButtonManageFood.UseVisualStyleBackColor = true;
            this.radioButtonManageFood.CheckedChanged += new System.EventHandler(this.radioButtonManageFood_CheckedChanged);
            // 
            // radioButtonSalesReport
            // 
            this.radioButtonSalesReport.AutoSize = true;
            this.radioButtonSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSalesReport.Location = new System.Drawing.Point(26, 263);
            this.radioButtonSalesReport.Name = "radioButtonSalesReport";
            this.radioButtonSalesReport.Size = new System.Drawing.Size(127, 22);
            this.radioButtonSalesReport.TabIndex = 10;
            this.radioButtonSalesReport.TabStop = true;
            this.radioButtonSalesReport.Text = "Sales Report";
            this.radioButtonSalesReport.UseVisualStyleBackColor = true;
            this.radioButtonSalesReport.CheckedChanged += new System.EventHandler(this.radioButtonSalesReport_CheckedChanged);
            // 
            // radioButtonSetting
            // 
            this.radioButtonSetting.AutoSize = true;
            this.radioButtonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSetting.Location = new System.Drawing.Point(26, 310);
            this.radioButtonSetting.Name = "radioButtonSetting";
            this.radioButtonSetting.Size = new System.Drawing.Size(81, 22);
            this.radioButtonSetting.TabIndex = 9;
            this.radioButtonSetting.TabStop = true;
            this.radioButtonSetting.Text = "Setting";
            this.radioButtonSetting.UseVisualStyleBackColor = true;
            this.radioButtonSetting.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // radioButtonLogout
            // 
            this.radioButtonLogout.AutoSize = true;
            this.radioButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLogout.Location = new System.Drawing.Point(26, 353);
            this.radioButtonLogout.Name = "radioButtonLogout";
            this.radioButtonLogout.Size = new System.Drawing.Size(81, 22);
            this.radioButtonLogout.TabIndex = 8;
            this.radioButtonLogout.TabStop = true;
            this.radioButtonLogout.Text = "Logout";
            this.radioButtonLogout.UseVisualStyleBackColor = true;
            this.radioButtonLogout.CheckedChanged += new System.EventHandler(this.radioButtonLogout_CheckedChanged);
            // 
            // radioButtonDashboard
            // 
            this.radioButtonDashboard.AutoSize = true;
            this.radioButtonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDashboard.Location = new System.Drawing.Point(26, 75);
            this.radioButtonDashboard.Name = "radioButtonDashboard";
            this.radioButtonDashboard.Size = new System.Drawing.Size(111, 22);
            this.radioButtonDashboard.TabIndex = 14;
            this.radioButtonDashboard.TabStop = true;
            this.radioButtonDashboard.Text = "Dashboard";
            this.radioButtonDashboard.UseVisualStyleBackColor = true;
            this.radioButtonDashboard.CheckedChanged += new System.EventHandler(this.radioButtonDashboard_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioButtonRestock);
            this.panel3.Controls.Add(this.radioButtonManageDrink);
            this.panel3.Controls.Add(this.radioButtonManageFood);
            this.panel3.Controls.Add(this.radioButtonSalesReport);
            this.panel3.Controls.Add(this.radioButtonSetting);
            this.panel3.Controls.Add(this.radioButtonLogout);
            this.panel3.Controls.Add(this.radioButtonDashboard);
            this.panel3.Location = new System.Drawing.Point(11, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 445);
            this.panel3.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 477);
            this.panel1.TabIndex = 12;
            // 
            // ManageFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.welcomeadminLbl);
            this.Controls.Add(this.panel1);
            this.Name = "ManageFood";
            this.Text = "ManageFood";
            this.Load += new System.EventHandler(this.ManageFood_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label welcomeadminLbl;
        private System.Windows.Forms.RadioButton radioButtonRestock;
        private System.Windows.Forms.RadioButton radioButtonManageDrink;
        private System.Windows.Forms.RadioButton radioButtonManageFood;
        private System.Windows.Forms.RadioButton radioButtonSalesReport;
        private System.Windows.Forms.RadioButton radioButtonSetting;
        private System.Windows.Forms.RadioButton radioButtonLogout;
        private System.Windows.Forms.RadioButton radioButtonDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}