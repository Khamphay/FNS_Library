namespace ProjectLibrary
{
    partial class frmSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.treeView_Books = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
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
            this.panel2.Size = new System.Drawing.Size(1000, 34);
            this.panel2.TabIndex = 59;
            this.panel2.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(82, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "ຄົ້ນຫາ";
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
            this.btExit.Location = new System.Drawing.Point(977, 3);
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
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(444, 58);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 35);
            this.btSearch.TabIndex = 60;
            this.btSearch.Text = "ຄົ້ນຫາ";
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(132, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 35);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.Click += new System.EventHandler(this.btSearch_Click_1);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // treeView_Books
            // 
            this.treeView_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_Books.BackColor = System.Drawing.Color.Silver;
            this.treeView_Books.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView_Books.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_Books.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.treeView_Books.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(206)))));
            this.treeView_Books.Location = new System.Drawing.Point(132, 99);
            this.treeView_Books.Margin = new System.Windows.Forms.Padding(6);
            this.treeView_Books.Name = "treeView_Books";
            this.treeView_Books.Size = new System.Drawing.Size(697, 423);
            this.treeView_Books.TabIndex = 62;
            this.treeView_Books.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.treeView_Books);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSearch";
            this.Text = "frmShearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.Click += new System.EventHandler(this.btSearch_Click_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaAdvenceButton btExit;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TreeView treeView_Books;
    }
}