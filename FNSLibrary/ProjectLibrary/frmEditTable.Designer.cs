﻿namespace ProjectLibrary
{
    partial class frmEditTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTable));
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtidd = new System.Windows.Forms.RichTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(53, 136);
            this.txtQty.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(264, 30);
            this.txtQty.TabIndex = 24;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.Enter += new System.EventHandler(this.txtQty_Enter);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtidd
            // 
            this.txtidd.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidd.Location = new System.Drawing.Point(53, 202);
            this.txtidd.Name = "txtidd";
            this.txtidd.Size = new System.Drawing.Size(264, 131);
            this.txtidd.TabIndex = 29;
            this.txtidd.Text = "";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(53, 71);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(264, 30);
            this.txtid.TabIndex = 23;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "ຈຳນວນ";
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
            this.btsave.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
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
            this.btsave.Location = new System.Drawing.Point(109, 364);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(60, 32);
            this.btsave.TabIndex = 28;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "ລະຫັດຕູ້";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "ລະຫັດຕູ້ຍ່ອຍ";
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
            this.txtClear.Location = new System.Drawing.Point(205, 364);
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
            this.txtClear.TabIndex = 30;
            this.txtClear.Text = "ຍົກເລີກ";
            this.txtClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 356);
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
            this.panel2.Size = new System.Drawing.Size(370, 34);
            this.panel2.TabIndex = 58;
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
            // frmEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtidd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 446);
            this.MinimumSize = new System.Drawing.Size(386, 446);
            this.Name = "frmEditTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTable";
            this.Load += new System.EventHandler(this.frmEditTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.RichTextBox txtidd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton txtClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
    }
}