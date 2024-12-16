using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool goLeft, goRight, jump;
        int force = 8;
        int jumpspeed = 10;
        int coin = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Map1TimerEvent(object sender, EventArgs e)
        {
            CoinCount.Text = "Coin: " + coin;
            player.Top += jumpspeed;
            if (goLeft == true && player.Left >50)
            {
                player.Left -= playerSpeed;
            }    
            if (goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }    

            if (goLeft == true && background.Left<0)
            {
                background.Left -= backgroundSpeed;
                MovegameElement("forward");
            }
            if (goRight == true && background.Left>693)
            {
                background.Left -= backgroundSpeed;
                MovegameElement("back");
            }
            if (jump == true)
            {
                jumpspeed = -12;
                force -= 1;
            }    
            else
            {
                jumpspeed = 12;
            }
            if (jump == true && force<0)
            {
                jump = false;
            }    
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                goLeft = true;
            }    
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }    
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }    
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jump == true)
            {
                jump = false;
            }
        }

        private void CloseMap1(object sender, FormClosedEventArgs e)
        {

        }
        private void restartgame()
        {

        }
        private void MovegameElement (string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform"|| x is PictureBox && (string)x.Tag == "coin"|| x is PictureBox && (string)x.Tag == "door"|| x is PictureBox && (string)x.Tag == "badge")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }    
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }    
                }    
            } 
                
        }
    }
}
