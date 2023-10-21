namespace Flappy_bird
{
    partial class Form1
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelForScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Flappy_bird.Properties.Resources.Ground;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 614);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(634, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxPipDown
            // 
            this.pictureBoxPipDown.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipDown.BackgroundImage = global::Flappy_bird.Properties.Resources.PipeDown;
            this.pictureBoxPipDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPipDown.Location = new System.Drawing.Point(494, 520);
            this.pictureBoxPipDown.Name = "pictureBoxPipDown";
            this.pictureBoxPipDown.Size = new System.Drawing.Size(100, 116);
            this.pictureBoxPipDown.TabIndex = 2;
            this.pictureBoxPipDown.TabStop = false;
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
            // labelForScore
            // 
            this.labelForScore.AutoSize = true;
            this.labelForScore.BackColor = System.Drawing.Color.Transparent;
            this.labelForScore.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForScore.Location = new System.Drawing.Point(12, 20);
            this.labelForScore.Name = "labelForScore";
            this.labelForScore.Size = new System.Drawing.Size(226, 60);
            this.labelForScore.TabIndex = 4;
            this.labelForScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(633, 666);
            this.Controls.Add(this.labelForScore);
            this.Controls.Add(this.pictureBoxPipDown);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBoxPipeUp);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Flappy bird";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxPipeUp;
        private System.Windows.Forms.PictureBox pictureBoxPipDown;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelForScore;
    }
}

