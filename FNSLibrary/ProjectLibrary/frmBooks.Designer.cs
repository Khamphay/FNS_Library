namespace ProjectLibrary
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.dgvbooks = new Guna.UI.WinForms.GunaDataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btdel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btedit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvbooks
            // 
            this.dgvbooks.AllowUserToAddRows = false;
            this.dgvbooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvbooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvbooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbooks.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbooks.EnableHeadersVisualStyles = false;
            this.dgvbooks.GridColor = System.Drawing.Color.DimGray;
            this.dgvbooks.Location = new System.Drawing.Point(330, 29);
            this.dgvbooks.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.dgvbooks.MultiSelect = false;
            this.dgvbooks.Name = "dgvbooks";
            this.dgvbooks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbooks.RowHeadersVisible = false;
            this.dgvbooks.RowTemplate.Height = 40;
            this.dgvbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbooks.Size = new System.Drawing.Size(902, 468);
            this.dgvbooks.TabIndex = 9;
            this.dgvbooks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvbooks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvbooks.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgvbooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvbooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvbooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvbooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvbooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvbooks.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvbooks.ThemeStyle.ReadOnly = true;
            this.dgvbooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvbooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvbooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvbooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvbooks.ThemeStyle.RowsStyle.Height = 40;
            this.dgvbooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.dgvbooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvbooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbooks_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 34);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(31, 274);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(242, 34);
            this.cmbAuthor.TabIndex = 3;
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmdAuthor_SelectedIndexChanged);
            // 
            // cmbTable
            // 
            this.cmbTable.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(31, 200);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(242, 34);
            this.cmbTable.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(31, 127);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 34);
            this.txtname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "ລະຫັດຕູ້";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(31, 58);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(242, 34);
            this.txtid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "ແຕ່ງໃນປີ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "ຜູ້ແຕ່ງ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ລະຫັດກຸ່ມຂອງປື້ມ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຊື່ປື້ມ";
            // 
            // btdel
            // 
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
            this.btdel.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.Color.Black;
            this.btdel.Image = null;
            this.btdel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.ImageSize = new System.Drawing.Size(30, 30);
            this.btdel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btdel.Location = new System.Drawing.Point(208, 444);
            this.btdel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btdel.Name = "btdel";
            this.btdel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btdel.OnHoverForeColor = System.Drawing.Color.White;
            this.btdel.OnHoverImage = null;
            this.btdel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btdel.OnPressedColor = System.Drawing.Color.White;
            this.btdel.Radius = 2;
            this.btdel.Size = new System.Drawing.Size(64, 37);
            this.btdel.TabIndex = 10;
            this.btdel.Text = "ລຶບ";
            this.btdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btedit
            // 
            this.btedit.Animated = true;
            this.btedit.AnimationHoverSpeed = 3F;
            this.btedit.AnimationSpeed = 2F;
            this.btedit.BackColor = System.Drawing.Color.Transparent;
            this.btedit.BaseColor = System.Drawing.Color.Transparent;
            this.btedit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btedit.BorderSize = 1;
            this.btedit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btedit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btedit.CheckedForeColor = System.Drawing.Color.White;
            this.btedit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btedit.CheckedImage")));
            this.btedit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btedit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btedit.FocusedColor = System.Drawing.Color.Empty;
            this.btedit.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.Black;
            this.btedit.Image = null;
            this.btedit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btedit.ImageSize = new System.Drawing.Size(30, 30);
            this.btedit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btedit.Location = new System.Drawing.Point(119, 444);
            this.btedit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btedit.Name = "btedit";
            this.btedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btedit.OnHoverBorderColor = System.Drawing.Color.White;
            this.btedit.OnHoverForeColor = System.Drawing.Color.White;
            this.btedit.OnHoverImage = null;
            this.btedit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btedit.OnPressedColor = System.Drawing.Color.White;
            this.btedit.Radius = 2;
            this.btedit.Size = new System.Drawing.Size(64, 37);
            this.btedit.TabIndex = 11;
            this.btedit.Text = "ແກ້ໄຂ";
            this.btedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btedit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
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
            this.btsave.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Black;
            this.btsave.Image = null;
            this.btsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.Location = new System.Drawing.Point(30, 444);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(64, 37);
            this.btsave.TabIndex = 12;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gunaLinePanel1.Controls.Add(this.dateTimePicker1);
            this.gunaLinePanel1.Controls.Add(this.btedit);
            this.gunaLinePanel1.Controls.Add(this.cmbAuthor);
            this.gunaLinePanel1.Controls.Add(this.btdel);
            this.gunaLinePanel1.Controls.Add(this.cmbTable);
            this.gunaLinePanel1.Controls.Add(this.btsave);
            this.gunaLinePanel1.Controls.Add(this.txtname);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Controls.Add(this.txtid);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(312, 518);
            this.gunaLinePanel1.TabIndex = 13;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaSeparator1.Location = new System.Drawing.Point(330, 70);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(902, 1);
            this.gunaSeparator1.TabIndex = 19;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 518);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.dgvbooks);
            this.Font = new System.Drawing.Font("Lao_Old_Phimdeed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmBooks";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btdel;
        private Guna.UI.WinForms.GunaAdvenceButton btedit;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private Guna.UI.WinForms.GunaDataGridView dgvbooks;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}