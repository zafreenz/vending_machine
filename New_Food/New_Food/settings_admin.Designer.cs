namespace New_Food
{
    partial class settings_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings_admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashlbl = new System.Windows.Forms.Label();
            this.logoutlbl = new System.Windows.Forms.Label();
            this.settinglbl = new System.Windows.Forms.Label();
            this.salesreportlbl = new System.Windows.Forms.Label();
            this.restocklbl = new System.Windows.Forms.Label();
            this.mngfoodLbl = new System.Windows.Forms.Label();
            this.mngdrnkLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savechangesbtn = new System.Windows.Forms.Button();
            this.confirmpasstxt = new System.Windows.Forms.TextBox();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.currpasstxt = new System.Windows.Forms.TextBox();
            this.fullnametxt = new System.Windows.Forms.TextBox();
            this.confirmpasslbl = new System.Windows.Forms.Label();
            this.newpasslbl = new System.Windows.Forms.Label();
            this.currpasslbl = new System.Windows.Forms.Label();
            this.fullnamelbl = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.dashlbl);
            this.panel1.Controls.Add(this.logoutlbl);
            this.panel1.Controls.Add(this.settinglbl);
            this.panel1.Controls.Add(this.salesreportlbl);
            this.panel1.Controls.Add(this.restocklbl);
            this.panel1.Controls.Add(this.mngfoodLbl);
            this.panel1.Controls.Add(this.mngdrnkLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 477);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dashlbl
            // 
            this.dashlbl.AutoSize = true;
            this.dashlbl.BackColor = System.Drawing.Color.Pink;
            this.dashlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashlbl.Location = new System.Drawing.Point(41, 139);
            this.dashlbl.Name = "dashlbl";
            this.dashlbl.Size = new System.Drawing.Size(75, 16);
            this.dashlbl.TabIndex = 7;
            this.dashlbl.Text = "Dashboard";
            this.dashlbl.Click += new System.EventHandler(this.dashlbl_Click);
            // 
            // logoutlbl
            // 
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutlbl.Location = new System.Drawing.Point(41, 328);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(48, 16);
            this.logoutlbl.TabIndex = 6;
            this.logoutlbl.Text = "Logout";
            // 
            // settinglbl
            // 
            this.settinglbl.AutoSize = true;
            this.settinglbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settinglbl.Location = new System.Drawing.Point(41, 301);
            this.settinglbl.Name = "settinglbl";
            this.settinglbl.Size = new System.Drawing.Size(55, 16);
            this.settinglbl.TabIndex = 5;
            this.settinglbl.Text = "Settings\n";
            this.settinglbl.Click += new System.EventHandler(this.settinglbl_Click);
            // 
            // salesreportlbl
            // 
            this.salesreportlbl.AutoSize = true;
            this.salesreportlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesreportlbl.Location = new System.Drawing.Point(41, 265);
            this.salesreportlbl.Name = "salesreportlbl";
            this.salesreportlbl.Size = new System.Drawing.Size(86, 16);
            this.salesreportlbl.TabIndex = 4;
            this.salesreportlbl.Text = "Sales Report";
            this.salesreportlbl.Click += new System.EventHandler(this.salesreportlbl_Click);
            // 
            // restocklbl
            // 
            this.restocklbl.AutoSize = true;
            this.restocklbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restocklbl.Location = new System.Drawing.Point(41, 234);
            this.restocklbl.Name = "restocklbl";
            this.restocklbl.Size = new System.Drawing.Size(85, 16);
            this.restocklbl.TabIndex = 3;
            this.restocklbl.Text = "Restock Item";
            this.restocklbl.Click += new System.EventHandler(this.restocklbl_Click);
            // 
            // mngfoodLbl
            // 
            this.mngfoodLbl.AutoSize = true;
            this.mngfoodLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mngfoodLbl.Location = new System.Drawing.Point(41, 204);
            this.mngfoodLbl.Name = "mngfoodLbl";
            this.mngfoodLbl.Size = new System.Drawing.Size(92, 16);
            this.mngfoodLbl.TabIndex = 2;
            this.mngfoodLbl.Text = "Manage Food";
            this.mngfoodLbl.Click += new System.EventHandler(this.mngfoodLbl_Click);
            // 
            // mngdrnkLbl
            // 
            this.mngdrnkLbl.AutoSize = true;
            this.mngdrnkLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mngdrnkLbl.Location = new System.Drawing.Point(41, 173);
            this.mngdrnkLbl.Name = "mngdrnkLbl";
            this.mngdrnkLbl.Size = new System.Drawing.Size(91, 16);
            this.mngdrnkLbl.TabIndex = 1;
            this.mngdrnkLbl.Text = "Manage Drink";
            this.mngdrnkLbl.Click += new System.EventHandler(this.mngdrnkLbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.savechangesbtn);
            this.panel2.Controls.Add(this.confirmpasstxt);
            this.panel2.Controls.Add(this.newpasstxt);
            this.panel2.Controls.Add(this.currpasstxt);
            this.panel2.Controls.Add(this.fullnametxt);
            this.panel2.Controls.Add(this.confirmpasslbl);
            this.panel2.Controls.Add(this.newpasslbl);
            this.panel2.Controls.Add(this.currpasslbl);
            this.panel2.Controls.Add(this.fullnamelbl);
            this.panel2.Location = new System.Drawing.Point(521, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 316);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // savechangesbtn
            // 
            this.savechangesbtn.Location = new System.Drawing.Point(294, 197);
            this.savechangesbtn.Name = "savechangesbtn";
            this.savechangesbtn.Size = new System.Drawing.Size(131, 31);
            this.savechangesbtn.TabIndex = 8;
            this.savechangesbtn.Text = "Save Changes";
            this.savechangesbtn.UseVisualStyleBackColor = true;
            this.savechangesbtn.Click += new System.EventHandler(this.savechangesbtn_Click);
            // 
            // confirmpasstxt
            // 
            this.confirmpasstxt.Location = new System.Drawing.Point(191, 150);
            this.confirmpasstxt.Name = "confirmpasstxt";
            this.confirmpasstxt.Size = new System.Drawing.Size(234, 22);
            this.confirmpasstxt.TabIndex = 7;
            this.confirmpasstxt.TextChanged += new System.EventHandler(this.confirmpasstxt_TextChanged);
            // 
            // newpasstxt
            // 
            this.newpasstxt.Location = new System.Drawing.Point(191, 110);
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.Size = new System.Drawing.Size(234, 22);
            this.newpasstxt.TabIndex = 6;
            this.newpasstxt.TextChanged += new System.EventHandler(this.newpasstxt_TextChanged);
            // 
            // currpasstxt
            // 
            this.currpasstxt.Location = new System.Drawing.Point(191, 67);
            this.currpasstxt.Name = "currpasstxt";
            this.currpasstxt.Size = new System.Drawing.Size(234, 22);
            this.currpasstxt.TabIndex = 5;
            this.currpasstxt.TextChanged += new System.EventHandler(this.currpasstxt_TextChanged);
            // 
            // fullnametxt
            // 
            this.fullnametxt.Location = new System.Drawing.Point(191, 40);
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(234, 22);
            this.fullnametxt.TabIndex = 4;
            this.fullnametxt.TextChanged += new System.EventHandler(this.fullnametxt_TextChanged);
            // 
            // confirmpasslbl
            // 
            this.confirmpasslbl.AutoSize = true;
            this.confirmpasslbl.Location = new System.Drawing.Point(25, 156);
            this.confirmpasslbl.Name = "confirmpasslbl";
            this.confirmpasslbl.Size = new System.Drawing.Size(115, 16);
            this.confirmpasslbl.TabIndex = 3;
            this.confirmpasslbl.Text = "Confirm Password";
            this.confirmpasslbl.Click += new System.EventHandler(this.confirmpasslbl_Click);
            // 
            // newpasslbl
            // 
            this.newpasslbl.AutoSize = true;
            this.newpasslbl.Location = new System.Drawing.Point(25, 116);
            this.newpasslbl.Name = "newpasslbl";
            this.newpasslbl.Size = new System.Drawing.Size(97, 16);
            this.newpasslbl.TabIndex = 2;
            this.newpasslbl.Text = "New Password";
            // 
            // currpasslbl
            // 
            this.currpasslbl.AutoSize = true;
            this.currpasslbl.Location = new System.Drawing.Point(25, 73);
            this.currpasslbl.Name = "currpasslbl";
            this.currpasslbl.Size = new System.Drawing.Size(112, 16);
            this.currpasslbl.TabIndex = 1;
            this.currpasslbl.Text = "Current Password";
            this.currpasslbl.Click += new System.EventHandler(this.currpasslbl_Click);
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.AutoSize = true;
            this.fullnamelbl.Location = new System.Drawing.Point(25, 43);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(70, 16);
            this.fullnamelbl.TabIndex = 0;
            this.fullnamelbl.Text = "Username";
            this.fullnamelbl.Click += new System.EventHandler(this.fullnamelbl_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "WhatsApp Image 2026-06-19 at 3.33.31 PM.jpeg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::New_Food.Properties.Resources.cc48e52ccba0565ab5924af96a8ea9f1;
            this.pictureBox1.Location = new System.Drawing.Point(218, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "SETTING";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // settings_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "settings_admin";
            this.Text = "settings_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashlbl;
        private System.Windows.Forms.Label logoutlbl;
        private System.Windows.Forms.Label settinglbl;
        private System.Windows.Forms.Label salesreportlbl;
        private System.Windows.Forms.Label restocklbl;
        private System.Windows.Forms.Label mngfoodLbl;
        private System.Windows.Forms.Label mngdrnkLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currpasslbl;
        private System.Windows.Forms.Label fullnamelbl;
        private System.Windows.Forms.Label confirmpasslbl;
        private System.Windows.Forms.Label newpasslbl;
        private System.Windows.Forms.TextBox confirmpasstxt;
        private System.Windows.Forms.TextBox newpasstxt;
        private System.Windows.Forms.TextBox currpasstxt;
        private System.Windows.Forms.TextBox fullnametxt;
        private System.Windows.Forms.Button savechangesbtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}