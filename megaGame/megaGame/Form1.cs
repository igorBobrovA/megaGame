using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaGame
{
    public partial class Form1 : Form
    {
        Random R;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            label12.Visible = false;
            button2.Enabled = false;
        }

        public int NewGame(int player)
        {
            label9.Text = "Сёйчас ходит:";
            label11.Visible = true;
            label12.Visible = true;
            if (player == 1)
            {
                label11.BackColor = Color.CornflowerBlue;
                label12.BackColor = Color.PaleTurquoise;
                button2.Enabled = true;
                MessageBox.Show("сейчас вы ходите", "Кто ходит?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (player == 2)
            {
                label12.BackColor = Color.CornflowerBlue;
                label11.BackColor = Color.PaleTurquoise;
                button2.Enabled = false;
                MessageBox.Show("сейчас ходит компьютер", "Кто ходит?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return player;
        }

        public void cub(int number)
        {
            pictureBox1.Image = ("C:.Users.1.Desktop.123.megaGame.megaGame.megaGame.cubs.cub1.png");
                if (number == 1)
                {

                }
                else if (number == 2)
                {

                }
                else if (number == 3)
                {

                }
                else if (number == 4)
                {

                }
                else if (number == 5)
                {

                }
                else if (number == 6)
                {

                }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            R = new Random();
            int number = R.Next(1, 7),
                WhoPlayNow = R.Next(1, 3),
                compGo = 0,
                playerGo = 0;
            NewGame(WhoPlayNow);
            if (WhoPlayNow == 2)
            {
                cub(number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = R.Next(1, 7);
            cub(number);
        }
    }
}
