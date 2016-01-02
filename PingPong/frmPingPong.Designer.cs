﻿namespace PingPong
{
    partial class frmPingPong
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
            this.pnlPingPong = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLivesLabel = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOverLabel = new System.Windows.Forms.Label();
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.imgPaddle = new System.Windows.Forms.PictureBox();
            this.pnlPingPong.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPingPong
            // 
            this.pnlPingPong.BackColor = System.Drawing.Color.Black;
            this.pnlPingPong.Controls.Add(this.imgBall);
            this.pnlPingPong.Controls.Add(this.imgPaddle);
            this.pnlPingPong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPingPong.Location = new System.Drawing.Point(0, 61);
            this.pnlPingPong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPingPong.Name = "pnlPingPong";
            this.pnlPingPong.Size = new System.Drawing.Size(600, 400);
            this.pnlPingPong.TabIndex = 0;
            this.pnlPingPong.MouseEnter += new System.EventHandler(this.pnlPingPong_MouseEnter);
            this.pnlPingPong.MouseLeave += new System.EventHandler(this.pnlPingPong_MouseLeave);
            this.pnlPingPong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPingPong_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "About PingPong";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblLivesLabel
            // 
            this.lblLivesLabel.AutoSize = true;
            this.lblLivesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesLabel.Location = new System.Drawing.Point(12, 40);
            this.lblLivesLabel.Name = "lblLivesLabel";
            this.lblLivesLabel.Size = new System.Drawing.Size(50, 19);
            this.lblLivesLabel.TabIndex = 2;
            this.lblLivesLabel.Text = "Lives";
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLabel.Location = new System.Drawing.Point(95, 40);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(54, 19);
            this.lblScoreLabel.TabIndex = 3;
            this.lblScoreLabel.Text = "Score";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.Location = new System.Drawing.Point(68, 40);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(17, 18);
            this.lblLife.TabIndex = 4;
            this.lblLife.Text = "3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(155, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(17, 18);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblGameOverLabel
            // 
            this.lblGameOverLabel.AutoSize = true;
            this.lblGameOverLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverLabel.ForeColor = System.Drawing.Color.White;
            this.lblGameOverLabel.Location = new System.Drawing.Point(210, 24);
            this.lblGameOverLabel.Name = "lblGameOverLabel";
            this.lblGameOverLabel.Size = new System.Drawing.Size(0, 34);
            this.lblGameOverLabel.TabIndex = 2;
            this.lblGameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBall
            // 
            this.imgBall.Image = global::PingPong.Properties.Resources.ball;
            this.imgBall.Location = new System.Drawing.Point(1, 1);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(10, 10);
            this.imgBall.TabIndex = 1;
            this.imgBall.TabStop = false;
            // 
            // imgPaddle
            // 
            this.imgPaddle.Image = global::PingPong.Properties.Resources.paddle;
            this.imgPaddle.Location = new System.Drawing.Point(275, 385);
            this.imgPaddle.Name = "imgPaddle";
            this.imgPaddle.Size = new System.Drawing.Size(50, 10);
            this.imgPaddle.TabIndex = 0;
            this.imgPaddle.TabStop = false;
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 461);
            this.Controls.Add(this.lblGameOverLabel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.lblLivesLabel);
            this.Controls.Add(this.pnlPingPong);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPingPong";
            this.Text = "PingPong";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
            this.pnlPingPong.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPingPong;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblLivesLabel;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox imgPaddle;
        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOverLabel;
    }
}

