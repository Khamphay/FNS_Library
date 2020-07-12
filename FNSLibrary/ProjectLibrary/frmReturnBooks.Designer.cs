namespace ProjectLibrary
{
    partial class frmReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEpxireDate = new System.Windows.Forms.Label();
            this.lbPriceTotal = new System.Windows.Forms.Label();
            this.lbDateExpire = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDateSt = new System.Windows.Forms.Label();
            this.lbRentQty = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbMemID = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbShowBooksExpire = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQtyTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.dgvReturnbooks = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btBookLost = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btsave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnbooks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "ລະຫັດການຢືມ";
            // 
            // txtRentId
            // 
            this.txtRentId.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentId.ForeColor = System.Drawing.Color.Black;
            this.txtRentId.Location = new System.Drawing.Point(8, 72);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(92, 34);
            this.txtRentId.TabIndex = 38;
            this.txtRentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentId_KeyPress);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.ForeColor = System.Drawing.Color.Black;
            this.txtbarcode.Location = new System.Drawing.Point(140, 72);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(235, 34);
            this.txtbarcode.TabIndex = 37;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbid_TextChanged);
            this.txtbarcode.Enter += new System.EventHandler(this.txtbid_Enter);
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbid_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(140, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "ລະຫັດປຶ້ມ/Barcode";
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
            this.btExit.Location = new System.Drawing.Point(1118, 2);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbEpxireDate);
            this.groupBox1.Controls.Add(this.lbPriceTotal);
            this.groupBox1.Controls.Add(this.lbDateExpire);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbDateSt);
            this.groupBox1.Controls.Add(this.lbRentQty);
            this.groupBox1.Controls.Add(this.lbMemberName);
            this.groupBox1.Controls.Add(this.lbMemID);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbShowBooksExpire);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbQtyTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(863, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 459);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ລາຍລະອຽດ";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // lbEpxireDate
            // 
            this.lbEpxireDate.AutoSize = true;
            this.lbEpxireDate.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpxireDate.ForeColor = System.Drawing.Color.Black;
            this.lbEpxireDate.Location = new System.Drawing.Point(125, 219);
            this.lbEpxireDate.Name = "lbEpxireDate";
            this.lbEpxireDate.Size = new System.Drawing.Size(55, 21);
            this.lbEpxireDate.TabIndex = 0;
            this.lbEpxireDate.Text = ".........";
            // 
            // lbPriceTotal
            // 
            this.lbPriceTotal.AutoSize = true;
            this.lbPriceTotal.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceTotal.ForeColor = System.Drawing.Color.Black;
            this.lbPriceTotal.Location = new System.Drawing.Point(125, 277);
            this.lbPriceTotal.Name = "lbPriceTotal";
            this.lbPriceTotal.Size = new System.Drawing.Size(55, 21);
            this.lbPriceTotal.TabIndex = 0;
            this.lbPriceTotal.Text = ".........";
            // 
            // lbDateExpire
            // 
            this.lbDateExpire.AutoSize = true;
            this.lbDateExpire.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateExpire.ForeColor = System.Drawing.Color.Black;
            this.lbDateExpire.Location = new System.Drawing.Point(125, 190);
            this.lbDateExpire.Name = "lbDateExpire";
            this.lbDateExpire.Size = new System.Drawing.Size(55, 21);
            this.lbDateExpire.TabIndex = 0;
            this.lbDateExpire.Text = ".........";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(125, 248);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(55, 21);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = ".........";
            // 
            // lbDateSt
            // 
            this.lbDateSt.AutoSize = true;
            this.lbDateSt.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateSt.ForeColor = System.Drawing.Color.Black;
            this.lbDateSt.Location = new System.Drawing.Point(125, 161);
            this.lbDateSt.Name = "lbDateSt";
            this.lbDateSt.Size = new System.Drawing.Size(55, 21);
            this.lbDateSt.TabIndex = 0;
            this.lbDateSt.Text = ".........";
            // 
            // lbRentQty
            // 
            this.lbRentQty.AutoSize = true;
            this.lbRentQty.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentQty.ForeColor = System.Drawing.Color.Black;
            this.lbRentQty.Location = new System.Drawing.Point(125, 130);
            this.lbRentQty.Name = "lbRentQty";
            this.lbRentQty.Size = new System.Drawing.Size(55, 21);
            this.lbRentQty.TabIndex = 0;
            this.lbRentQty.Text = ".........";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberName.ForeColor = System.Drawing.Color.Black;
            this.lbMemberName.Location = new System.Drawing.Point(125, 103);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(55, 21);
            this.lbMemberName.TabIndex = 0;
            this.lbMemberName.Text = ".........";
            // 
            // lbMemID
            // 
            this.lbMemID.AutoSize = true;
            this.lbMemID.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemID.ForeColor = System.Drawing.Color.Black;
            this.lbMemID.Location = new System.Drawing.Point(125, 73);
            this.lbMemID.Name = "lbMemID";
            this.lbMemID.Size = new System.Drawing.Size(55, 21);
            this.lbMemID.TabIndex = 0;
            this.lbMemID.Text = ".........";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(125, 45);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(55, 21);
            this.lbID.TabIndex = 0;
            this.lbID.Text = ".........";
            // 
            // lbShowBooksExpire
            // 
            this.lbShowBooksExpire.AutoSize = true;
            this.lbShowBooksExpire.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowBooksExpire.ForeColor = System.Drawing.Color.Red;
            this.lbShowBooksExpire.Location = new System.Drawing.Point(10, 368);
            this.lbShowBooksExpire.Name = "lbShowBooksExpire";
            this.lbShowBooksExpire.Size = new System.Drawing.Size(0, 21);
            this.lbShowBooksExpire.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "ຄ່າປັບໃໝ່ທັງໝົດ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "ວັນທີສົ່ງ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "ວັນທີຢືມ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "ຄ່າປັບໃໝ່/ຫົວ/ວັນ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ຈຳນວນວັນທີ່ເກີນ:";
            // 
            // lbQtyTotal
            // 
            this.lbQtyTotal.AutoSize = true;
            this.lbQtyTotal.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtyTotal.ForeColor = System.Drawing.Color.Black;
            this.lbQtyTotal.Location = new System.Drawing.Point(30, 130);
            this.lbQtyTotal.Name = "lbQtyTotal";
            this.lbQtyTotal.Size = new System.Drawing.Size(84, 21);
            this.lbQtyTotal.TabIndex = 0;
            this.lbQtyTotal.Text = "ຈຳນວນທີ່ຢຶມ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ຊື່ສະມາຊິກ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "ລະຫັດສະມາຊິກ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະຫັດຢືມ:";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaSeparator1.Location = new System.Drawing.Point(7, 159);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(847, 1);
            this.gunaSeparator1.TabIndex = 22;
            // 
            // dgvReturnbooks
            // 
            this.dgvReturnbooks.AllowUserToAddRows = false;
            this.dgvReturnbooks.AllowUserToDeleteRows = false;
            this.dgvReturnbooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReturnbooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturnbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnbooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReturnbooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReturnbooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnbooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnbooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnbooks.ColumnHeadersHeight = 40;
            this.dgvReturnbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturnbooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnbooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnbooks.EnableHeadersVisualStyles = false;
            this.dgvReturnbooks.GridColor = System.Drawing.Color.DimGray;
            this.dgvReturnbooks.Location = new System.Drawing.Point(7, 118);
            this.dgvReturnbooks.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dgvReturnbooks.MultiSelect = false;
            this.dgvReturnbooks.Name = "dgvReturnbooks";
            this.dgvReturnbooks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnbooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReturnbooks.RowHeadersVisible = false;
            this.dgvReturnbooks.RowTemplate.Height = 40;
            this.dgvReturnbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnbooks.Size = new System.Drawing.Size(847, 446);
            this.dgvReturnbooks.TabIndex = 14;
            this.dgvReturnbooks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvReturnbooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReturnbooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReturnbooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReturnbooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReturnbooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReturnbooks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReturnbooks.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturnbooks.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvReturnbooks.ThemeStyle.ReadOnly = true;
            this.dgvReturnbooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReturnbooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnbooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnbooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnbooks.ThemeStyle.RowsStyle.Height = 40;
            this.dgvReturnbooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.dgvReturnbooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReturnbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnbooks_CellContentClick);
            this.dgvReturnbooks.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "ລະຫັດບາໂຄດ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ປຶ້ມ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ຈຳນວນໜ້າ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ໝວດ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ປະເພດ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ຈຳນວນ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 1;
            this.Column6.HeaderText = "ລະຫັດຕູ້";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.DividerWidth = 1;
            this.Column8.HeaderText = "ຍົກເລີກ";
            this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
            this.Column8.MinimumWidth = 40;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 63;
            // 
            // btBookLost
            // 
            this.btBookLost.Animated = true;
            this.btBookLost.AnimationHoverSpeed = 3F;
            this.btBookLost.AnimationSpeed = 2F;
            this.btBookLost.BackColor = System.Drawing.Color.Transparent;
            this.btBookLost.BaseColor = System.Drawing.Color.Transparent;
            this.btBookLost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btBookLost.BorderSize = 1;
            this.btBookLost.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btBookLost.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btBookLost.CheckedForeColor = System.Drawing.Color.White;
            this.btBookLost.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btBookLost.CheckedImage")));
            this.btBookLost.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btBookLost.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btBookLost.FocusedColor = System.Drawing.Color.Empty;
            this.btBookLost.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBookLost.ForeColor = System.Drawing.Color.Black;
            this.btBookLost.Image = null;
            this.btBookLost.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btBookLost.ImageSize = new System.Drawing.Size(30, 30);
            this.btBookLost.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btBookLost.Location = new System.Drawing.Point(573, 69);
            this.btBookLost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBookLost.Name = "btBookLost";
            this.btBookLost.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btBookLost.OnHoverBorderColor = System.Drawing.Color.White;
            this.btBookLost.OnHoverForeColor = System.Drawing.Color.White;
            this.btBookLost.OnHoverImage = null;
            this.btBookLost.OnHoverLineColor = System.Drawing.Color.White;
            this.btBookLost.OnPressedColor = System.Drawing.Color.White;
            this.btBookLost.Radius = 2;
            this.btBookLost.Size = new System.Drawing.Size(71, 33);
            this.btBookLost.TabIndex = 19;
            this.btBookLost.Text = "ປຶ້ມເສຍ";
            this.btBookLost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btBookLost.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btBookLost.Click += new System.EventHandler(this.btBookLost_Click);
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
            this.btsave.Location = new System.Drawing.Point(465, 69);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btsave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btsave.OnHoverImage = null;
            this.btsave.OnHoverLineColor = System.Drawing.Color.White;
            this.btsave.OnPressedColor = System.Drawing.Color.White;
            this.btsave.Radius = 2;
            this.btsave.Size = new System.Drawing.Size(71, 33);
            this.btsave.TabIndex = 21;
            this.btsave.Text = "ບັນທືກ";
            this.btsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 33);
            this.panel1.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(76, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ສົ່ງປຶ້ມ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 41);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvReturnbooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRentId);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btBookLost);
            this.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReturnBooks";
            this.Text = "frmReturnBooks";
            this.Load += new System.EventHandler(this.frmReturnBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnbooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbMemID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaDataGridView dgvReturnbooks;
        private Guna.UI.WinForms.GunaAdvenceButton btBookLost;
        private Guna.UI.WinForms.GunaAdvenceButton btsave;
        private System.Windows.Forms.Label lbRentQty;
        private System.Windows.Forms.Label lbQtyTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPriceTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbEpxireDate;
        private System.Windows.Forms.Label lbDateExpire;
        private System.Windows.Forms.Label lbDateSt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaAdvenceButton btExit;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.Label lbShowBooksExpire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}