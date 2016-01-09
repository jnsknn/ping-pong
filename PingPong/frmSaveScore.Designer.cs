namespace PingPong
{
    partial class frmSaveScore
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
            this.lblNewHighScoreLabel = new System.Windows.Forms.Label();
            this.lblNewHighScoreInfoLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNameTextBox = new System.Windows.Forms.TextBox();
            this.lblCurrentScoreLabel = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.lblRankLabel = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewHighScoreLabel
            // 
            this.lblNewHighScoreLabel.AutoSize = true;
            this.lblNewHighScoreLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHighScoreLabel.Location = new System.Drawing.Point(13, 14);
            this.lblNewHighScoreLabel.Name = "lblNewHighScoreLabel";
            this.lblNewHighScoreLabel.Size = new System.Drawing.Size(239, 14);
            this.lblNewHighScoreLabel.TabIndex = 0;
            this.lblNewHighScoreLabel.Text = "Congratulations! You made it to the top 10!";
            // 
            // lblNewHighScoreInfoLabel
            // 
            this.lblNewHighScoreInfoLabel.AutoSize = true;
            this.lblNewHighScoreInfoLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHighScoreInfoLabel.Location = new System.Drawing.Point(13, 29);
            this.lblNewHighScoreInfoLabel.Name = "lblNewHighScoreInfoLabel";
            this.lblNewHighScoreInfoLabel.Size = new System.Drawing.Size(237, 28);
            this.lblNewHighScoreInfoLabel.TabIndex = 1;
            this.lblNewHighScoreInfoLabel.Text = "Enter your name and press save button to save\r\nyour score. Press cancel otherwise" +
    ".";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(72, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtNameTextBox
            // 
            this.txtNameTextBox.Location = new System.Drawing.Point(72, 101);
            this.txtNameTextBox.MaxLength = 16;
            this.txtNameTextBox.Name = "txtNameTextBox";
            this.txtNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.txtNameTextBox.TabIndex = 6;
            // 
            // lblCurrentScoreLabel
            // 
            this.lblCurrentScoreLabel.AutoSize = true;
            this.lblCurrentScoreLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreLabel.Location = new System.Drawing.Point(13, 65);
            this.lblCurrentScoreLabel.Name = "lblCurrentScoreLabel";
            this.lblCurrentScoreLabel.Size = new System.Drawing.Size(50, 18);
            this.lblCurrentScoreLabel.TabIndex = 7;
            this.lblCurrentScoreLabel.Text = "Score";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(69, 65);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(16, 17);
            this.lblCurrentScore.TabIndex = 8;
            this.lblCurrentScore.Text = "0";
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHeader.Location = new System.Drawing.Point(13, 101);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(48, 18);
            this.lblNameHeader.TabIndex = 11;
            this.lblNameHeader.Text = "Name";
            // 
            // lblRankLabel
            // 
            this.lblRankLabel.AutoSize = true;
            this.lblRankLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankLabel.Location = new System.Drawing.Point(13, 83);
            this.lblRankLabel.Name = "lblRankLabel";
            this.lblRankLabel.Size = new System.Drawing.Size(44, 18);
            this.lblRankLabel.TabIndex = 12;
            this.lblRankLabel.Text = "Rank";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(69, 83);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(16, 17);
            this.lblRank.TabIndex = 13;
            this.lblRank.Text = "0";
            // 
            // frmSaveScore
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.ControlBox = false;
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblRankLabel);
            this.Controls.Add(this.lblNameHeader);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblCurrentScoreLabel);
            this.Controls.Add(this.txtNameTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewHighScoreInfoLabel);
            this.Controls.Add(this.lblNewHighScoreLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveScore";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New High Score";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSaveScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewHighScoreLabel;
        private System.Windows.Forms.Label lblNewHighScoreInfoLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNameTextBox;
        private System.Windows.Forms.Label lblCurrentScoreLabel;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblRankLabel;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblNameHeader;
    }
}