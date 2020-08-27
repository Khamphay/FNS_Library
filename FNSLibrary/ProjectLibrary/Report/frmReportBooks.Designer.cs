namespace ProjectLibrary.FormShow.BooksInformation
{
    partial class frmReportBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportBooks));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rdbRent = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReserve = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbAll = new Guna.UI.WinForms.GunaRadioButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 38);
            this.panel2.TabIndex = 61;
            this.panel2.Click += new System.EventHandler(this.gunaGroupBox1_Click);
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
            this.btExit.Image = global::ProjectLibrary.Properties.Resources.delete_30px;
            this.btExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btExit.Location = new System.Drawing.Point(1033, 1);
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
            this.btExit.TabIndex = 36;
            this.btExit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(82, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ລາຍງານຂໍ້ມູນປື້ມ";
            this.label20.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 558);
            this.panel1.TabIndex = 62;
            this.panel1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.rdbRent);
            this.gunaGroupBox1.Controls.Add(this.rdbReserve);
            this.gunaGroupBox1.Controls.Add(this.rdbAll);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 8);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(213, 202);
            this.gunaGroupBox1.TabIndex = 54;
            this.gunaGroupBox1.Text = "ລາຍງານຕາມ:";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 4);
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // rdbRent
            // 
            this.rdbRent.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbRent.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbRent.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.rdbRent.FillColor = System.Drawing.Color.White;
            this.rdbRent.Font = new System.Drawing.Font("Phetsarath OT", 11.25F);
            this.rdbRent.Location = new System.Drawing.Point(14, 132);
            this.rdbRent.Name = "rdbRent";
            this.rdbRent.Size = new System.Drawing.Size(182, 26);
            this.rdbRent.TabIndex = 66;
            this.rdbRent.Text = "ລາຍງານຂໍ້ມູນປຶ້ມທີ່ກຳລັງຢືມ";
            this.rdbRent.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // rdbReserve
            // 
            this.rdbReserve.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbReserve.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbReserve.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.rdbReserve.FillColor = System.Drawing.Color.White;
            this.rdbReserve.Font = new System.Drawing.Font("Phetsarath OT", 11.25F);
            this.rdbReserve.Location = new System.Drawing.Point(14, 92);
            this.rdbReserve.Name = "rdbReserve";
            this.rdbReserve.Size = new System.Drawing.Size(187, 26);
            this.rdbReserve.TabIndex = 66;
            this.rdbReserve.Text = "ລາຍງານຂໍ້ມູນປຶ້ມທີ່ກຳລັງຈອງ";
            this.rdbReserve.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // rdbAll
            // 
            this.rdbAll.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbAll.Checked = true;
            this.rdbAll.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.rdbAll.FillColor = System.Drawing.Color.White;
            this.rdbAll.Font = new System.Drawing.Font("Phetsarath OT", 11.25F);
            this.rdbAll.Location = new System.Drawing.Point(14, 52);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(162, 26);
            this.rdbAll.TabIndex = 67;
            this.rdbAll.Text = "ລາຍງານຂໍ້ມູນປຶ້ມທັງໝົດ";
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            this.rdbAll.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(237, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(823, 558);
            this.crystalReportViewer1.TabIndex = 63;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // frmReportBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1060, 596);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportBooks";
            this.Text = "frmReportBooks";
            this.Load += new System.EventHandler(this.frmReportBooks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaAdvenceButton btExit;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rdbRent;
        private Guna.UI.WinForms.GunaRadioButton rdbReserve;
        private Guna.UI.WinForms.GunaRadioButton rdbAll;
    }
}