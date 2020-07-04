namespace ProjectLibrary
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.cbShowPass1 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.cbShowPass2 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.cmbname = new System.Windows.Forms.ComboBox();
            this.btdel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNewpass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(356, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 37);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRePass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.ForeColor = System.Drawing.Color.Black;
            this.txtRePass.Location = new System.Drawing.Point(405, 238);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(244, 30);
            this.txtRePass.TabIndex = 5;
            this.txtRePass.UseSystemPasswordChar = true;
            this.txtRePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtRePass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRePass_KeyUp);
            // 
            // cbShowPass1
            // 
            this.cbShowPass1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShowPass1.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("cbShowPass1.ImageCheckedOff")));
            this.cbShowPass1.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass1.ImageCheckedOn")));
            this.cbShowPass1.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass1.Location = new System.Drawing.Point(653, 170);
            this.cbShowPass1.Name = "cbShowPass1";
            this.cbShowPass1.Size = new System.Drawing.Size(27, 21);
            this.cbShowPass1.TabIndex = 26;
            this.cbShowPass1.CheckedChanged += new System.EventHandler(this.cbShowPass1_CheckedChanged);
            // 
            // cbShowPass2
            // 
            this.cbShowPass2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShowPass2.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("cbShowPass2.ImageCheckedOff")));
            this.cbShowPass2.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass2.ImageCheckedOn")));
            this.cbShowPass2.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass2.Location = new System.Drawing.Point(653, 243);
            this.cbShowPass2.Name = "cbShowPass2";
            this.cbShowPass2.Size = new System.Drawing.Size(27, 21);
            this.cbShowPass2.TabIndex = 26;
            this.cbShowPass2.CheckedChanged += new System.EventHandler(this.cbShowPass2_CheckedChanged);
            // 
            // cmbname
            // 
            this.cmbname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbname.ForeColor = System.Drawing.Color.Black;
            this.cmbname.FormattingEnabled = true;
            this.cmbname.Location = new System.Drawing.Point(55, 165);
            this.cmbname.Name = "cmbname";
            this.cmbname.Size = new System.Drawing.Size(244, 29);
            this.cmbname.TabIndex = 1;
            this.cmbname.SelectedIndexChanged += new System.EventHandler(this.cmbname_SelectedIndexChanged);
            this.cmbname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // btdel
            // 
            this.btdel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btdel.Animated = true;
            this.btdel.AnimationHoverSpeed = 3F;
            this.btdel.AnimationSpeed = 2F;
            this.btdel.BackColor = System.Drawing.Color.Transparent;
            this.btdel.BaseColor = System.Drawing.Color.Transparent;
            this.btdel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.BorderSize = 1;
            this.btdel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btdel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btdel.CheckedForeColor = System.Drawing.Color.White;
            this.btdel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btdel.CheckedImage")));
            this.btdel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btdel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btdel.FocusedColor = System.Drawing.Color.Empty;
            this.btdel.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.Color.Black;
            this.btdel.Image = null;
            this.btdel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.ImageSize = new System.Drawing.Size(30, 30);
            this.btdel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btdel.Location = new System.Drawing.Point(375, 327);
            this.btdel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btdel.Name = "btdel";
            this.btdel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btdel.OnHoverForeColor = System.Drawing.Color.White;
            this.btdel.OnHoverImage = null;
            this.btdel.OnHoverLineColor = System.Drawing.Color.White;
            this.btdel.OnPressedColor = System.Drawing.Color.White;
            this.btdel.Radius = 2;
            this.btdel.Size = new System.Drawing.Size(77, 36);
            this.btdel.TabIndex = 21;
            this.btdel.Text = "ຍົກເລີກ";
            this.btdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btsave
            // 
            this.btsave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btsave.Animated = true;
            this.btsave.AnimationHoverSpeed = 3F;
            this.btsave.AnimationSpeed = 2F;
            this.btsave.BackColor = System.Drawing.Color.Transparent;
            this.btsave.BaseColor = System.Drawing.Color.Transparent;
            this.btsave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.BorderSize = 1;
            this.btsave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btsave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btsave.CheckedForeColor = System.Drawing.Color.White;
            this.btsave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btsave.CheckedImage")));
            this.btsave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btsave.FocusedColor = System.Drawing.Color.Empty;
            this.btsave.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Black;
            this.btsave.Image = null;
            this.btsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.Location = new System.Drawing.Point(262, 327);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(77, 36);
            this.btsave.TabIndex = 23;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbNewpass
            // 
            this.lbNewpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewpass.AutoSize = true;
            this.lbNewpass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewpass.ForeColor = System.Drawing.Color.Black;
            this.lbNewpass.Location = new System.Drawing.Point(405, 139);
            this.lbNewpass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNewpass.Name = "lbNewpass";
            this.lbNewpass.Size = new System.Drawing.Size(69, 21);
            this.lbNewpass.TabIndex = 1;
            this.lbNewpass.Text = "ລະຫັດຜ່ານ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(405, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຊື່ຜູ້ໃຊ້";
            // 
            // txtlname
            // 
            this.txtlname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtlname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.Color.Black;
            this.txtlname.Location = new System.Drawing.Point(55, 238);
            this.txtlname.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(244, 30);
            this.txtlname.TabIndex = 2;
            this.txtlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtlname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlname_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "ນາມສະກຸນ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.Location = new System.Drawing.Point(405, 165);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(244, 30);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtusername.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(405, 93);
            this.txtusername.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(244, 30);
            this.txtusername.TabIndex = 3;
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຊື່ພະນັກງານ";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(55, 93);
            this.txtid.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(244, 30);
            this.txtid.TabIndex = 0;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ລະຫັດພະນັກງານ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(405, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "ປ້ອນລະຫັດຜ່ານຄືນ";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 34);
            this.panel2.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(73, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 22);
            this.label20.TabIndex = 0;
            this.label20.Text = "New User";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 401);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.cbShowPass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbShowPass2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNewpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(708, 440);
            this.MinimumSize = new System.Drawing.Size(631, 440);
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btdel;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNewpass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.ComboBox cmbname;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass1;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}