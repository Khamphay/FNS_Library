namespace ProjectLibrary
{
    partial class frmEditAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAuthor));
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(57, 201);
            this.txtlname.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(265, 41);
            this.txtlname.TabIndex = 24;
            this.txtlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtlname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyLetter);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(57, 135);
            this.txtfname.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(265, 41);
            this.txtfname.TabIndex = 0;
            this.txtfname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyLetter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "ນາມສະກຸນ";
            // 
            // btsave
            // 
            this.btsave.Animated = true;
            this.btsave.AnimationHoverSpeed = 3F;
            this.btsave.AnimationSpeed = 2F;
            this.btsave.BackColor = System.Drawing.Color.Transparent;
            this.btsave.BaseColor = System.Drawing.Color.Transparent;
            this.btsave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.BorderSize = 1;
            this.btsave.CheckedBaseColor = System.Drawing.Color.White;
            this.btsave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btsave.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btsave.CheckedImage")));
            this.btsave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btsave.FocusedColor = System.Drawing.Color.Empty;
            this.btsave.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Black;
            this.btsave.Image = null;
            this.btsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.Location = new System.Drawing.Point(94, 327);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(65, 33);
            this.btsave.TabIndex = 26;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(57, 267);
            this.txttel.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(265, 41);
            this.txttel.TabIndex = 25;
            this.txttel.Enter += new System.EventHandler(this.txttel_Enter);
            this.txttel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttel_KeyDown);
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "ຊື່ຜູ້ແຕ່ງ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 34);
            this.label5.TabIndex = 22;
            this.label5.Text = "ເບີໂທ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "ລະຫັດຜູ້ແຕ່ງ";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(57, 70);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(265, 41);
            this.txtid.TabIndex = 18;
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // btClear
            // 
            this.btClear.Animated = true;
            this.btClear.AnimationHoverSpeed = 3F;
            this.btClear.AnimationSpeed = 2F;
            this.btClear.BackColor = System.Drawing.Color.Transparent;
            this.btClear.BaseColor = System.Drawing.Color.Transparent;
            this.btClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btClear.BorderSize = 1;
            this.btClear.CheckedBaseColor = System.Drawing.Color.White;
            this.btClear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btClear.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btClear.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btClear.CheckedImage")));
            this.btClear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClear.FocusedColor = System.Drawing.Color.Empty;
            this.btClear.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Black;
            this.btClear.Image = null;
            this.btClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btClear.Location = new System.Drawing.Point(206, 327);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClear.Name = "btClear";
            this.btClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btClear.OnHoverBorderColor = System.Drawing.Color.White;
            this.btClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btClear.OnHoverImage = null;
            this.btClear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btClear.OnPressedColor = System.Drawing.Color.White;
            this.btClear.Radius = 2;
            this.btClear.Size = new System.Drawing.Size(65, 33);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "ຍົກເລີກ";
            this.btClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(182, 321);
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
            this.panel2.Size = new System.Drawing.Size(371, 34);
            this.panel2.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 38);
            this.label20.TabIndex = 0;
            this.label20.Text = "ປ້ອນຂໍ້ມູນ";
            // 
            // frmEditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 357);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 413);
            this.MinimumSize = new System.Drawing.Size(393, 413);
            this.Name = "frmEditAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Author";
            this.Load += new System.EventHandler(this.frmEditAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private Guna.UI.WinForms.GunaAdvenceButton btClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}