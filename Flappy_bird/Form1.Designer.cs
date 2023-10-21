namespace Flappy_bird
{
    partial class FormFlappyBird
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
            this.labelForScore = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForScore
            // 
            this.labelForScore.AutoSize = true;
            this.labelForScore.BackColor = System.Drawing.Color.Transparent;
            this.labelForScore.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForScore.Location = new System.Drawing.Point(12, 9);
            this.labelForScore.Name = "labelForScore";
            this.labelForScore.Size = new System.Drawing.Size(226, 60);
            this.labelForScore.TabIndex = 4;
            this.labelForScore.Text = "Score: 0";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.BackgroundImage = global::Flappy_bird.Properties.Resources.Ground1;
            this.pictureBoxGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGround.Location = new System.Drawing.Point(-1, 614);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(634, 50);
            this.pictureBoxGround.TabIndex = 3;
            this.pictureBoxGround.TabStop = false;
            // 
            // pictureBoxPipeUp
            // 
            this.pictureBoxPipeUp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeUp.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeUp;
            this.pictureBoxPipeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeUp.Location = new System.Drawing.Point(494, -2);
            this.pictureBoxPipeUp.Name = "pictureBoxPipeUp";
            this.pictureBoxPipeUp.Size = new System.Drawing.Size(100, 107);
            this.pictureBoxPipeUp.TabIndex = 1;
            this.pictureBoxPipeUp.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImage = global::Flappy_bird.Properties.Resources.Bird;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(121, 204);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxPipeDown
            // 
            this.pictureBoxPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeDown.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeDown.Location = new System.Drawing.Point(505, 503);
            this.pictureBoxPipeDown.Name = "pictureBoxPipeDown";
            this.pictureBoxPipeDown.Size = new System.Drawing.Size(100, 161);
            this.pictureBoxPipeDown.TabIndex = 2;
            this.pictureBoxPipeDown.TabStop = false;
            // 
            // FormFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(633, 663);
            this.Controls.Add(this.labelForScore);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxPipeUp);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxPipeDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFlappyBird";
            this.Text = "Flappy bird";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelForScore;
        private System.Windows.Forms.Timer timerGame;
        public System.Windows.Forms.PictureBox pictureBoxPlayer;
        public System.Windows.Forms.PictureBox pictureBoxPipeUp;
        public System.Windows.Forms.PictureBox pictureBoxPipeDown;
        public System.Windows.Forms.PictureBox pictureBoxGround;
    }
}

