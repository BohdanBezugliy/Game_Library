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
            pictureBoxPipeUp.Left -= pipeSpeed;
            pictureBoxPipeDown.Left -= pipeSpeed;
            labelForScore.Text = $"Score: {score}";
            if (pictureBoxPipeUp.Left< -100)
            {
                pictureBoxPipeUp.Left = rand.Next(minValue:700,maxValue:900);
                pictureBoxPipeUp.Height = rand.Next(minValue: 100, maxValue: 350);
            }
            if (pictureBoxPipeDown.Left< -100)
            {
                pictureBoxPipeDown.Left = rand.Next(minValue: 600, maxValue: 800);
                pictureBoxPipeDown.Height = rand.Next(minValue: 100, maxValue: 350);
                score++;
            }
            if(pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeDown.Bounds)|| pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPipeUp.Bounds) || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxGround.Bounds))
            {
                timerGame.Stop();
                Label gameOverLabel = new Label();
                gameOverLabel.Font = new Font("Showcard Gothic",36);
                gameOverLabel.Text = "Game over!";
                gameOverLabel.Size = new Size(350, 50);
                gameOverLabel.Location = new Point((this.Size.Width - 330) / 2, (this.Size.Height - 400) / 2);
                this.Controls.Add(gameOverLabel);
                Button restartButton = new Button();
                restartButton.BackColor = Color.White;
                restartButton.Font = new Font("Arial", 14, FontStyle.Bold);
                restartButton.Text = "Restart";
                restartButton.Size = new Size(150, 60);
                restartButton.Location = new Point((this.Size.Width - 170)/ 2, (this.Size.Height - 80) / 2);
                restartButton.Click += restartButton_Click;
                this.Controls.Add(restartButton);
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormFlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space && timerGame.Enabled)
            {
                pictureBoxPlayer.Top -= gravity * 15;
            }
        }
    }
}
