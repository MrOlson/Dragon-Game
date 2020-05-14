using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;   // Add this to your program


namespace Dragon_Game
{

    // Mr. Olson Dragon Game


    public partial class Form1 : Form
    {
       private SoundPlayer  _soundplayer;  // add a new sound player 


        int score = 0;
        PictureBox[] rings = new PictureBox[4];
        PictureBox[] Missles = new PictureBox[4];

        Random r = new Random();

        public void Restart()
        {
           
            r.Next(1,100);
            ringstart();

            lbl_Endgame.Hide();
            score = 0;
            lbl_Score.Text = "0"; 
            Missles[0].Visible=true;
            Missles[0].Left =playground.Left+20;
            Missles[0].Top = playground.Height - 50;
            timer1.Enabled = true;
            timer1.Interval = 10;
            tmrMissle.Enabled = true;

        }
        public void ringstart()
        {
            rings[0] = Pic_Ring1;
            rings[1] = Pic_Ring2;
            rings[2] = Pic_Ring3;
            rings[3] = Pic_Ring4;

            rings[0].Top = r.Next(40, playground.Height - 40);
            rings[0].Left = r.Next(40, playground.Width - 40);

            rings[1].Top = r.Next(40, playground.Height - 40);
            rings[1].Left = r.Next(40, playground.Width - 40);

            rings[2].Top = r.Next(40, playground.Height - 40);
            rings[2].Left = r.Next(40, playground.Width - 40);

            rings[3].Top = r.Next(40, playground.Height - 40);
            rings[3].Left = r.Next(40, playground.Width - 40);

           

            
            for (int i = 0; i < 4; i++)
            {
                rings[i].Visible = true;
            }


            Missles[0] = PicMissle;
            Missles[1] = PicMissle2;
            Missles[2] = Pic_Missle3;
            Missles[3] = Pic_Missle4;

            for (int i = 0; i < 4; i++)
            {
                Missles[i].Visible = false;
            }
        }


        public void Edgame()
        {
            lbl_Endgame.Show();
       
        }

        public Form1()
        {
            _soundplayer = new SoundPlayer(Dragon_Game .Properties.Resources.Missile_1);  // create the new sound player
            InitializeComponent();
            this.TopMost = true;                            // This will bring the form to the front/panel
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Restart();
           
        }
       
      

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {

                if (Pic_Dragon.Bounds.IntersectsWith(rings[i].Bounds) && rings[i].Visible)
                {
                    rings[i].Hide();
                    score = score + 1;
                    lbl_Score.Text = score.ToString();

                }
            }

            Pic_Dragon.Left += 2;


            if (Pic_Dragon.Right>= playground.Right)
            {
                Pic_Dragon.Left = 0;
                
            }


            for(int i=0;i<4;i++)
            {
                if (Missles[i].Bounds.IntersectsWith(Pic_Dragon.Bounds) && Missles[i].Visible)
                {
                    Edgame();
                    timer1.Enabled = false;
                    tmrMissle.Enabled = false;
                    tmrMissle2.Enabled = false;
                    ringstart();
                    
                   
                    
                }
            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                Pic_Dragon.Top += 3;
            }
           else if(e.KeyCode == Keys.Up)
                {
                Pic_Dragon.Top -= 3;
            }
            else if (e.KeyCode== Keys.Left)
            {
                Pic_Dragon.Left -= 3;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                Restart();
                
            }
        }

        private void TmrMissle_Tick(object sender, EventArgs e)
        {
            // part 5

            Missles[0].Top -= 5;
            
         
            
            if(Missles[0].Top<0)
            {
               
                Missles[0].Top = playground.Height - 50;
                Missles[0].Left = r.Next(20, playground.Width - 30);
                _soundplayer.Play();   // play the sound
            }

            if (score==2)
            {
                ringstart();
                tmrMissle2.Enabled = true;
                Missles[0].Visible = true;
                Missles[1].Visible = true;
            }
           
        }

        private void TmrMissle2_Tick(object sender, EventArgs e)
        {
            Missles[1].Top -= 5;
            


            if (Missles[1].Top < 0)
            {

                Missles[1].Top = playground.Height - 50;
                Missles[1].Left = r.Next(20, playground.Width - 30);
            }

        }

        private void Playground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
