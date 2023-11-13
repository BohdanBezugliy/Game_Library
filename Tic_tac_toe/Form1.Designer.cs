namespace Tic_tac_toe
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
            System.Windows.Forms.Button btnExit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPlayer0 = new System.Windows.Forms.Button();
            this.lblPlayerX = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTic9 = new System.Windows.Forms.Button();
            this.btnTic8 = new System.Windows.Forms.Button();
            this.btnTic7 = new System.Windows.Forms.Button();
            this.btnTic6 = new System.Windows.Forms.Button();
            this.btnTic5 = new System.Windows.Forms.Button();
            this.btnTic4 = new System.Windows.Forms.Button();
            this.btnTic3 = new System.Windows.Forms.Button();
            this.btnTic2 = new System.Windows.Forms.Button();
            this.btnTic1 = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MistyRose;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            btnExit.Location = new System.Drawing.Point(355, 167);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(317, 102);
            btnExit.TabIndex = 10;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(272, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хрестики нулики";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 592);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnNewGame);
            this.panel5.Controls.Add(btnExit);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Location = new System.Drawing.Point(646, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 285);
            this.panel5.TabIndex = 3;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.MistyRose;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNewGame.Location = new System.Drawing.Point(22, 24);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(637, 123);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "Нова гра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.Location = new System.Drawing.Point(3, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(327, 102);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbl2);
            this.panel4.Controls.Add(this.lbl1);
            this.panel4.Controls.Add(this.lblPlayer0);
            this.panel4.Controls.Add(this.lblPlayerX);
            this.panel4.Location = new System.Drawing.Point(646, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 268);
            this.panel4.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl2.Location = new System.Drawing.Point(562, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 98);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl1.Location = new System.Drawing.Point(562, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 98);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "0";
            // 
            // lblPlayer0
            // 
            this.lblPlayer0.BackColor = System.Drawing.Color.MistyRose;
            this.lblPlayer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlayer0.Location = new System.Drawing.Point(13, 143);
            this.lblPlayer0.Name = "lblPlayer0";
            this.lblPlayer0.Size = new System.Drawing.Size(503, 89);
            this.lblPlayer0.TabIndex = 11;
            this.lblPlayer0.Text = "Гравець 0:";
            this.lblPlayer0.UseVisualStyleBackColor = false;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.Color.MistyRose;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerX.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlayerX.Location = new System.Drawing.Point(13, 16);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(503, 89);
            this.lblPlayerX.TabIndex = 10;
            this.lblPlayerX.Text = "Гравець X:";
            this.lblPlayerX.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTic9);
            this.panel3.Controls.Add(this.btnTic8);
            this.panel3.Controls.Add(this.btnTic7);
            this.panel3.Controls.Add(this.btnTic6);
            this.panel3.Controls.Add(this.btnTic5);
            this.panel3.Controls.Add(this.btnTic4);
            this.panel3.Controls.Add(this.btnTic3);
            this.panel3.Controls.Add(this.btnTic2);
            this.panel3.Controls.Add(this.btnTic1);
            this.panel3.Location = new System.Drawing.Point(17, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 559);
            this.panel3.TabIndex = 1;
            // 
            // btnTic9
            // 
            this.btnTic9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic9.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic9.Location = new System.Drawing.Point(415, 374);
            this.btnTic9.Name = "btnTic9";
            this.btnTic9.Size = new System.Drawing.Size(200, 158);
            this.btnTic9.TabIndex = 8;
            this.btnTic9.UseVisualStyleBackColor = false;
            this.btnTic9.Click += new System.EventHandler(this.btnTic9_Click);
            // 
            // btnTic8
            // 
            this.btnTic8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic8.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic8.Location = new System.Drawing.Point(209, 374);
            this.btnTic8.Name = "btnTic8";
            this.btnTic8.Size = new System.Drawing.Size(200, 158);
            this.btnTic8.TabIndex = 7;
            this.btnTic8.UseVisualStyleBackColor = false;
            this.btnTic8.Click += new System.EventHandler(this.btnTic8_Click);
            // 
            // btnTic7
            // 
            this.btnTic7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic7.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic7.Location = new System.Drawing.Point(3, 374);
            this.btnTic7.Name = "btnTic7";
            this.btnTic7.Size = new System.Drawing.Size(200, 158);
            this.btnTic7.TabIndex = 6;
            this.btnTic7.UseVisualStyleBackColor = false;
            this.btnTic7.Click += new System.EventHandler(this.btnTic7_Click);
            // 
            // btnTic6
            // 
            this.btnTic6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic6.Location = new System.Drawing.Point(415, 189);
            this.btnTic6.Name = "btnTic6";
            this.btnTic6.Size = new System.Drawing.Size(200, 158);
            this.btnTic6.TabIndex = 5;
            this.btnTic6.UseVisualStyleBackColor = false;
            this.btnTic6.Click += new System.EventHandler(this.btnTic6_Click);
            // 
            // btnTic5
            // 
            this.btnTic5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic5.Location = new System.Drawing.Point(210, 189);
            this.btnTic5.Name = "btnTic5";
            this.btnTic5.Size = new System.Drawing.Size(200, 158);
            this.btnTic5.TabIndex = 4;
            this.btnTic5.UseVisualStyleBackColor = false;
            this.btnTic5.Click += new System.EventHandler(this.btnTic5_Click);
            // 
            // btnTic4
            // 
            this.btnTic4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic4.Location = new System.Drawing.Point(3, 189);
            this.btnTic4.Name = "btnTic4";
            this.btnTic4.Size = new System.Drawing.Size(200, 158);
            this.btnTic4.TabIndex = 3;
            this.btnTic4.UseVisualStyleBackColor = false;
            this.btnTic4.Click += new System.EventHandler(this.btnTic4_Click);
            // 
            // btnTic3
            // 
            this.btnTic3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic3.Location = new System.Drawing.Point(415, 3);
            this.btnTic3.Name = "btnTic3";
            this.btnTic3.Size = new System.Drawing.Size(200, 158);
            this.btnTic3.TabIndex = 2;
            this.btnTic3.UseVisualStyleBackColor = false;
            this.btnTic3.Click += new System.EventHandler(this.btnTic3_Click);
            // 
            // btnTic2
            // 
            this.btnTic2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTic2.Location = new System.Drawing.Point(209, 3);
            this.btnTic2.Name = "btnTic2";
            this.btnTic2.Size = new System.Drawing.Size(200, 158);
            this.btnTic2.TabIndex = 1;
            this.btnTic2.UseVisualStyleBackColor = false;
            this.btnTic2.Click += new System.EventHandler(this.btnTic2_Click);
            // 
            // btnTic1
            // 
            this.btnTic1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTic1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTic1.Location = new System.Drawing.Point(3, 3);
            this.btnTic1.Name = "btnTic1";
            this.btnTic1.Size = new System.Drawing.Size(200, 158);
            this.btnTic1.TabIndex = 0;
            this.btnTic1.UseVisualStyleBackColor = false;
            this.btnTic1.Click += new System.EventHandler(this.btnTic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic tac toe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTic1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTic9;
        private System.Windows.Forms.Button btnTic8;
        private System.Windows.Forms.Button btnTic7;
        private System.Windows.Forms.Button btnTic6;
        private System.Windows.Forms.Button btnTic5;
        private System.Windows.Forms.Button btnTic4;
        private System.Windows.Forms.Button btnTic3;
        private System.Windows.Forms.Button btnTic2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button lblPlayer0;
        private System.Windows.Forms.Button lblPlayerX;
    }
}

