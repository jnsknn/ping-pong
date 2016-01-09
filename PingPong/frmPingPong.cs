using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PingPong
{
    /* This program is a game which allow the player to return the ball. If the ball passes the paddle, player will lose a life.
        When lives are less than zero, game is over */

    public partial class frmPingPong : Form
    {
        // Initial variables

        int speed; // Ball speed
        int bdx; // Ball movement in x axis
        int bdy; // Ball movement in y axis
        int bx; // Ball x position
        int by; // Ball y position
        int px; // Paddle x position
        int py; // Paddle y position
        int lblgodx; // Game over label movement in x axis
        int lblgody; // Game over label movement in y axis
        int lblgox; // Game over label x position
        int lblgoy; // Game over label y position
        public static int score; // Player score
        public static string[] highscores = new string[10]; // Array for top 10 high scores
        int life; // Number of lives
        int level; // Level and score + difficulty multiplier
        int levelscore; // Level score

        bool hit;
        bool gameover;

        Random r = new Random();

        // Methods

        public frmPingPong()
        {
            InitializeComponent();
        }

        public void newGame()
        {
            // This method resets everything to starting position and starts the game from the beginning immediatly. The balls x starting position and direction is defined randomly.
            try {

                speed = 1;

                if (r.Next(2) == 1)
                {
                    bdx = speed;
                }
                else
                {
                    bdx = -speed;
                }

                bdy = speed;
                bx = r.Next(1, 591);
                by = 1;
                px = 275;
                py = 385;
                lblgodx = 1;
                lblgody = 1;
                lblgox = 210;
                lblgoy = 72;
                score = 0;
                life = 3;
                level = 1;
                levelscore = 0;

                hit = false;
                gameover = false;

                imgPaddle.Location = new Point(px, py);
                lblGameOverLabel.Location = new Point(lblgox, lblgoy);

                lblScore.Text = score.ToString();
                lblLife.Text = life.ToString();
                lblLevel.Text = level.ToString();
                lblTipLabel.Text = "";
                lblGameOverLabel.Text = "";
                lblGameOverLabel.BackColor = Color.White;

                gameTimer.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        public static void readHighScores() // For reading high scores from file to array
        {
            try
            {
                if (File.Exists("highscores"))
                {
                    highscores = File.ReadAllLines("highscores");
                }
                else
                {
                    createHighScores();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        public static void saveHighScores(string playername, int playerscore) // For saving new high score to file
        {
            try
            {
                int rank = checkHighScores(); // For getting player rank
                int i = 10;

                for (i=10;i >= rank;i--)
                {
                    if (i == rank) // If player rank matches index number...
                    {
                        highscores[rank - 1] = playerscore.ToString() + ";" + playername; // ...then replace whole string with a new one
                    }
                    else // Else, drop other ranks in top 10 down by one
                    {
                        highscores[i - 1] = highscores[i - 2];
                    }
                    
                }
                
                File.WriteAllLines("highscores", highscores);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        private static void createHighScores() // For creating high scores file
        {
            try
            {
                string[] generatescores = {
                    "100;AAA",
                    "90;BBB",
                    "80;CCC",
                    "70;DDD",
                    "60;EEE",
                    "50;FFF",
                    "40;GGG",
                    "30;HHH",
                    "20;III",
                    "10;JJJ"
                };

                File.WriteAllLines("highscores", generatescores);

                readHighScores();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }
        public static int checkHighScores() // For checking if player has enough points to make it in top 10
        {
            int i = 11; // Counter for identifying players rank in top 10
            string[] highscorelinesplit = new string[2];
            int scoreline;

            foreach (string highscoreline in highscores) // For iterating all high scores saved to array from file in readHighScores()
            {
                highscorelinesplit = highscoreline.Split(';'); // Takes only score part of the string for later comparing purposes
                scoreline = Int32.Parse(highscorelinesplit[0]);

                if (scoreline < score)
                {
                    i--;
                }
            }

            return i;
        }

        // Events

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e) // All animation and movement happens in this event
        {
            try
            {
                if (life > 0 || gameover == false)
                {
                    imgPaddle.Location = new Point(px, py); // Sets a new point for the paddle every time when gameTimer ticks
                    imgBall.Location = new Point(bx, by); // Sets a new point for the ball every time when gameTimer ticks

                    px = imgPaddle.Location.X;
                    py = imgPaddle.Location.Y;

                    if (!hit)
                    {
                        bx += bdx; // Increasing the ball x position every time when gameTimer ticks
                        by += bdy; // Increasing the ball y position every time when gameTimer ticks
                    }

                    if (bx < -10) // If the ball hits the left wall, change the ball x direction to opposite
                    {
                        bx = imgBall.Width; // Bounce

                        if (bdy < 0) // This is to know which direction in y axis we want to bounce the ball...
                        {
                            by += -(imgBall.Height / 2); // ...left...
                        }
                        else
                        {
                            by += (imgBall.Height / 2); // ... or right
                        }

                        bdx = -bdx;
                    }
                    else if (bx + 10 > this.pnlPingPong.Width + 10) // If the ball hits the right wall, change the ball x direction to opposite
                    {
                        bx = this.pnlPingPong.Width - imgBall.Width; // Bounce

                        if (bdy < 0) // This is to know which direction in y axis we want to bounce the ball...
                        {
                            by += -(imgBall.Height / 2); // ...left...
                        }
                        else
                        {
                            by += (imgBall.Height / 2); // ... or right
                        }

                        bdx = -bdx;
                    }

                    if (by < -10) // If the ball hits the top, change the ball y direction to opposite
                    {
                        by = imgBall.Height; // Bounce

                        if (bdx < 0) // This is to know which direction in x axis we want to bounce the ball...
                        {
                            bx += -(imgBall.Width / 2); // ...left...
                        }
                        else
                        {
                            bx += (imgBall.Width / 2); // ... or right
                        }

                        bdy = -bdy;
                    }

                    if ((bx + 10 >= px && bx <= px + 50) && (by + 10 >= py && by <= py + 10)) // If the ball hits the paddle
                    {
                        hit = true;

                        by += -(imgBall.Height + imgPaddle.Height); // This is for bouncing the ball when it's hitting the paddle to avoid "cheating"

                        if (bdx < 0) // This is to know which direction in x axis we want to bounce the ball...
                        {
                            bx += -(imgBall.Width / 2); // ...left...
                        }
                        else
                        {
                            bx += (imgBall.Width / 2); // ... or right
                        }

                        if ((level <= 1) || ((level > 1 && level <= 5) && score-levelscore > levelscore+5) || (level > 5 && score - levelscore > levelscore)) // Level change
                        {
                            level++;
                            levelscore = score;
                            lblLevel.Text = level.ToString();
                        }

                        if (bdx < 0) // This is to know which direction with current level speed in x axis we want to move the ball...
                        {
                            bdx = -level; // ...left...
                        }
                        else
                        {
                            bdx = level; // ... or right
                        }

                        bdy = -level;
                        score += level;
                        lblScore.Text = score.ToString();
                    }
                    else if (by >= this.pnlPingPong.Height + 10) // If the paddle misses the ball
                    {
                        hit = false;
                        life--;
                        lblLife.Text = life.ToString();
                        by = 1;

                        if (score <= 0)
                        {
                            lblTipLabel.Text = "Pro tip: you can move the paddle with left or right arrow keys!";
                        }

                        if (life < 1) // Preparations for game over (all nessessary method calls goes here)
                        {
                            imgPaddle.Location = new Point(275, 600); // Hide the paddle
                            lblGameOverLabel.Location = new Point(lblgox, lblgoy); // Show game over label
                            lblGameOverLabel.BackColor = Color.Black;

                            lblGameOverLabel.Text = "Game over!";

                            gameover = true;

                            readHighScores(); // For updating array highscores before checking

                            if (checkHighScores() < 11) // If player has high enough score for top 10, open frmSaveScore dialog
                            {
                                frmSaveScore frmsavescore = new frmSaveScore();
                                frmsavescore.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        hit = false;
                    }
                }
                else if (life <= 0 || gameover) // Game over animation starts when game is over
                {
                    lblGameOverLabel.Location = new Point(lblgox, lblgoy);

                    lblgox += lblgodx;
                    lblgoy += lblgody;

                    if (lblgox < 0 || lblgox > pnlPingPong.Width - lblGameOverLabel.Width)
                    {
                        lblgodx = -lblgodx;
                    }

                    if (lblgoy < 71 || lblgoy > pnlPingPong.Height + lblGameOverLabel.Height)
                    {
                        lblgody = -lblgody;
                    }
                }

                this.Invalidate();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gameover)
                {
                    DialogResult dr = new DialogResult();
                    frmAboutBox frmaboutbox = new frmAboutBox();
                    dr = frmaboutbox.ShowDialog();
                }
                else
                {
                    gameTimer.Stop();

                    DialogResult dr = new DialogResult();
                    frmAboutBox frmaboutbox = new frmAboutBox();
                    dr = frmaboutbox.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        gameTimer.Start();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Right && px < this.pnlPingPong.Width - 50)
                {
                    px += level * 10; // Speed of the paddle is relative to level

                    if (lblTipLabel.Text != "") // For removing tip text if the player moves the paddle
                    {
                        lblTipLabel.Text = "";
                    }
                }
                else if (e.KeyCode == Keys.Left && px > 0)
                {
                    px += -level * 10; // Speed of the paddle is relative to level

                    if (lblTipLabel.Text != "") // For removing tip text if the player moves the paddle
                    {
                        lblTipLabel.Text = "";
                    }
                }

                if (px <= 0) // Freeze the paddle against the left wall if it tries to escape from pnlPingPong 
                {
                    px = 0;
                }
                else if (px >= this.pnlPingPong.Width - 50) // Freeze the paddle against the right wall if it tries to escape from pnlPingPong 
                {
                    px = this.pnlPingPong.Width - 50;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gameover)
                {
                    DialogResult dr = new DialogResult();
                    frmHighScores frmhighscores = new frmHighScores();
                    dr = frmhighscores.ShowDialog();
                }
                else
                {
                    gameTimer.Stop();

                    DialogResult dr = new DialogResult();
                    frmHighScores frmhighscores = new frmHighScores();
                    dr = frmhighscores.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        gameTimer.Start();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }
    }
}
