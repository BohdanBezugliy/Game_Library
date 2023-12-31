﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake : Form

    {
        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400];
        private Label labelScore;
        private int dirx, diry;
        private int _width = 900;
        private int _height = 800;
        private int _sizeofsides = 40;
        private int score = 0;
        public Snake()
        {
            InitializeComponent();
            this.Text = "Snake";
            this.Width = _width;
            this.Height = _height;
            dirx =1; 
            diry =0;
            labelScore = new Label();
            labelScore.Text = "score: 0";
            labelScore.Location = new Point(810, 10);
            this.Controls.Add(labelScore); 
            snake[0] = new PictureBox();
            snake[0].Location = new Point(201, 201);
            snake[0].Size = new Size(_sizeofsides-1, _sizeofsides-1);
            snake[0].BackColor= Color.Blue;
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Orange;
            fruit.Size = new Size(_sizeofsides, _sizeofsides);
            _generateMap();
            _generateFruit();
            timer.Tick += new EventHandler(_update);
            timer.Interval = 200;
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }

        private void _generateFruit() 
        {
        Random r = new Random();
            rI = r.Next(0, _height - _sizeofsides);
            int tempI = rI % _sizeofsides;
            rI -= tempI;
            rJ = r.Next(0, _height - _sizeofsides);
            int tempJ = rJ % _sizeofsides;
            rJ -= tempJ;
            rI++;
            rJ++;
            fruit.Location = new Point(rI, rJ);
            this.Controls.Add(fruit);
        }

        private void _checkBorders() 
        {
          if (snake[0].Location.X < 0) 
            {
              for(int _i = 1; _i <= score; _i++) 
                {
                    this.Controls.Remove(snake[_i]);
                }
              score = 0;
                labelScore.Text = "Score:" + score;
                dirx = 1;
            }
            if (snake[0].Location.X > _height)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score:" + score;
                dirx = -1;
            }
            if (snake[0].Location.Y < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score:" + score;
                diry = 1;
            }
            if (snake[0].Location.Y > _height)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Score:" + score;
                diry = -1;
            }
        }

        private void _eatItse1f() 
        {
          for(int _i=1; _i< score; _i++) 
            {
                if (snake[0].Location == snake[_i].Location) 
                {
                  for (int _j = _i; _j <= score; _j++)
                        this.Controls.Remove(snake[_j]);
                  score = score - (score - _i +1);
                    labelScore.Text = "Score:" + score;
                }
            
            }
        
        
        
        }

        private void _eatfruit() 
        {
            if (snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                labelScore.Text = "Score: " + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirx, snake[score - 1].Location.Y + 40 * diry);
                snake[score].Size = new Size(_sizeofsides - 1, _sizeofsides - 1);
                snake[score].BackColor = Color.Yellow;
                this.Controls.Add(snake[score]);
                _generateFruit();
            }
        }

        private void _generateMap()
        {
            for (int i = 0; i < _width / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeofsides * i);
                pic.Size = new Size(_width - 100, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= _height / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeofsides * i, 0);
                pic.Size = new Size(1, _width);
                this.Controls.Add(pic);
            }
        }  

        private void _mowesnake() 
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirx * (_sizeofsides), snake[0].Location.Y + diry * (_sizeofsides));
            _eatItse1f();
        }


        private void _update(object myobjeck, EventArgs eventsArgs) 
        {
            _checkBorders();
            _eatfruit();
            _mowesnake();
        //cube.Location = new Point(cube.Location.X+dirx * _sizeofsides, cube.Location.Y + diry * _sizeofsides);
        }

        private void OKP(object sander, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirx = 1;
                    diry = 0;
                    break;
                case "Left":
                    dirx = -1;
                    diry = 0;
                    break;
                case "Up":
                    diry = -1;
                    dirx = 0;
                    break;
                case "Down":
                    diry = 1;
                    dirx = 0;
                    break;
            }
        }

      
    }
}

