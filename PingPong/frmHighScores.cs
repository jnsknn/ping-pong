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
    public partial class frmHighScores : Form
    {
        public frmHighScores()
        {
            InitializeComponent();
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 1; // Ranks starting from first
                string[] splitscore = new string[2];
                frmPingPong.readHighScores();

                foreach (string line in frmPingPong.highscores) // Writing high scores to table (there has to be smarter way to do this but at least this works)
                {
                    splitscore = line.Split(';');

                    if (i == 1)
                    {
                        lblScore1.Text = splitscore[0];
                        lblName1.Text = splitscore[1];
                    }
                    else if (i == 2)
                    {
                        lblScore2.Text = splitscore[0];
                        lblName2.Text = splitscore[1];
                    }
                    else if(i == 3)
                    {
                        lblScore3.Text = splitscore[0];
                        lblName3.Text = splitscore[1];
                    }
                    else if(i == 4)
                    {
                        lblScore4.Text = splitscore[0];
                        lblName4.Text = splitscore[1];
                    }
                    else if(i == 5)
                    {
                        lblScore5.Text = splitscore[0];
                        lblName5.Text = splitscore[1];
                    }
                    else if(i == 6)
                    {
                        lblScore6.Text = splitscore[0];
                        lblName6.Text = splitscore[1];
                    }
                    else if(i == 7)
                    {
                        lblScore7.Text = splitscore[0];
                        lblName7.Text = splitscore[1];
                    }
                    else if(i == 8)
                    {
                        lblScore8.Text = splitscore[0];
                        lblName8.Text = splitscore[1];
                    }
                    else if (i == 9)
                    {
                        lblScore9.Text = splitscore[0];
                        lblName9.Text = splitscore[1];
                    }
                    else if (i == 10)
                    {
                        lblScore10.Text = splitscore[0];
                        lblName10.Text = splitscore[1];
                    }

                    i++;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc + "\n" + "\n" + "Go to https://github.com/jnsknn/ping-pong/issues and see if there is an issue about this bug. If not, create a new issue or contact me via email.");
            }
        }
    }
}
