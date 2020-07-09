namespace ProjectLibrary
{
    partial class frmReserveInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserveInfor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbReserveID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvReserInfor = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserInfor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaSeparator1.Location = new System.Drawing.Point(9, 138);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1112, 1);
            this.gunaSeparator1.TabIndex = 34;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMemberID.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(390, 51);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(217, 34);
            this.txtMemberID.TabIndex = 32;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbReserveID
            // 
            this.lbReserveID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbReserveID.AutoSize = true;
            this.lbReserveID.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReserveID.Location = new System.Drawing.Point(122, 56);
            this.lbReserveID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReserveID.Name = "lbReserveID";
            this.lbReserveID.Size = new System.Drawing.Size(50, 24);
            this.lbReserveID.TabIndex = 2;
            this.lbReserveID.Text = "..........";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ລະຫັດການຈອງ:";
            // 
            // btRent
            // 
            this.btRent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRent.Animated = true;
            this.btRent.AnimationHoverSpeed = 3F;
            this.btRent.AnimationSpeed = 2F;
            this.btRent.BackColor = System.Drawing.Color.Transparent;
            this.btRent.BaseColor = System.Drawing.Color.Transparent;
            this.btRent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btRent.BorderSize = 1;
            this.btRent.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btRent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btRent.CheckedForeColor = System.Drawing.Color.White;
            this.btRent.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btRent.CheckedImage")));
            this.btRent.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btRent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btRent.FocusedColor = System.Drawing.Color.Empty;
            this.btRent.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRent.ForeColor = System.Drawing.Color.Black;
            this.btRent.Image = null;
            this.btRent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btRent.ImageSize = new System.Drawing.Size(30, 30);
            this.btRent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btRent.Location = new System.Drawing.Point(668, 51);
            this.btRent.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.btRent.Name = "btRent";
            this.btRent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btRent.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btRent.OnHoverForeColor = System.Drawing.Color.White;
            this.btRent.OnHoverImage = null;
            this.btRent.OnHoverLineColor = System.Drawing.Color.White;
            this.btRent.OnPressedColor = System.Drawing.Color.White;
            this.btRent.Radius = 2;
            this.btRent.Size = new System.Drawing.Size(71, 34);
            this.btRent.TabIndex = 31;
            this.btRent.Text = "ຢືມປຶ້ມ";
            this.btRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btRent.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btRent.Click += new System.EventHandler(this.btRent_Click);
            // 
            // dgvReserInfor
            // 
            this.dgvReserInfor.AllowUserToAddRows = false;
            this.dgvReserInfor.AllowUserToDeleteRows = false;
            this.dgvReserInfor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReserInfor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReserInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvReserInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReserInfor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReserInfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReserInfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserInfor.ColumnHeadersHeight = 40;
            this.dgvReserInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserInfor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserInfor.EnableHeadersVisualStyles = false;
            this.dgvReserInfor.GridColor = System.Drawing.Color.DimGray;
            this.dgvReserInfor.Location = new System.Drawing.Point(9, 98);
            this.dgvReserInfor.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.dgvReserInfor.MultiSelect = false;
            this.dgvReserInfor.Name = "dgvReserInfor";
            this.dgvReserInfor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserInfor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReserInfor.RowHeadersVisible = false;
            this.dgvReserInfor.RowHeadersWidth = 62;
            this.dgvReserInfor.RowTemplate.Height = 40;
            this.dgvReserInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserInfor.Size = new System.Drawing.Size(1112, 448);
            this.dgvReserInfor.TabIndex = 28;
            this.dgvReserInfor.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvReserInfor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReserInfor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReserInfor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReserInfor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReserInfor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReserInfor.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReserInfor.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgvReserInfor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvReserInfor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReserInfor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReserInfor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReserInfor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReserInfor.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvReserInfor.ThemeStyle.ReadOnly = true;
            this.dgvReserInfor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReserInfor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReserInfor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReserInfor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReserInfor.ThemeStyle.RowsStyle.Height = 40;
            this.dgvReserInfor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dgvReserInfor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReserInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserInfor_CellClick);
            this.dgvReserInfor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserInfor_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ລະຫັດປຶ້ມ/Barcode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 154;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ຊື່ປຶ້ມ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ຈຳນວນໜ້າ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 109;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ໝວດ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ປະເພດ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ລະຫັດຕູ້";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 86;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ວັນທີຈອງ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 94;
            // 
            // Column8
            // 
            this.Column8.DividerWidth = 1;
            this.Column8.HeaderText = "ວັນທີໝົດອາຍຸ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 124;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column9.DividerWidth = 1;
            this.Column9.HeaderText = "ລົບ";
            this.Column9.Image = ((System.Drawing.Image)(resources.GetObject("Column9.Image")));
            this.Column9.MinimumWidth = 40;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 40;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 33);
            this.panel1.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(76, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ຂໍ້ມູນການຈອງປຶ້ມ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ລະຫັດສະມາຊິກ:";
            // 
            // frmReserveInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 553);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.dgvReserInfor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbReserveID);
            this.Controls.Add(this.btRent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReserveInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Information";
            this.Load += new System.EventHandler(this.frmReserveInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserInfor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btRent;
        private Guna.UI.WinForms.GunaDataGridView dgvReserInfor;
        private System.Windows.Forms.Label lbReserveID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.Label label3;
    }
}