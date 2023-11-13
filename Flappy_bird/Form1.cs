using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class FormFlappyBird : Form
    {
        int gravity = 5;
        int pipeSpeed = 8;
        int score = 0;
        Random rand = new Random();
        public FormFlappyBird()
        {
            InitializeComponent();
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBoxPlayer.Top += gravity;
            pictureBoxPipeUp1.Left -= pipeSpeed;
            pictureBoxPipeDown1.Left -= pipeSpeed;
            pictureBoxPipeUp2.Left -= pipeSpeed;
            pictureBoxPipeDown2.Left -= pipeSpeed;
            pictureBoxPipeUp3.Left -= pipeSpeed;
            pictureBoxPipeDown3.Left -= pipeSpeed;
            pictureBoxPipeUp4.Left -= pipeSpeed;
            pictureBoxPipeDown4.Left -= pipeSpeed;
            labelForScore.Text = $"Score: {score}";
            if (pictureBoxPipeUp1.Left < -100)
            {
                pictureBoxPipeUp1.Left = this.Width + 500;
                pictureBoxPipeUp1.Location = new Point(pictureBoxPipeUp1.Location.X, rand.Next(-134, -5));
                pictureBoxPipeDown1.Left = this.Width + 500;
                pictureBoxPipeDown1.Location = new Point(pictureBoxPipeDown1.Location.X, rand.Next(402, 503));
                score++;
            }
            if (pictureBoxPipeUp2.Left < -100)
            {
                pictureBoxPipeUp2.Left = pictureBoxPipeUp1.Left + 500;
                pictureBoxPipeUp2.Location = new Point(pictureBoxPipeUp1.Location.X + 300, rand.Next(-134, -5));
                pictureBoxPipeDown2.Left = pictureBoxPipeUp1.Left + 500;
                pictureBoxPipeDown2.Location = new Point(pictureBoxPipeDown1.Location.X + 300, rand.Next(402, 503));
                score++;
            }
            if (pictureBoxPipeUp3.Left < -100)
            {
                pictureBoxPipeUp3.Left = pictureBoxPipeUp2.Left + 500;
                pictureBoxPipeUp3.Location = new Point(pictureBoxPipeUp2.Location.X + 400, rand.Next(-134, -5));
                pictureBoxPipeDown3.Left = pictureBoxPipeUp2.Left + 500;
                pictureBoxPipeDown3.Location = new Point(pictureBoxPipeDown2.Location.X + 400, rand.Next(402, 503));
                score++;
            }
            if (pictureBoxPipeUp4.Left < -100)
            {
                pictureBoxPipeUp4.Left = pictureBoxPipeUp3.Left + 500;
                pictureBoxPipeUp4.Location = new Point(pictureBoxPipeUp3.Location.X + 500, rand.Next(-134, -5));
                pictureBoxPipeDown4.Left = pictureBoxPipeUp3.Left + 500;
                pictureBoxPipeDown4.Location = new Point(pictureBoxPipeDown3.Location.X + 500, rand.Next(402, 503));
                score++;
            }
            if (pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeDown1.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeUp1.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxGround.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeDown2.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeUp2.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeDown3.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeUp3.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeDown4.Bounds)
                || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeUp4.Bounds))
            {
                timerGame.Stop();
                exitButton.Visible = true;
                exitButton.Enabled = true;
                pictureBoxGameOver.Visible = true;
                restartButton.Visible=true;
                restartButton.Enabled = true;
                restartButton.BringToFront();
            }
        }

        private void FormFlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && timerGame.Enabled)
            {
                pictureBoxPlayer.Top -= gravity * 15;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = true;
            StartButton.Visible = false;
            exitButton.Visible = false;
            exitButton.Enabled= false;
            pictureBoxNameOfGame.Visible = false;
            restartButton.Enabled = false;
            restartButton.Visible= false;
            labelForScore.Visible = true;
            labelForScore.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
