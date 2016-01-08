namespace PingPong
{
    partial class frmAboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductNameLabel = new System.Windows.Forms.Label();
            this.lblVersionLabel = new System.Windows.Forms.Label();
            this.lblCopyrightLabel = new System.Windows.Forms.Label();
            this.lblLicenseLabel = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PingPong.Properties.Resources.jn;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductNameLabel
            // 
            this.lblProductNameLabel.AutoSize = true;
            this.lblProductNameLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameLabel.Location = new System.Drawing.Point(119, 14);
            this.lblProductNameLabel.Name = "lblProductNameLabel";
            this.lblProductNameLabel.Size = new System.Drawing.Size(51, 14);
            this.lblProductNameLabel.TabIndex = 1;
            this.lblProductNameLabel.Text = "PingPong";
            // 
            // lblVersionLabel
            // 
            this.lblVersionLabel.AutoSize = true;
            this.lblVersionLabel.Location = new System.Drawing.Point(119, 37);
            this.lblVersionLabel.Name = "lblVersionLabel";
            this.lblVersionLabel.Size = new System.Drawing.Size(37, 14);
            this.lblVersionLabel.TabIndex = 2;
            this.lblVersionLabel.Text = "v2.0.0";
            // 
            // lblCopyrightLabel
            // 
            this.lblCopyrightLabel.AutoSize = true;
            this.lblCopyrightLabel.Location = new System.Drawing.Point(119, 60);
            this.lblCopyrightLabel.Name = "lblCopyrightLabel";
            this.lblCopyrightLabel.Size = new System.Drawing.Size(121, 14);
            this.lblCopyrightLabel.TabIndex = 3;
            this.lblCopyrightLabel.Text = "© 2016 Jonne Niskanen";
            // 
            // lblLicenseLabel
            // 
            this.lblLicenseLabel.AutoSize = true;
            this.lblLicenseLabel.Location = new System.Drawing.Point(119, 83);
            this.lblLicenseLabel.Name = "lblLicenseLabel";
            this.lblLicenseLabel.Size = new System.Drawing.Size(140, 14);
            this.lblLicenseLabel.TabIndex = 4;
            this.lblLicenseLabel.Text = "Published under MIT license";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(13, 129);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(259, 111);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = resources.GetString("rtbDescription.Text");
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(13, 246);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(259, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmAboutBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblLicenseLabel);
            this.Controls.Add(this.lblCopyrightLabel);
            this.Controls.Add(this.lblVersionLabel);
            this.Controls.Add(this.lblProductNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About PingPong";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductNameLabel;
        private System.Windows.Forms.Label lblVersionLabel;
        private System.Windows.Forms.Label lblCopyrightLabel;
        private System.Windows.Forms.Label lblLicenseLabel;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnOK;
    }
}