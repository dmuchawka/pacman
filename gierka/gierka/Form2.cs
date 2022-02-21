using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gierka
{
    public partial class Form2 : Form
    {



        bool goup, godown, goleft, goright, isGameOver;


        int score, playerSpeed, pinkghostSpeed, lightblueghostSpeed, blueghostX, blueghostY;







        public Form2()
        {
            InitializeComponent();
            resetGame();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Up)
            {
                goup = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goup=false;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {

            textscore.Text = "Wynik: " + score;

            if (goleft==true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.pacman1;
            }
            if (goright==true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.pacman1;

            }

            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.pacman1;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image= Properties.Resources.pacman1;
            }

            if(pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if(pacman.Left> 680)
            {
                pacman.Left = -10;
            }


           if(pacman.Top < -10)
            {
                pacman.Top = 550;
            }
           if(pacman.Top > 550)
            {
                pacman.Top = 0;
            }
           
           
           foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }
                }
            }

           
          
           




        }

        private void resetGame()
        {

            textscore.Text = "Wynik: 0";
            score = 0;


            pinkghostSpeed = 5;
            lightblueghostSpeed = 5;
            blueghostX = 5;
            blueghostY = 5;
            playerSpeed = 8;



            isGameOver = false;


            pacman.Left = 45;
            pacman.Top = 120;

            pinkghost.Left = 236;
            pinkghost.Top = 75;


            lightblueghost.Left = 467;
            lightblueghost.Top = 430;


            blueghost.Left = 589;
            blueghost.Top = 229;






            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }





            gameTimer.Start();

        }
        private void gameOver(string message)
        {

        }


    }
}
