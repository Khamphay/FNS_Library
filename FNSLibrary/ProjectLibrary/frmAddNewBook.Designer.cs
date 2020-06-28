namespace ProjectLibrary
{
    partial class frmAddNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewBook));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dateAuth = new System.Windows.Forms.DateTimePicker();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtid_Barcode = new System.Windows.Forms.RichTextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCtg = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btdel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbAuthor1 = new System.Windows.Forms.ComboBox();
            this.cmbAuthor2 = new System.Windows.Forms.ComboBox();
            this.cmbAuthor3 = new System.Windows.Forms.ComboBox();
            this.cmbAuthor4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSurname1 = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtSurname3 = new System.Windows.Forms.TextBox();
            this.txtSurname4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ຫວ່າງ",
            "ກຳລັງຈອງ",
            "ກຳລັງຢືມ",
            "ເສຍ"});
            this.cmbStatus.Location = new System.Drawing.Point(323, 416);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(113, 31);
            this.cmbStatus.TabIndex = 10;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(323, 389);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 23);
            this.label19.TabIndex = 20;
            this.label19.Text = "ສະຖານະ";
            // 
            // dateAuth
            // 
            this.dateAuth.CustomFormat = "yyyy";
            this.dateAuth.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAuth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAuth.Location = new System.Drawing.Point(161, 417);
            this.dateAuth.Name = "dateAuth";
            this.dateAuth.Size = new System.Drawing.Size(127, 30);
            this.dateAuth.TabIndex = 9;
            this.dateAuth.Value = new System.DateTime(2020, 4, 6, 0, 0, 0, 0);
            this.dateAuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // cmbTable
            // 
            this.cmbTable.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.ForeColor = System.Drawing.Color.Black;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(161, 349);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(275, 31);
            this.cmbTable.TabIndex = 8;
            this.cmbTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(161, 322);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "ລະຫັດຕູ້";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(161, 390);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "ແຕ່ງໃນປີ";
            // 
            // txtid_Barcode
            // 
            this.txtid_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid_Barcode.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_Barcode.ForeColor = System.Drawing.Color.Black;
            this.txtid_Barcode.Location = new System.Drawing.Point(14, 150);
            this.txtid_Barcode.Name = "txtid_Barcode";
            this.txtid_Barcode.Size = new System.Drawing.Size(141, 297);
            this.txtid_Barcode.TabIndex = 20;
            this.txtid_Barcode.Text = "";
            this.txtid_Barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_Barcode_KeyPress);
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(161, 281);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(275, 31);
            this.cmbType.TabIndex = 7;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // cmbCtg
            // 
            this.cmbCtg.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCtg.ForeColor = System.Drawing.Color.Black;
            this.cmbCtg.FormattingEnabled = true;
            this.cmbCtg.Location = new System.Drawing.Point(161, 216);
            this.cmbCtg.Name = "cmbCtg";
            this.cmbCtg.Size = new System.Drawing.Size(275, 31);
            this.cmbCtg.TabIndex = 6;
            this.cmbCtg.SelectedIndexChanged += new System.EventHandler(this.cmbCtg_SelectedIndexChanged);
            this.cmbCtg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.Black;
            this.txtISBN.Location = new System.Drawing.Point(323, 150);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(113, 30);
            this.txtISBN.TabIndex = 5;
            this.txtISBN.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(161, 83);
            this.txtname.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(275, 30);
            this.txtname.TabIndex = 2;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.ForeColor = System.Drawing.Color.Black;
            this.txtPage.Location = new System.Drawing.Point(161, 149);
            this.txtPage.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(72, 30);
            this.txtPage.TabIndex = 3;
            this.txtPage.Text = "0";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(161, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "ຈຳນວນໜ້າ";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.Black;
            this.txtqty.Location = new System.Drawing.Point(245, 149);
            this.txtqty.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(66, 30);
            this.txtqty.TabIndex = 4;
            this.txtqty.Text = "0";
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(245, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ຈຳນວນ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(161, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ຊື່ໝວດປື້ມ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(161, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຊື່ປະເພດປື້ມ";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(14, 84);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 30);
            this.txtid.TabIndex = 1;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusBooks);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(323, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "ລະຫັດປື້ມ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ລະຫັດປື້ມ/ບາໂຄດ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(161, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຊື່ປື້ມ";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 3F;
            this.gunaAdvenceButton1.AnimationSpeed = 2F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = global::ProjectLibrary.Properties.Resources.print_48px;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = global::ProjectLibrary.Properties.Resources.print_48px;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(483, 485);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Radius = 2;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(88, 36);
            this.gunaAdvenceButton1.TabIndex = 21;
            this.gunaAdvenceButton1.Text = "ພີມ";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.btdel.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.CheckedForeColor = System.Drawing.Color.White;
            this.btdel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btdel.CheckedImage")));
            this.btdel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btdel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btdel.FocusedColor = System.Drawing.Color.Empty;
            this.btdel.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.Color.Black;
            this.btdel.Image = null;
            this.btdel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.ImageSize = new System.Drawing.Size(30, 30);
            this.btdel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btdel.Location = new System.Drawing.Point(371, 485);
            this.btdel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btdel.Name = "btdel";
            this.btdel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btdel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btdel.OnHoverForeColor = System.Drawing.Color.White;
            this.btdel.OnHoverImage = null;
            this.btdel.OnHoverLineColor = System.Drawing.Color.White;
            this.btdel.OnPressedColor = System.Drawing.Color.White;
            this.btdel.Radius = 2;
            this.btdel.Size = new System.Drawing.Size(68, 36);
            this.btdel.TabIndex = 22;
            this.btdel.Text = "ລຶບ";
            this.btdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btdel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
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
            this.btsave.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Black;
            this.btsave.Image = null;
            this.btsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.ImageSize = new System.Drawing.Size(30, 30);
            this.btsave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btsave.Location = new System.Drawing.Point(261, 485);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(68, 36);
            this.btsave.TabIndex = 21;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(351, 481);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 40);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 40);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectLibrary.Properties.Resources.ATitle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 42);
            this.panel1.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(26, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ຂໍ້ມູນປື້ມ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(454, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 469);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(468, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 42);
            this.panel2.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(29, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "ຂໍ້ມູນຜູ້ແຕ່ງ";
            // 
            // cmbAuthor1
            // 
            this.cmbAuthor1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor1.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor1.FormattingEnabled = true;
            this.cmbAuthor1.Location = new System.Drawing.Point(475, 84);
            this.cmbAuthor1.Name = "cmbAuthor1";
            this.cmbAuthor1.Size = new System.Drawing.Size(192, 31);
            this.cmbAuthor1.TabIndex = 11;
            this.cmbAuthor1.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor_SelectedIndexChanged);
            this.cmbAuthor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusAuthor);
            // 
            // cmbAuthor2
            // 
            this.cmbAuthor2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor2.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor2.FormattingEnabled = true;
            this.cmbAuthor2.Location = new System.Drawing.Point(475, 168);
            this.cmbAuthor2.Name = "cmbAuthor2";
            this.cmbAuthor2.Size = new System.Drawing.Size(192, 31);
            this.cmbAuthor2.TabIndex = 12;
            this.cmbAuthor2.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor2_SelectedIndexChanged);
            this.cmbAuthor2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusAuthor);
            // 
            // cmbAuthor3
            // 
            this.cmbAuthor3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor3.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor3.FormattingEnabled = true;
            this.cmbAuthor3.Location = new System.Drawing.Point(475, 247);
            this.cmbAuthor3.Name = "cmbAuthor3";
            this.cmbAuthor3.Size = new System.Drawing.Size(192, 31);
            this.cmbAuthor3.TabIndex = 13;
            this.cmbAuthor3.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor3_SelectedIndexChanged);
            this.cmbAuthor3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusAuthor);
            // 
            // cmbAuthor4
            // 
            this.cmbAuthor4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor4.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor4.FormattingEnabled = true;
            this.cmbAuthor4.Location = new System.Drawing.Point(475, 325);
            this.cmbAuthor4.Name = "cmbAuthor4";
            this.cmbAuthor4.Size = new System.Drawing.Size(192, 31);
            this.cmbAuthor4.TabIndex = 14;
            this.cmbAuthor4.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor4_SelectedIndexChanged);
            this.cmbAuthor4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextFocusAuthor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(677, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "ນາມສະກຸນ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(677, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "ນາມສະກຸນ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(677, 219);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 23);
            this.label15.TabIndex = 16;
            this.label15.Text = "ນາມສະກຸນ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(677, 298);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "ນາມສະກຸນ";
            // 
            // txtSurname1
            // 
            this.txtSurname1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname1.ForeColor = System.Drawing.Color.Black;
            this.txtSurname1.Location = new System.Drawing.Point(677, 84);
            this.txtSurname1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtSurname1.Name = "txtSurname1";
            this.txtSurname1.Size = new System.Drawing.Size(192, 30);
            this.txtSurname1.TabIndex = 20;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname2.ForeColor = System.Drawing.Color.Black;
            this.txtSurname2.Location = new System.Drawing.Point(677, 168);
            this.txtSurname2.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(192, 30);
            this.txtSurname2.TabIndex = 20;
            // 
            // txtSurname3
            // 
            this.txtSurname3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname3.ForeColor = System.Drawing.Color.Black;
            this.txtSurname3.Location = new System.Drawing.Point(677, 247);
            this.txtSurname3.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtSurname3.Name = "txtSurname3";
            this.txtSurname3.Size = new System.Drawing.Size(192, 30);
            this.txtSurname3.TabIndex = 20;
            // 
            // txtSurname4
            // 
            this.txtSurname4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname4.ForeColor = System.Drawing.Color.Black;
            this.txtSurname4.Location = new System.Drawing.Point(677, 325);
            this.txtSurname4.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtSurname4.Name = "txtSurname4";
            this.txtSurname4.Size = new System.Drawing.Size(192, 30);
            this.txtSurname4.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(475, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "ຊື່ຜູ້ແຕ່ງທີ 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(475, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "ຊື່ຜູ້ແຕ່ງທີ 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(475, 219);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "ຊື່ຜູ້ແຕ່ງທີ 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(475, 298);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 23);
            this.label18.TabIndex = 16;
            this.label18.Text = "ຊື່ຜູ້ແຕ່ງທີ 4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(851, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // frmAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(880, 538);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSurname4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSurname3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSurname2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSurname1);
            this.Controls.Add(this.dateAuth);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbAuthor4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbAuthor3);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.cmbAuthor2);
            this.Controls.Add(this.txtid_Barcode);
            this.Controls.Add(this.cmbAuthor1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.cmbCtg);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.frmAddNewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btdel;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCtg;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtid_Barcode;
        private System.Windows.Forms.DateTimePicker dateAuth;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label19;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbAuthor1;
        private System.Windows.Forms.ComboBox cmbAuthor2;
        private System.Windows.Forms.ComboBox cmbAuthor3;
        private System.Windows.Forms.ComboBox cmbAuthor4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSurname1;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtSurname3;
        private System.Windows.Forms.TextBox txtSurname4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}