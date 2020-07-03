namespace ProjectLibrary
{
    partial class frmBooksDetial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooksDetial));
            this.dgvbooks = new Guna.UI.WinForms.GunaDataGridView();
            this.btedit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btdel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAuthor4 = new System.Windows.Forms.Label();
            this.lbAuthor3 = new System.Windows.Forms.Label();
            this.lbAuthor2 = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbAuthor1 = new System.Windows.Forms.Label();
            this.lbReserveQty = new System.Windows.Forms.Label();
            this.lbRentQty = new System.Windows.Forms.Label();
            this.lbAllQty = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbooks
            // 
            this.dgvbooks.AllowUserToAddRows = false;
            this.dgvbooks.AllowUserToDeleteRows = false;
            this.dgvbooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvbooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvbooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvbooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbooks.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbooks.EnableHeadersVisualStyles = false;
            this.dgvbooks.GridColor = System.Drawing.Color.DimGray;
            this.dgvbooks.Location = new System.Drawing.Point(9, 108);
            this.dgvbooks.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.dgvbooks.MultiSelect = false;
            this.dgvbooks.Name = "dgvbooks";
            this.dgvbooks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbooks.RowHeadersVisible = false;
            this.dgvbooks.RowTemplate.Height = 40;
            this.dgvbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbooks.Size = new System.Drawing.Size(951, 400);
            this.dgvbooks.TabIndex = 14;
            this.dgvbooks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvbooks.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgvbooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvbooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvbooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Bold);
            this.dgvbooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvbooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvbooks.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvbooks.ThemeStyle.ReadOnly = true;
            this.dgvbooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvbooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvbooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 10F);
            this.dgvbooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvbooks.ThemeStyle.RowsStyle.Height = 40;
            this.dgvbooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dgvbooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvbooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbooks_CellClick);
            this.dgvbooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbooks_CellDoubleClick);
            this.dgvbooks.Click += new System.EventHandler(this.dgvbooks_Click);
            // 
            // btedit
            // 
            this.btedit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btedit.Animated = true;
            this.btedit.AnimationHoverSpeed = 3F;
            this.btedit.AnimationSpeed = 2F;
            this.btedit.BackColor = System.Drawing.Color.Transparent;
            this.btedit.BaseColor = System.Drawing.Color.Transparent;
            this.btedit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btedit.BorderSize = 1;
            this.btedit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btedit.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btedit.CheckedForeColor = System.Drawing.Color.White;
            this.btedit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btedit.CheckedImage")));
            this.btedit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btedit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btedit.FocusedColor = System.Drawing.Color.Empty;
            this.btedit.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.Black;
            this.btedit.Image = null;
            this.btedit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btedit.ImageSize = new System.Drawing.Size(30, 30);
            this.btedit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btedit.Location = new System.Drawing.Point(266, 14);
            this.btedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btedit.Name = "btedit";
            this.btedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btedit.OnHoverBorderColor = System.Drawing.Color.White;
            this.btedit.OnHoverForeColor = System.Drawing.Color.White;
            this.btedit.OnHoverImage = null;
            this.btedit.OnHoverLineColor = System.Drawing.Color.White;
            this.btedit.OnPressedColor = System.Drawing.Color.White;
            this.btedit.Radius = 2;
            this.btedit.Size = new System.Drawing.Size(65, 36);
            this.btedit.TabIndex = 20;
            this.btedit.Text = "ແກ້ໄຂ";
            this.btedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btedit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
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
            this.btdel.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
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
            this.btdel.Location = new System.Drawing.Point(354, 14);
            this.btdel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btdel.Name = "btdel";
            this.btdel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btdel.OnHoverForeColor = System.Drawing.Color.White;
            this.btdel.OnHoverImage = null;
            this.btdel.OnHoverLineColor = System.Drawing.Color.White;
            this.btdel.OnPressedColor = System.Drawing.Color.White;
            this.btdel.Radius = 2;
            this.btdel.Size = new System.Drawing.Size(65, 36);
            this.btdel.TabIndex = 19;
            this.btdel.Text = "ລຶບ";
            this.btdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btdel.Click += new System.EventHandler(this.btdel_Click_1);
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
            this.btsave.Location = new System.Drawing.Point(174, 14);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(65, 36);
            this.btsave.TabIndex = 21;
            this.btsave.Text = "ເພີ່ມ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(534, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "ຄົ້ນຫາ:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(587, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 34);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbAuthor4);
            this.groupBox1.Controls.Add(this.lbAuthor3);
            this.groupBox1.Controls.Add(this.lbAuthor2);
            this.groupBox1.Controls.Add(this.lbYear);
            this.groupBox1.Controls.Add(this.lbAuthor1);
            this.groupBox1.Controls.Add(this.lbReserveQty);
            this.groupBox1.Controls.Add(this.lbRentQty);
            this.groupBox1.Controls.Add(this.lbAllQty);
            this.groupBox1.Controls.Add(this.lbBookName);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(970, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 412);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ລາຍລະອຽດ";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "ຈຳນວນທີ່ຈອງ:";
            // 
            // lbAuthor4
            // 
            this.lbAuthor4.AutoSize = true;
            this.lbAuthor4.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor4.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor4.Location = new System.Drawing.Point(111, 325);
            this.lbAuthor4.Name = "lbAuthor4";
            this.lbAuthor4.Size = new System.Drawing.Size(52, 20);
            this.lbAuthor4.TabIndex = 0;
            this.lbAuthor4.Text = "4.........";
            // 
            // lbAuthor3
            // 
            this.lbAuthor3.AutoSize = true;
            this.lbAuthor3.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor3.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor3.Location = new System.Drawing.Point(111, 293);
            this.lbAuthor3.Name = "lbAuthor3";
            this.lbAuthor3.Size = new System.Drawing.Size(53, 20);
            this.lbAuthor3.TabIndex = 0;
            this.lbAuthor3.Text = "3.........";
            // 
            // lbAuthor2
            // 
            this.lbAuthor2.AutoSize = true;
            this.lbAuthor2.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor2.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor2.Location = new System.Drawing.Point(111, 262);
            this.lbAuthor2.Name = "lbAuthor2";
            this.lbAuthor2.Size = new System.Drawing.Size(52, 20);
            this.lbAuthor2.TabIndex = 0;
            this.lbAuthor2.Text = "2.........";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.ForeColor = System.Drawing.Color.Black;
            this.lbYear.Location = new System.Drawing.Point(111, 201);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(44, 17);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = ".........";
            // 
            // lbAuthor1
            // 
            this.lbAuthor1.AutoSize = true;
            this.lbAuthor1.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor1.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor1.Location = new System.Drawing.Point(111, 233);
            this.lbAuthor1.Name = "lbAuthor1";
            this.lbAuthor1.Size = new System.Drawing.Size(52, 20);
            this.lbAuthor1.TabIndex = 0;
            this.lbAuthor1.Text = "1.........";
            // 
            // lbReserveQty
            // 
            this.lbReserveQty.AutoSize = true;
            this.lbReserveQty.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReserveQty.ForeColor = System.Drawing.Color.Black;
            this.lbReserveQty.Location = new System.Drawing.Point(111, 172);
            this.lbReserveQty.Name = "lbReserveQty";
            this.lbReserveQty.Size = new System.Drawing.Size(46, 21);
            this.lbReserveQty.TabIndex = 0;
            this.lbReserveQty.Text = ".........";
            // 
            // lbRentQty
            // 
            this.lbRentQty.AutoSize = true;
            this.lbRentQty.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentQty.ForeColor = System.Drawing.Color.Black;
            this.lbRentQty.Location = new System.Drawing.Point(111, 141);
            this.lbRentQty.Name = "lbRentQty";
            this.lbRentQty.Size = new System.Drawing.Size(46, 21);
            this.lbRentQty.TabIndex = 0;
            this.lbRentQty.Text = ".........";
            // 
            // lbAllQty
            // 
            this.lbAllQty.AutoSize = true;
            this.lbAllQty.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllQty.ForeColor = System.Drawing.Color.Black;
            this.lbAllQty.Location = new System.Drawing.Point(111, 112);
            this.lbAllQty.Name = "lbAllQty";
            this.lbAllQty.Size = new System.Drawing.Size(46, 21);
            this.lbAllQty.TabIndex = 0;
            this.lbAllQty.Text = ".........";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.ForeColor = System.Drawing.Color.Black;
            this.lbBookName.Location = new System.Drawing.Point(111, 79);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(45, 20);
            this.lbBookName.TabIndex = 0;
            this.lbBookName.Text = ".........";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(111, 49);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(44, 17);
            this.lbID.TabIndex = 0;
            this.lbID.Text = ".........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ຈຳນວນທີ່ຢຶມ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ແຕ່ງໃນປີ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ແຕ່ງໂດຍ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ຈຳນວນທັງໝົດ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(57, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "ຊື່ປຶ້ມ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະຫັດປຶ້ມ:";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaSeparator1.Location = new System.Drawing.Point(9, 148);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(951, 1);
            this.gunaSeparator1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 34);
            this.panel2.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(82, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ຂໍ້ມູນປຶ້ມ";
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
            this.btExit.Location = new System.Drawing.Point(1223, 3);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Controls.Add(this.btdel);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 65);
            this.panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 41);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(343, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 41);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // frmBooksDetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvbooks);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBooksDetial";
            this.Text = "frmBooksDetial";
            this.Load += new System.EventHandler(this.frmBooksDetial_Load);
            this.Click += new System.EventHandler(this.frmBooksDetial_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvbooks;
        private Guna.UI.WinForms.GunaAdvenceButton btedit;
        private Guna.UI.WinForms.GunaAdvenceButton btdel;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAuthor4;
        private System.Windows.Forms.Label lbAuthor3;
        private System.Windows.Forms.Label lbAuthor2;
        private System.Windows.Forms.Label lbAuthor1;
        private System.Windows.Forms.Label lbReserveQty;
        private System.Windows.Forms.Label lbRentQty;
        private System.Windows.Forms.Label lbAllQty;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaAdvenceButton btExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}