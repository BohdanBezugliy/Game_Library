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
            this.StartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxNameOfGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp4 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameOfGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForScore
            // 
            this.labelForScore.AutoSize = true;
            this.labelForScore.BackColor = System.Drawing.Color.Transparent;
            this.labelForScore.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForScore.Location = new System.Drawing.Point(16, 11);
            this.labelForScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForScore.Name = "labelForScore";
            this.labelForScore.Size = new System.Drawing.Size(226, 60);
            this.labelForScore.TabIndex = 4;
            this.labelForScore.Text = "Score: 0";
            this.labelForScore.Visible = false;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(386, 431);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(183, 88);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(386, 549);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 88);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.BackgroundImage = global::Flappy_bird.Properties.Resources.OIP__6__PhotoRoom_png_PhotoRoom;
            this.pictureBoxGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGameOver.Location = new System.Drawing.Point(268, 180);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(416, 313);
            this.pictureBoxGameOver.TabIndex = 14;
            this.pictureBoxGameOver.TabStop = false;
            this.pictureBoxGameOver.Visible = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImage = global::Flappy_bird.Properties.Resources.Bird;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(323, 231);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(100, 62);
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxNameOfGame
            // 
            this.pictureBoxNameOfGame.BackgroundImage = global::Flappy_bird.Properties.Resources.Знімок_екрана_2023_10_29_195531_PhotoRoom_png_PhotoRoom;
            this.pictureBoxNameOfGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNameOfGame.Location = new System.Drawing.Point(268, 251);
            this.pictureBoxNameOfGame.Name = "pictureBoxNameOfGame";
            this.pictureBoxNameOfGame.Size = new System.Drawing.Size(416, 158);
            this.pictureBoxNameOfGame.TabIndex = 11;
            this.pictureBoxNameOfGame.TabStop = false;
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.BackgroundImage = global::Flappy_bird.Properties.Resources.Ground1;
            this.pictureBoxGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGround.Location = new System.Drawing.Point(-1, 756);
            this.pictureBoxGround.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(1966, 62);
            this.pictureBoxGround.TabIndex = 3;
            this.pictureBoxGround.TabStop = false;
            // 
            // pictureBoxPipeDown1
            // 
            this.pictureBoxPipeDown1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeDown1.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipeDown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeDown1.Location = new System.Drawing.Point(840, 614);
            this.pictureBoxPipeDown1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeDown1.Name = "pictureBoxPipeDown1";
            this.pictureBoxPipeDown1.Size = new System.Drawing.Size(133, 322);
            this.pictureBoxPipeDown1.TabIndex = 2;
            this.pictureBoxPipeDown1.TabStop = false;
            // 
            // pictureBoxPipeDown3
            // 
            this.pictureBoxPipeDown3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeDown3.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipeDown3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeDown3.Location = new System.Drawing.Point(1373, 511);
            this.pictureBoxPipeDown3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeDown3.Name = "pictureBoxPipeDown3";
            this.pictureBoxPipeDown3.Size = new System.Drawing.Size(133, 322);
            this.pictureBoxPipeDown3.TabIndex = 10;
            this.pictureBoxPipeDown3.TabStop = false;
            // 
            // pictureBoxPipeDown2
            // 
            this.pictureBoxPipeDown2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeDown2.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipeDown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeDown2.Location = new System.Drawing.Point(1107, 534);
            this.pictureBoxPipeDown2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeDown2.Name = "pictureBoxPipeDown2";
            this.pictureBoxPipeDown2.Size = new System.Drawing.Size(133, 322);
            this.pictureBoxPipeDown2.TabIndex = 8;
            this.pictureBoxPipeDown2.TabStop = false;
            // 
            // pictureBoxPipeUp3
            // 
            this.pictureBoxPipeUp3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeUp3.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeUp;
            this.pictureBoxPipeUp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeUp3.Location = new System.Drawing.Point(1373, -52);
            this.pictureBoxPipeUp3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeUp3.Name = "pictureBoxPipeUp3";
            this.pictureBoxPipeUp3.Size = new System.Drawing.Size(133, 338);
            this.pictureBoxPipeUp3.TabIndex = 6;
            this.pictureBoxPipeUp3.TabStop = false;
            // 
            // pictureBoxPipeUp2
            // 
            this.pictureBoxPipeUp2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeUp2.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeUp;
            this.pictureBoxPipeUp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeUp2.Location = new System.Drawing.Point(1107, -140);
            this.pictureBoxPipeUp2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeUp2.Name = "pictureBoxPipeUp2";
            this.pictureBoxPipeUp2.Size = new System.Drawing.Size(133, 338);
            this.pictureBoxPipeUp2.TabIndex = 5;
            this.pictureBoxPipeUp2.TabStop = false;
            // 
            // pictureBoxPipeUp1
            // 
            this.pictureBoxPipeUp1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeUp1.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeUp;
            this.pictureBoxPipeUp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeUp1.Location = new System.Drawing.Point(840, -140);
            this.pictureBoxPipeUp1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeUp1.Name = "pictureBoxPipeUp1";
            this.pictureBoxPipeUp1.Size = new System.Drawing.Size(133, 361);
            this.pictureBoxPipeUp1.TabIndex = 1;
            this.pictureBoxPipeUp1.TabStop = false;
            // 
            // pictureBoxPipeDown4
            // 
            this.pictureBoxPipeDown4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeDown4.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipeDown4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeDown4.Location = new System.Drawing.Point(1640, 534);
            this.pictureBoxPipeDown4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeDown4.Name = "pictureBoxPipeDown4";
            this.pictureBoxPipeDown4.Size = new System.Drawing.Size(133, 322);
            this.pictureBoxPipeDown4.TabIndex = 9;
            this.pictureBoxPipeDown4.TabStop = false;
            // 
            // pictureBoxPipeUp4
            // 
            this.pictureBoxPipeUp4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeUp4.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeUp;
            this.pictureBoxPipeUp4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipeUp4.Location = new System.Drawing.Point(1640, -52);
            this.pictureBoxPipeUp4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPipeUp4.Name = "pictureBoxPipeUp4";
            this.pictureBoxPipeUp4.Size = new System.Drawing.Size(133, 361);
            this.pictureBoxPipeUp4.TabIndex = 7;
            this.pictureBoxPipeUp4.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.Location = new System.Drawing.Point(386, 431);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(183, 88);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click_1);
            // 
            // FormFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 816);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBoxNameOfGame);
            this.Controls.Add(this.labelForScore);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxPipeDown1);
            this.Controls.Add(this.pictureBoxPipeDown3);
            this.Controls.Add(this.pictureBoxPipeDown2);
            this.Controls.Add(this.pictureBoxPipeUp3);
            this.Controls.Add(this.pictureBoxPipeUp2);
            this.Controls.Add(this.pictureBoxPipeUp1);
            this.Controls.Add(this.pictureBoxPipeDown4);
            this.Controls.Add(this.pictureBoxPipeUp4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFlappyBird";
            this.Text = "Flappy bird";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameOfGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelForScore;
        private System.Windows.Forms.Timer timerGame;
        public System.Windows.Forms.PictureBox pictureBoxPlayer;
        public System.Windows.Forms.PictureBox pictureBoxPipeUp1;
        public System.Windows.Forms.PictureBox pictureBoxPipeDown1;
        public System.Windows.Forms.PictureBox pictureBoxGround;
        public System.Windows.Forms.PictureBox pictureBoxPipeUp2;
        public System.Windows.Forms.PictureBox pictureBoxPipeUp3;
        public System.Windows.Forms.PictureBox pictureBoxPipeUp4;
        public System.Windows.Forms.PictureBox pictureBoxPipeDown2;
        public System.Windows.Forms.PictureBox pictureBoxPipeDown4;
        public System.Windows.Forms.PictureBox pictureBoxPipeDown3;
        private System.Windows.Forms.PictureBox pictureBoxNameOfGame;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBoxGameOver;
        private System.Windows.Forms.Button restartButton;
    }
}

