namespace ProjectLibrary
{
    partial class frmLocalAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalAddress));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHasUP = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btCacel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.cbHasUP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ປ້ອນຂໍ້ມູນ:";
            // 
            // cbHasUP
            // 
            this.cbHasUP.AutoSize = true;
            this.cbHasUP.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHasUP.Location = new System.Drawing.Point(69, 160);
            this.cbHasUP.Name = "cbHasUP";
            this.cbHasUP.Size = new System.Drawing.Size(217, 36);
            this.cbHasUP.TabIndex = 6;
            this.cbHasUP.Text = "ມີຊື່ ແລະ ລະຫັດຜ່ານ";
            this.cbHasUP.UseVisualStyleBackColor = true;
            this.cbHasUP.CheckedChanged += new System.EventHandler(this.cbHasUP_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "ລະຫັດຜ່ານ (Password)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "ຊື່ (User ID)";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(69, 271);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(320, 42);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Next_Control);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "ຊື່ຖານຂໍ້ມູນ(Database Name)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Server Name";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(69, 213);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(320, 42);
            this.txtUser.TabIndex = 2;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Next_Control);
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.Location = new System.Drawing.Point(69, 116);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(320, 42);
            this.txtDB.TabIndex = 1;
            this.txtDB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Next_Control);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(69, 52);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(320, 42);
            this.txtServer.TabIndex = 0;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Next_Control);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຄຳແນະນຳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. ປ້ອນ Server Name ແລະ ຊື່ຖານຂໍ້ມູນ.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. ປ້ອນຊື່ ແລະ ລະຫັດຜ່ານການເຂົ້າໃຊ້ຖານຂໍ້ມູນ (ຖ້າມີ).";
            // 
            // btConnect
            // 
            this.btConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.btConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnect.Location = new System.Drawing.Point(124, 431);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(90, 39);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCacel
            // 
            this.btCacel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btCacel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.btCacel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btCacel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCacel.Location = new System.Drawing.Point(245, 431);
            this.btCacel.Name = "btCacel";
            this.btCacel.Size = new System.Drawing.Size(90, 39);
            this.btCacel.TabIndex = 5;
            this.btCacel.Text = "Cancel";
            this.btCacel.UseVisualStyleBackColor = true;
            this.btCacel.Click += new System.EventHandler(this.btCacel_Click);
            // 
            // frmLocalAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(475, 476);
            this.Controls.Add(this.btCacel);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(497, 532);
            this.MinimumSize = new System.Drawing.Size(497, 532);
            this.Name = "frmLocalAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalAddress";
            this.Load += new System.EventHandler(this.frmLocalAddress_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCacel;
        private System.Windows.Forms.CheckBox cbHasUP;
    }
}