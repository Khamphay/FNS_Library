﻿namespace ProjectLibrary
{
    partial class frmEditCateg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCateg));
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(53, 154);
            this.txtname.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(245, 30);
            this.txtname.TabIndex = 11;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "ຊື່ໝວດປຶ້ມ";
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
            this.btsave.Location = new System.Drawing.Point(76, 231);
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
            this.btsave.TabIndex = 12;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(53, 74);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(245, 30);
            this.txtid.TabIndex = 9;
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "ລະຫັດໝວດ";
            // 
            // txtClear
            // 
            this.txtClear.Animated = true;
            this.txtClear.AnimationHoverSpeed = 3F;
            this.txtClear.AnimationSpeed = 2F;
            this.txtClear.BackColor = System.Drawing.Color.Transparent;
            this.txtClear.BaseColor = System.Drawing.Color.Transparent;
            this.txtClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.txtClear.BorderSize = 1;
            this.txtClear.CheckedBaseColor = System.Drawing.Color.Gray;
            this.txtClear.CheckedBorderColor = System.Drawing.Color.Black;
            this.txtClear.CheckedForeColor = System.Drawing.Color.White;
            this.txtClear.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtClear.CheckedImage")));
            this.txtClear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.txtClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtClear.FocusedColor = System.Drawing.Color.Empty;
            this.txtClear.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.Color.Black;
            this.txtClear.Image = null;
            this.txtClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClear.ImageSize = new System.Drawing.Size(30, 30);
            this.txtClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.txtClear.Location = new System.Drawing.Point(191, 231);
            this.txtClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClear.Name = "txtClear";
            this.txtClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.txtClear.OnHoverBorderColor = System.Drawing.Color.White;
            this.txtClear.OnHoverForeColor = System.Drawing.Color.White;
            this.txtClear.OnHoverImage = null;
            this.txtClear.OnHoverLineColor = System.Drawing.Color.White;
            this.txtClear.OnPressedColor = System.Drawing.Color.White;
            this.txtClear.Radius = 2;
            this.txtClear.Size = new System.Drawing.Size(72, 33);
            this.txtClear.TabIndex = 12;
            this.txtClear.Text = "ຍົກເລີກ";
            this.txtClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 222);
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
            this.panel2.Size = new System.Drawing.Size(356, 34);
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
            // frmEditCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 329);
            this.MinimumSize = new System.Drawing.Size(372, 329);
            this.Name = "frmEditCateg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Category";
            this.Load += new System.EventHandler(this.frmEditCateg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton txtClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}