namespace ProjectLibrary
{
    partial class frmBookLost
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookLost));
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvBooksLost = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAllCost = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksLost)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.ForeColor = System.Drawing.Color.Black;
            this.txtMemberID.Location = new System.Drawing.Point(116, 22);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(249, 30);
            this.txtMemberID.TabIndex = 24;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "ລະຫັດສະມາຊິກ:";
            // 
            // dgvBooksLost
            // 
            this.dgvBooksLost.AllowUserToAddRows = false;
            this.dgvBooksLost.AllowUserToDeleteRows = false;
            this.dgvBooksLost.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBooksLost.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooksLost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksLost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvBooksLost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooksLost.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooksLost.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksLost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooksLost.ColumnHeadersHeight = 40;
            this.dgvBooksLost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooksLost.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooksLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooksLost.EnableHeadersVisualStyles = false;
            this.dgvBooksLost.GridColor = System.Drawing.Color.DimGray;
            this.dgvBooksLost.Location = new System.Drawing.Point(0, 101);
            this.dgvBooksLost.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dgvBooksLost.MultiSelect = false;
            this.dgvBooksLost.Name = "dgvBooksLost";
            this.dgvBooksLost.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooksLost.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooksLost.RowHeadersVisible = false;
            this.dgvBooksLost.RowTemplate.Height = 40;
            this.dgvBooksLost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksLost.Size = new System.Drawing.Size(1192, 500);
            this.dgvBooksLost.TabIndex = 14;
            this.dgvBooksLost.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvBooksLost.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBooksLost.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBooksLost.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBooksLost.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBooksLost.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBooksLost.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvBooksLost.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgvBooksLost.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooksLost.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBooksLost.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBooksLost.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBooksLost.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBooksLost.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBooksLost.ThemeStyle.ReadOnly = true;
            this.dgvBooksLost.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooksLost.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooksLost.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBooksLost.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvBooksLost.ThemeStyle.RowsStyle.Height = 40;
            this.dgvBooksLost.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.dgvBooksLost.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBooksLost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooksLost_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ລະຫັດບາໂຄດ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "ຊື່ປຶ້ມ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 63;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "ຈຳນວນໜ້າ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 109;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "ຈຳນວນ";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 83;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ຄ່າປັບໃໝ່/ຫົວ";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
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
            // 
            // Column7
            // 
            this.Column7.DividerWidth = 1;
            this.Column7.HeaderText = "ວັນທີ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column8.DividerWidth = 1;
            this.Column8.HeaderText = "";
            this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
            this.Column8.MinimumWidth = 50;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 50;
            // 
            // btsave
            // 
            this.btsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btsave.Enabled = false;
            this.btsave.FocusedColor = System.Drawing.Color.Empty;
            this.btsave.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Black;
            this.btsave.Image = null;
            this.btsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.Location = new System.Drawing.Point(390, 20);
            this.btsave.Margin = new System.Windows.Forms.Padding(5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(70, 34);
            this.btsave.TabIndex = 21;
            this.btsave.Text = "ບັນທືກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbTel);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbMemberName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbMember);
            this.panel2.Controls.Add(this.lbMemberID);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 34);
            this.panel2.TabIndex = 60;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.ForeColor = System.Drawing.Color.Black;
            this.lbTel.Location = new System.Drawing.Point(888, 4);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(0, 24);
            this.lbTel.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(839, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 54;
            this.label11.Text = "ເບີໂທ:";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberName.ForeColor = System.Drawing.Color.Black;
            this.lbMemberName.Location = new System.Drawing.Point(601, 4);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(0, 21);
            this.lbMemberName.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(480, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 21);
            this.label13.TabIndex = 56;
            this.label13.Text = "ຊື່ ແລະ ນາມສະກຸນ:";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.Color.Black;
            this.lbMember.Location = new System.Drawing.Point(247, 4);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(100, 21);
            this.lbMember.TabIndex = 51;
            this.lbMember.Text = "ລະຫັດສະມາຊິກ:";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberID.ForeColor = System.Drawing.Color.Black;
            this.lbMemberID.Location = new System.Drawing.Point(353, 4);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(0, 24);
            this.lbMemberID.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(82, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ຂໍ້ມູນປື້ມເສຍ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAllCost);
            this.panel1.Controls.Add(this.lbCost);
            this.panel1.Controls.Add(this.cbAll);
            this.panel1.Controls.Add(this.txtMemberID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 67);
            this.panel1.TabIndex = 61;
            // 
            // lbAllCost
            // 
            this.lbAllCost.AutoSize = true;
            this.lbAllCost.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllCost.ForeColor = System.Drawing.Color.Black;
            this.lbAllCost.Location = new System.Drawing.Point(1021, 26);
            this.lbAllCost.Name = "lbAllCost";
            this.lbAllCost.Size = new System.Drawing.Size(57, 21);
            this.lbAllCost.TabIndex = 56;
            this.lbAllCost.Text = "CostAll";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.ForeColor = System.Drawing.Color.Black;
            this.lbCost.Location = new System.Drawing.Point(769, 26);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(41, 21);
            this.lbCost.TabIndex = 56;
            this.lbCost.Text = "Cost";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAll.ForeColor = System.Drawing.Color.Black;
            this.cbAll.Location = new System.Drawing.Point(527, 24);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(107, 25);
            this.cbAll.TabIndex = 26;
            this.cbAll.Text = "ສະແດງທັງໝົດ";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(907, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "ຄ່າປັບໃໝ່ທັງໝົດ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(694, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "ຄ່າປັບໃໝ່:";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 142);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1192, 1);
            this.gunaSeparator1.TabIndex = 22;
            // 
            // frmBookLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 601);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.dgvBooksLost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 640);
            this.MinimumSize = new System.Drawing.Size(1208, 640);
            this.Name = "frmBookLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Lost";
            this.Load += new System.EventHandler(this.frmBookLost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksLost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvBooksLost;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAll;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbAllCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}