namespace ProjectLibrary
{
    partial class frmEditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStaff));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radifiman = new Guna.UI.WinForms.GunaRadioButton();
            this.radimal = new Guna.UI.WinForms.GunaRadioButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radifiman);
            this.groupBox1.Controls.Add(this.radimal);
            this.groupBox1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 64);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ເພດ";
            // 
            // radifiman
            // 
            this.radifiman.BaseColor = System.Drawing.SystemColors.Control;
            this.radifiman.CheckedOffColor = System.Drawing.Color.Black;
            this.radifiman.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.radifiman.FillColor = System.Drawing.Color.White;
            this.radifiman.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radifiman.Location = new System.Drawing.Point(184, 28);
            this.radifiman.MinimumSize = new System.Drawing.Size(55, 27);
            this.radifiman.Name = "radifiman";
            this.radifiman.Size = new System.Drawing.Size(55, 27);
            this.radifiman.TabIndex = 5;
            this.radifiman.Text = "ຍິງ";
            this.radifiman.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // radimal
            // 
            this.radimal.BaseColor = System.Drawing.SystemColors.Control;
            this.radimal.Checked = true;
            this.radimal.CheckedOffColor = System.Drawing.Color.Black;
            this.radimal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.radimal.FillColor = System.Drawing.Color.White;
            this.radimal.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radimal.Location = new System.Drawing.Point(48, 28);
            this.radimal.MinimumSize = new System.Drawing.Size(65, 27);
            this.radimal.Name = "radimal";
            this.radimal.Size = new System.Drawing.Size(65, 27);
            this.radimal.TabIndex = 4;
            this.radimal.Text = "ຊາຍ";
            this.radimal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(63, 76);
            this.txtid.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(270, 30);
            this.txtid.TabIndex = 1;
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(63, 348);
            this.txttel.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(270, 30);
            this.txttel.TabIndex = 4;
            this.txttel.Enter += new System.EventHandler(this.txttel_Enter);
            this.txttel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttel_KeyDown_1);
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
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
            this.btsave.Location = new System.Drawing.Point(102, 418);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(72, 33);
            this.btsave.TabIndex = 33;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "ເບີໂທລະສັບ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "ລະຫັດພະນັກງານ";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(63, 144);
            this.txtname.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(270, 30);
            this.txtname.TabIndex = 2;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyLetter);
            // 
            // txtsurename
            // 
            this.txtsurename.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurename.Location = new System.Drawing.Point(63, 210);
            this.txtsurename.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txtsurename.Name = "txtsurename";
            this.txtsurename.Size = new System.Drawing.Size(270, 30);
            this.txtsurename.TabIndex = 3;
            this.txtsurename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtsurename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyLetter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "ນາມສະກຸນ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "ຊື່ພະນັກງານ";
            // 
            // btClear
            // 
            this.btClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btClear.Animated = true;
            this.btClear.AnimationHoverSpeed = 3F;
            this.btClear.AnimationSpeed = 2F;
            this.btClear.BackColor = System.Drawing.Color.Transparent;
            this.btClear.BaseColor = System.Drawing.Color.Transparent;
            this.btClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btClear.BorderSize = 1;
            this.btClear.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btClear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btClear.CheckedForeColor = System.Drawing.Color.White;
            this.btClear.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btClear.CheckedImage")));
            this.btClear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClear.FocusedColor = System.Drawing.Color.Empty;
            this.btClear.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Black;
            this.btClear.Image = null;
            this.btClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btClear.Location = new System.Drawing.Point(212, 418);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClear.Name = "btClear";
            this.btClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btClear.OnHoverBorderColor = System.Drawing.Color.White;
            this.btClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btClear.OnHoverImage = null;
            this.btClear.OnHoverLineColor = System.Drawing.Color.White;
            this.btClear.OnPressedColor = System.Drawing.Color.White;
            this.btClear.Radius = 2;
            this.btClear.Size = new System.Drawing.Size(72, 33);
            this.btClear.TabIndex = 33;
            this.btClear.Text = "ຍົກເລີກ";
            this.btClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 42);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjectLibrary.Properties.Resources.ATitle;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 34);
            this.panel2.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ປ້ອນຂໍ້ມູນ";
            // 
            // frmEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsurename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 504);
            this.MinimumSize = new System.Drawing.Size(405, 504);
            this.Name = "frmEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Staff";
            this.Load += new System.EventHandler(this.frmEditStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaRadioButton radifiman;
        private Guna.UI.WinForms.GunaRadioButton radimal;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttel;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}