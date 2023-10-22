using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }

        void score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.PowderBlue;
                btnTic2.BackColor = System.Drawing.Color.PowderBlue;
                btnTic3.BackColor = System.Drawing.Color.PowderBlue;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Pink;
                btnTic4.BackColor = System.Drawing.Color.Pink;
                btnTic7.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Crimson;
                btnTic5.BackColor = System.Drawing.Color.Crimson;
                btnTic9.BackColor = System.Drawing.Color.Crimson;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.SlateBlue;
                btnTic5.BackColor = System.Drawing.Color.SlateBlue;
                btnTic8.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.Violet;
                btnTic6.BackColor = System.Drawing.Color.Violet;
                btnTic9.BackColor = System.Drawing.Color.Violet;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic5.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic6.BackColor = System.Drawing.Color.DarkSlateBlue;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = System.Drawing.Color.Azure;
                btnTic8.BackColor = System.Drawing.Color.Azure;
                btnTic9.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("Переможцем стає Гравець X", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl1.Text);
                lbl1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "0" && btnTic2.Text == "0" && btnTic3.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.AliceBlue;
                btnTic2.BackColor = System.Drawing.Color.AliceBlue;
                btnTic3.BackColor = System.Drawing.Color.AliceBlue;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "0" && btnTic4.Text == "0" && btnTic7.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic4.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic7.BackColor = System.Drawing.Color.LemonChiffon;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "0" && btnTic5.Text == "0" && btnTic9.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.BlueViolet;
                btnTic5.BackColor = System.Drawing.Color.BlueViolet;
                btnTic9.BackColor = System.Drawing.Color.BlueViolet;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "0" && btnTic5.Text == "0" && btnTic7.Text == "0")
            {
                btnTic3.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic5.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic7.BackColor = System.Drawing.Color.NavajoWhite;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "0" && btnTic5.Text == "0" && btnTic8.Text == "0")
            {
                btnTic2.BackColor = System.Drawing.Color.SandyBrown;
                btnTic5.BackColor = System.Drawing.Color.SandyBrown;
                btnTic8.BackColor = System.Drawing.Color.SandyBrown;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "0" && btnTic6.Text == "0" && btnTic9.Text == "0")
            {
                btnTic3.BackColor = System.Drawing.Color.SeaGreen;
                btnTic6.BackColor = System.Drawing.Color.SeaGreen;
                btnTic9.BackColor = System.Drawing.Color.SeaGreen;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "0" && btnTic5.Text == "0" && btnTic6.Text == "0")
            {
                btnTic4.BackColor = System.Drawing.Color.Azure;
                btnTic5.BackColor = System.Drawing.Color.Azure;
                btnTic6.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "0" && btnTic8.Text == "0" && btnTic9.Text == "0")
            {
                btnTic7.BackColor = System.Drawing.Color.DarkBlue;
                btnTic8.BackColor = System.Drawing.Color.DarkBlue;
                btnTic9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Переможцем стає Гравець 0", "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl2.Text);
                lbl2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "0";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "0";
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "0";
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "0";
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "0";
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "0";
                checker = false;
            }
            score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "0";
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "0";
                checker = false;
            }
            score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "0";
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            try
            {


                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lbl1.Text = "0";
                lbl2.Text = "0";

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNewGame.Enabled = true;

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Хрестики нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
