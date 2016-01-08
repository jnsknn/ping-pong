using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmSaveScore : Form
    {
        // Initial variables
        string savename;

        // Methods
        public frmSaveScore()
        {
            InitializeComponent();
        }

        // Events
        private void frmSaveScore_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                lblCurrentScore.Text = frmPingPong.score.ToString();

                frmPingPong.readHighScores();

                foreach (string highscoreline in frmPingPong.highscores)
                {
                    if (i < 9)
                    {
                        rtbHighScores.Text += highscoreline + "\n";
                    }
                    else
                    {
                        rtbHighScores.Text += highscoreline;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                savename = string.Concat(txtNameTextBox.Text.Where(char.IsLetterOrDigit)); // This removes every char from string that is not letter or digit
                frmPingPong.saveHighScores(savename, frmPingPong.score);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }
    }
}
