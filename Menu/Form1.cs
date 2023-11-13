using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_tac_toe;

namespace Menu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void SnakeStartBtn_Click(object sender, EventArgs e)
        {
            Snake.Snake Form = new Snake.Snake();
            Form.ShowDialog();
        }

        private void TicTacToeStartBtn_Click(object sender, EventArgs e)
        {
            Tic_tac_toe.Form1 Form = new Tic_tac_toe.Form1();
            Form.ShowDialog();
        }

        private void FlappyBirdStartBtn_Click(object sender, EventArgs e)
        {
            Flappy_bird.FormFlappyBird Form = new Flappy_bird.FormFlappyBird();
            Form.ShowDialog();
        }

        private void BattleCityStartBtn_Click(object sender, EventArgs e)
        {
            string relativePath = Path.Combine("..", "..", "..", "Battle_city\\New\\Tanks.exe");

            // Повний шлях до файлу, об'єднавши його з поточним каталогом проекту
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            // Перевірка, чи існує файл
            if (File.Exists(filePath))
            {
                // Запускаємо виконуваний файл
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
