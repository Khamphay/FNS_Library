namespace ProjectLibrary
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btSearch = new System.Windows.Forms.Button();
            this.btReservertion = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gunaLinePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaLinePanel1.Controls.Add(this.btSearch);
            this.gunaLinePanel1.Controls.Add(this.btReservertion);
            this.gunaLinePanel1.Controls.Add(this.btLogin);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1165, 548);
            this.gunaLinePanel1.TabIndex = 0;
            this.gunaLinePanel1.Click += new System.EventHandler(this.gunaLinePanel1_Click);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(757, 185);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(134, 131);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "ຄົ້ນຫາ";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btReservertion
            // 
            this.btReservertion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReservertion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btReservertion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btReservertion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.btReservertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservertion.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservertion.Image = ((System.Drawing.Image)(resources.GetObject("btReservertion.Image")));
            this.btReservertion.Location = new System.Drawing.Point(536, 185);
            this.btReservertion.Name = "btReservertion";
            this.btReservertion.Size = new System.Drawing.Size(134, 131);
            this.btReservertion.TabIndex = 3;
            this.btReservertion.Text = "ຈອງປຶ້ມ";
            this.btReservertion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btReservertion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btReservertion.UseVisualStyleBackColor = true;
            this.btReservertion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.Location = new System.Drawing.Point(318, 185);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(134, 131);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Log In";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1165, 548);
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Button btReservertion;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btLogin;
    }
}
