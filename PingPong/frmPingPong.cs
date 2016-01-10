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
    /* Windows Forms Application game.

    Goal of this game is to get as big score as possible. A player gains points when a ball hits a paddle. All the points are counted towards final score.
    The game is over when the player has lost all lives. A single life is lost when the ball misses the paddle.
    The player can control the paddle with arrow keys. Arrow left for moving the paddle to left and arrow right for moving the paddle to right.*/

    public partial class frmPingPong : Form
    {

        public frmPingPong()
        {
            InitializeComponent();
        }

        // Moving ingame components as structs

        public struct Ball
        {
            public int speedx, speedy, x, y, width, height; // Ball speed in x axis, speed in y axis, position in x axis, position in y axis, width, height

            public Ball( int ballspeedx, int ballspeedy, int ballx, int bally, int ballwidth, int ballheight) // Constructor of the ball
            {
                this.speedx = ballspeedx;
                this.speedy = ballspeedy;
                this.x = ballx;
                this.y = bally;
                this.width = ballwidth;
                this.height = ballheight;
            }
        }

        public struct Paddle
        {
            public int speedx, x, y, width, height; // Paddle speed in x axis, position in x axis, position in y axis, width, height
            public bool moveleft, moveright; // To define which direction the paddle is wanted to move

            public Paddle(int paddlespeedx, int paddlex, int paddley, int paddlewidth, int paddleheight, bool paddlemoveleft, bool paddlemoveright) // Constructor of the paddle
            {
                this.speedx = paddlespeedx;
                this.x = paddlex;
                this.y = paddley;
                this.width = paddlewidth;
                this.height = paddleheight;
                this.moveleft = paddlemoveleft;
                this.moveright = paddlemoveright;
            }
        }

        public struct GameOver
        {
            public int speedx, speedy, x, y, width, height; // GameOver speed in x axis, position in x axis, position in y axis, width, height
            public bool gameover; // For checking is game over

            public GameOver(int gameoverspeedx, int gameoverspeedy, int gameoverx, int gameovery, int gameoverwidth, int gameoverheight, bool isgameover) // Constructor of the gameover
            {
                this.speedx = gameoverspeedx;
                this.speedy = gameoverspeedy;
                this.x = gameoverx;
                this.y = gameovery;
                this.width = gameoverwidth;
                this.height = gameoverheight;
                this.gameover = isgameover;
            }
        }

        // Object declarations

        Ball ball;
        Paddle paddle;
        GameOver gameover;

        // Public and initial variables declarations

        public static int score; // Player score
        public static string[] highscores = new string[10]; // Array for top 10 high scores

        int speed; // Starting speed of the game
        int life; // Number of lives
        int level; // Level and score + difficulty multiplier
        int levelscore; // Level score

        Random r = new Random();

        // Methods

        public void newGame() // This method resets everything to starting position and starts the game from the beginning immediatly. X starting position and direction of the ball is defined randomly.
        {
            
            try {

                // Variable initialization

                speed = 1;
                score = 0;
                life = 3;
                level = speed;
                levelscore = 0;

                // Object initialization

                if (r.Next(2) == 1) // Defining ball starting direction using random
                {
                    ball.speedx = speed;
                }
                else
                {
                    ball.speedx = -speed;
                }

                ball.speedy = speed;
                ball.x = r.Next(1, 591);// Defining ball starting position in x axis using random
                ball.y = 1;
                ball.width = imgBall.Width;
                ball.height = imgBall.Height;
                paddle.speedx = ball.width; // The paddle moves one ball width / gameTimer tick
                paddle.x = 275;
                paddle.y = 385;
                paddle.width = imgPaddle.Width;
                paddle.height = imgPaddle.Height;
                paddle.moveleft = false;
                paddle.moveright = false;
                gameover.speedx = speed;
                gameover.speedy = speed;
                gameover.x = 210;
                gameover.y = 72;
                gameover.width = lblGameOverLabel.Width;
                gameover.height = lblGameOverLabel.Height;
                gameover.gameover = false;

                // Initialization of the ball and the paddle location

                imgPaddle.Location = new Point(paddle.x, paddle.y);
                lblGameOverLabel.Location = new Point(gameover.x, gameover.y);

                // Label initialization

                lblScore.Text = score.ToString();
                lblLife.Text = life.ToString();
                lblLevel.Text = level.ToString();
                lblTipLabel.Text = "";
                lblGameOverLabel.Text = "";
                lblGameOverLabel.BackColor = Color.White;

                // Game timer start

                gameTimer.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        public void movePaddle() // This method sets new coordinates to the paddle in x axis
        {
            try
            {
                if (paddle.moveright && paddle.x < this.pnlPingPong.Width - paddle.width)
                {
                    paddle.x += paddle.speedx;

                    if (lblTipLabel.Text != "") // For removing tip text if the player moves the paddle
                    {
                        lblTipLabel.Text = "";
                    }
                }
                else if (paddle.moveleft && paddle.x > 0)
                {
                    paddle.x += -paddle.speedx;

                    if (lblTipLabel.Text != "") // For removing tip text if the player moves the paddle
                    {
                        lblTipLabel.Text = "";
                    }
                }

                if (paddle.x <= 0) // Freeze the paddle against the left wall if it tries to escape from pnlPingPong 
                {
                    paddle.x = 0;
                }
                else if (paddle.x >= this.pnlPingPong.Width - paddle.width) // Freeze the paddle against the right wall if it tries to escape from pnlPingPong 
                {
                    paddle.x = this.pnlPingPong.Width - paddle.width;
                }
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

        public void gameTimer_Tick(object sender, EventArgs e) // All animation and movement happens in this event
        {
            try
            {
                if (life > 0 || gameover.gameover == false)
                {
                    movePaddle(); // Calling movePaddle method to move the paddle

                    imgPaddle.Location = new Point(paddle.x, paddle.y); // Sets a new point for the paddle every time when gameTimer ticks
                    imgBall.Location = new Point(ball.x, ball.y); // Sets a new point for the ball every time when gameTimer ticks

                    paddle.x = imgPaddle.Location.X;
                    paddle.y = imgPaddle.Location.Y;

                    ball.x += ball.speedx; // Increasing the ball x position every time when gameTimer ticks
                    ball.y += ball.speedy; // Increasing the ball y position every time when gameTimer ticks

                    if (ball.x < 0) // If the ball hits the left wall, change the ball x direction to opposite
                    {
                        ball.x = ball.width; // Bounce

                        if (ball.speedy < 0) // This is to know which direction in y axis we want to bounce the ball...
                        {
                            ball.y += -(ball.height / 2); // ...up...
                        }
                        else
                        {
                            ball.y += (ball.height / 2); // ... or down
                        }

                        ball.speedx = -ball.speedx; // Change direction in x axis
                    }
                    else if (ball.x + ball.width > this.pnlPingPong.Width) // If the ball hits the right wall, change the ball x direction to opposite
                    {
                        ball.x = this.pnlPingPong.Width - ball.width; // Bounce

                        if (ball.speedy < 0) // This is to know which direction in y axis we want to bounce the ball...
                        {
                            ball.y += -(ball.height / 2); // ...up...
                        }
                        else
                        {
                            ball.y += (ball.height / 2); // ... or down
                        }

                        ball.speedx = -ball.speedx; // Change direction in x axis
                    }

                    if (ball.y < 0) // If the ball hits the top, change the ball y direction to opposite
                    {
                        ball.y = ball.height; // Bounce

                        if (ball.speedx < 0) // This is to know which direction in x axis we want to bounce the ball...
                        {
                            ball.x += -(ball.width / 2); // ...left...
                        }
                        else
                        {
                            ball.x += (ball.width / 2); // ... or right
                        }

                        ball.speedy = -ball.speedy; // Change direction in y axis
                    }

                    if ((ball.x + ball.width >= paddle.x && ball.x <= paddle.x + paddle.width) && (ball.y + ball.height >= paddle.y && ball.y <= paddle.y + paddle.height)) // If the ball hits the paddle
                    {
                        ball.y += -(ball.height + paddle.height); // This is for bouncing the ball when it's hitting the paddle to avoid "cheating"

                        if (ball.speedx < 0) // This is to know which direction in x axis we want to bounce the ball...
                        {
                            ball.x += -(ball.width / 2); // ...left...
                        }
                        else
                        {
                            ball.x += (ball.width / 2); // ... or right
                        }

                        if ((level <= 1) || ((level > 1 && level <= 5) && score-levelscore > levelscore+5) || (level > 5 && score - levelscore > levelscore)) // Level change
                        {
                            level++;
                            levelscore = score;
                            lblLevel.Text = level.ToString();
                        }

                        // Level affects speed of the the ball!

                        if (ball.speedx < 0) // This is to know which direction with current level speed in x axis we want to move the ball...
                        {
                            ball.speedx = -level; // ...left...
                        }
                        else
                        {
                            ball.speedx = level; // ... or right
                        }

                        ball.speedy = -level;
                        score += level;
                        lblScore.Text = score.ToString();
                    }
                    else if (ball.y >= this.pnlPingPong.Height + ball.height) // If the paddle misses the ball
                    {
                        life--;
                        lblLife.Text = life.ToString();

                        ball.y = 1; // Ball reset

                        if (score <= 0)
                        {
                            lblTipLabel.Text = "Pro tip: you can move the paddle with left or right arrow keys!";
                        }

                        if (life < 1) // Preparations for game over (all nessessary method calls goes here)
                        {
                            imgPaddle.Location = new Point(275, 600); // Hide the paddle
                            lblGameOverLabel.Location = new Point(gameover.x, gameover.y); // Show game over label
                            lblGameOverLabel.BackColor = Color.Black;

                            lblGameOverLabel.Text = "Game over!";

                            gameover.width = lblGameOverLabel.Width;

                            gameover.gameover = true;

                            readHighScores(); // For updating array highscores before checking

                            if (checkHighScores() < 11) // If player has high enough score for top 10, open frmSaveScore dialog
                            {
                                frmSaveScore frmsavescore = new frmSaveScore();
                                frmsavescore.ShowDialog();
                            }
                        }
                    }
                }
                else if (life <= 0 || gameover.gameover == true) // Game over animation starts when game is over
                {
                    lblGameOverLabel.Location = new Point(gameover.x, gameover.y);

                    gameover.x += gameover.speedx;
                    gameover.y += gameover.speedy;

                    if (gameover.x < 0 || gameover.x > pnlPingPong.Width - gameover.width)
                    {
                        gameover.speedx = -gameover.speedx;
                    }

                    if (gameover.y < 71 || gameover.y > pnlPingPong.Height + gameover.height)
                    {
                        gameover.speedy = -gameover.speedy;
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
                if (gameover.gameover == true)
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
            if (e.KeyCode == Keys.Left)
            {
                paddle.moveleft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle.moveright = true;
            }
        }

        private void frmPingPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.moveleft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle.moveright = false;
            }
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gameover.gameover == true)
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
