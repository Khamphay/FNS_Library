namespace ProjectLibrary
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.btExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbShowPass1 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.cbShowPass2 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.cbShowPass3 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.btdel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNewpass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewsUser = new System.Windows.Forms.TextBox();
            this.txtOldUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AnimationHoverSpeed = 0.07F;
            this.btExit.AnimationSpeed = 0.03F;
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BaseColor = System.Drawing.Color.Transparent;
            this.btExit.BorderColor = System.Drawing.Color.Black;
            this.btExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btExit.CheckedForeColor = System.Drawing.Color.White;
            this.btExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btExit.CheckedImage")));
            this.btExit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btExit.FocusedColor = System.Drawing.Color.Empty;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btExit.Location = new System.Drawing.Point(578, 2);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExit.Name = "btExit";
            this.btExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btExit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btExit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btExit.OnHoverImage")));
            this.btExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btExit.OnPressedColor = System.Drawing.Color.Gainsboro;
            this.btExit.Radius = 2;
            this.btExit.Size = new System.Drawing.Size(20, 20);
            this.btExit.TabIndex = 35;
            this.btExit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(281, 347);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 41);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // cbShowPass1
            // 
            this.cbShowPass1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShowPass1.ImageCheckedOff = global::ProjectLibrary.Properties.Resources.eye1;
            this.cbShowPass1.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass1.ImageCheckedOn")));
            this.cbShowPass1.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass1.Location = new System.Drawing.Point(556, 166);
            this.cbShowPass1.Name = "cbShowPass1";
            this.cbShowPass1.Size = new System.Drawing.Size(27, 21);
            this.cbShowPass1.TabIndex = 27;
            this.cbShowPass1.CheckedChanged += new System.EventHandler(this.cbShowPass1_CheckedChanged);
            // 
            // cbShowPass2
            // 
            this.cbShowPass2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShowPass2.ImageCheckedOff = global::ProjectLibrary.Properties.Resources.eye1;
            this.cbShowPass2.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass2.ImageCheckedOn")));
            this.cbShowPass2.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass2.Location = new System.Drawing.Point(556, 232);
            this.cbShowPass2.Name = "cbShowPass2";
            this.cbShowPass2.Size = new System.Drawing.Size(27, 21);
            this.cbShowPass2.TabIndex = 27;
            this.cbShowPass2.CheckedChanged += new System.EventHandler(this.cbShowPass2_CheckedChanged);
            // 
            // cbShowPass3
            // 
            this.cbShowPass3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbShowPass3.ImageCheckedOff = global::ProjectLibrary.Properties.Resources.eye1;
            this.cbShowPass3.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass3.ImageCheckedOn")));
            this.cbShowPass3.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass3.Location = new System.Drawing.Point(556, 297);
            this.cbShowPass3.Name = "cbShowPass3";
            this.cbShowPass3.Size = new System.Drawing.Size(27, 21);
            this.cbShowPass3.TabIndex = 28;
            this.cbShowPass3.CheckedChanged += new System.EventHandler(this.cbShowPass3_CheckedChanged);
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
            this.btdel.Location = new System.Drawing.Point(297, 352);
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
            this.btdel.Text = "ເພີ່ມຜູ້ໃຊ້";
            this.btdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(301, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ປ້ອນລະຫັດຜ່ານຄືນ";
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
            this.btsave.Location = new System.Drawing.Point(188, 352);
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(301, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "ລະຫັດຜ່ານເກົ່າ";
            // 
            // lbNewpass
            // 
            this.lbNewpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewpass.AutoSize = true;
            this.lbNewpass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewpass.ForeColor = System.Drawing.Color.Black;
            this.lbNewpass.Location = new System.Drawing.Point(301, 201);
            this.lbNewpass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNewpass.Name = "lbNewpass";
            this.lbNewpass.Size = new System.Drawing.Size(90, 23);
            this.lbNewpass.TabIndex = 1;
            this.lbNewpass.Text = "ລະຫັດຜ່ານໃໝ່";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(301, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ຊື່ຜູ້ໃຊ້ໃຫມ່";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຊື່ຜູ້ໃຊ້ເກົ່າ";
            // 
            // txtlname
            // 
            this.txtlname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtlname.Enabled = false;
            this.txtlname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.Color.Black;
            this.txtlname.Location = new System.Drawing.Point(23, 227);
            this.txtlname.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(244, 30);
            this.txtlname.TabIndex = 2;
            this.txtlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ນາມສະກຸນ";
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRePass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.ForeColor = System.Drawing.Color.Black;
            this.txtRePass.Location = new System.Drawing.Point(301, 292);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(244, 30);
            this.txtRePass.TabIndex = 7;
            this.txtRePass.UseSystemPasswordChar = true;
            this.txtRePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOldPass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.Location = new System.Drawing.Point(301, 161);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(244, 30);
            this.txtOldPass.TabIndex = 5;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPass.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.Location = new System.Drawing.Point(301, 227);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(244, 30);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtNewsUser
            // 
            this.txtNewsUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewsUser.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewsUser.ForeColor = System.Drawing.Color.Black;
            this.txtNewsUser.Location = new System.Drawing.Point(301, 93);
            this.txtNewsUser.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtNewsUser.Name = "txtNewsUser";
            this.txtNewsUser.Size = new System.Drawing.Size(244, 30);
            this.txtNewsUser.TabIndex = 4;
            this.txtNewsUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtOldUserName
            // 
            this.txtOldUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOldUserName.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldUserName.ForeColor = System.Drawing.Color.Black;
            this.txtOldUserName.Location = new System.Drawing.Point(23, 292);
            this.txtOldUserName.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtOldUserName.Name = "txtOldUserName";
            this.txtOldUserName.Size = new System.Drawing.Size(244, 30);
            this.txtOldUserName.TabIndex = 3;
            this.txtOldUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຊື່ພະນັກງານ";
            // 
            // txtfName
            // 
            this.txtfName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfName.Enabled = false;
            this.txtfName.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfName.ForeColor = System.Drawing.Color.Black;
            this.txtfName.Location = new System.Drawing.Point(23, 161);
            this.txtfName.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(244, 30);
            this.txtfName.TabIndex = 1;
            this.txtfName.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtfName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(23, 93);
            this.txtid.Margin = new System.Windows.Forms.Padding(8, 25, 8, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(244, 30);
            this.txtid.TabIndex = 0;
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ລະຫັດພະນັກງານ";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 34);
            this.panel2.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(63, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ແກ້ໄຂ້ຂໍ້ມູນຜູ້ໃຊ້";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbShowPass1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowPass2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbShowPass3);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOldUserName);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtNewsUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lbNewpass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlname);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditUser";
            this.Text = "frmEditUser";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btdel;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNewpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass2;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass3;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass1;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewsUser;
        private Guna.UI.WinForms.GunaAdvenceButton btExit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}