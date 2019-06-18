using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class mainForm : Form
    { 
        private readonly int leftWall = 20;
        private readonly int rightWall = 312;
        private readonly int topWall = 40;

        private int directionX = -2;
        private int directionY = 2;
        private int speedMultiplyer = 1;

        private int score = 0;
        private int level = 1;

        public mainForm()
        {
            InitializeComponent();
            FormClosing += mainForm_Close;
            KeyDown += new KeyEventHandler(MainForm_KeyDown);
            timer1.Interval = 10;
            timer1.Start();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            else if (timer1.Enabled)
            {
                int x = player.Location.X;
                int y = player.Location.Y;
                if (e.KeyCode == Keys.Right && x <= gameArena.Width - 98) x += 5;
                else if (e.KeyCode == Keys.Left && x >= 20) x -= 5;
                else if (e.KeyCode == Keys.Space && timer1.Enabled) timer1.Stop();
                player.Location = new Point(x, y);
            }
            else if (e.KeyCode == Keys.Space && !timer1.Enabled) timer1.Start();
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)        
        {
            int x = ball.Location.X;
            int y = ball.Location.Y;

            if (y <= topWall)
            {
                directionY = -directionY;
            }
            else if (x <= leftWall || x >= rightWall)
            {
                directionX = -directionX;
            }
            else if (y >= player.Location.Y - 13 &&
                    x <= player.Location.X + 113 &&
                    x >= player.Location.X)
            {
                directionY = -directionY;
                IncrementProgress();
            }
            else if (y >= 533)
            {
                gameOver();
                return;
            }
            MoveBall(x, y);
        }
    
        private void mainForm_Close(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you realy want to quit?\r\nYour score:" + score, "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }   
        }

        private void gameOver()
        {
            timer1.Stop();
            MessageBox.Show("Game over!\r\nYour score was:\r\n" + score);
            speedMultiplyer = 1;
            level = 1;
            score = 0;
            scoreBox.Text = score.ToString();
            levelText.Text = level.ToString();
            ball.Location = new Point(100, 50);
          
            timer1.Start();
        }

        private void MoveBall(int x, int y)
        {
            ball.Location = new Point(x + (directionX*speedMultiplyer), y + (directionY*speedMultiplyer));
        }

        private void IncrementProgress()
        {
            score += 1;
            scoreBox.Text = score.ToString();
            if (score % 5 == 0)
            {
                speedMultiplyer++;
                level++;
                levelText.Text = level.ToString();
            }
        }
    }
}
