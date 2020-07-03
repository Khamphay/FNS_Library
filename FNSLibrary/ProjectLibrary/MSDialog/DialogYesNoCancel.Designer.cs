namespace ProjectLibrary.MSDialog
{
    partial class DialogYesNoCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogYesNoCancel));
            this.btNo = new System.Windows.Forms.Button();
            this.btYes = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.Location = new System.Drawing.Point(289, 126);
            this.btNo.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(58, 31);
            this.btNo.TabIndex = 5;
            this.btNo.Text = "&No";
            this.btNo.UseVisualStyleBackColor = true;
            // 
            // btYes
            // 
            this.btYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btYes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYes.Location = new System.Drawing.Point(218, 126);
            this.btYes.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(58, 31);
            this.btYes.TabIndex = 6;
            this.btYes.Text = "&Yes";
            this.btYes.UseVisualStyleBackColor = true;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Saysettha OT", 9F);
            this.lbMessage.Location = new System.Drawing.Point(63, 43);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(46, 19);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.Text = "ສະແດງ";
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(2, 24);
            this.picIcon.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(51, 51);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(361, 126);
            this.btCancel.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(58, 31);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // DialogYesNoCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(431, 169);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(447, 208);
            this.Name = "DialogYesNoCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogYesNoCancel";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btCancel;
    }
}