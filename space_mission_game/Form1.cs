using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_mission_game
{
    public partial class main_Form1 : Form
    {
        public main_Form1()
        {
            InitializeComponent();
        }
        void testing_location()
        {

        }

        int background_speed = 6;
        PictureBox [] bckgnd_stars;
        Random stars_pst;

        private void main_Form1_Load(object sender, EventArgs e)
        {
            bckgnd_stars = new PictureBox[16];
            stars_pst = new Random();

            for (int i = 0; i < bckgnd_stars.Length; i++)
            {
                bckgnd_stars[i] = new PictureBox();
                bckgnd_stars[i].BorderStyle = BorderStyle.None;
                bckgnd_stars[i].Location = new Point(stars_pst.Next(10, 690), stars_pst.Next(-10, 450));
                if (i % 2 == 1)
                {
                    bckgnd_stars[i].Size = new Size(2, 2);
                    bckgnd_stars[i].BackColor = Color.Silver;
                }
                else
                {
                    bckgnd_stars[i].Size = new Size(3, 3);
                    bckgnd_stars[i].BackColor = Color.Moccasin;
                }
            this.Controls.Add(bckgnd_stars[i]);
            }
        }
        private void stars_timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bckgnd_stars.Length / 2; i++)
            {
                bckgnd_stars[i].Top += background_speed;
                if (bckgnd_stars[i].Top >= this.Height)
                {
                    bckgnd_stars[i].Top = -bckgnd_stars[i].Height;
                }
            }
            for (int i = bckgnd_stars.Length / 2; i < bckgnd_stars.Length; i++)
            {
                bckgnd_stars[i].Top += background_speed - 2;
                if (bckgnd_stars[i].Top >= this.Height)
                {
                    bckgnd_stars[i].Top = -bckgnd_stars[i].Height;
                }
            }
        }

        private void go_left_timer1_Tick(object sender, EventArgs e)
        {
            if (actor_gunner.Left >= 5)
            {
                actor_gunner.Left -= background_speed;
            }
        }

        private void go_right_timer2_Tick(object sender, EventArgs e)
        {
            if (actor_gunner.Left <= 495) 
            {
                actor_gunner.Left += background_speed;
            }
        }

        private void go_up_timer3_Tick(object sender, EventArgs e)
        {
            if(actor_gunner.Top > 5)
            {
                actor_gunner.Top -= background_speed;
            }
        }

        private void go_down_timer4_Tick(object sender, EventArgs e)
        {
            if(actor_gunner.Top <= 695)
            {
                actor_gunner.Top += background_speed;
            }
        }

        private void main_Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                go_left_timer1.Start();
            }
            if(e.KeyCode == Keys.Right)
            {
                go_right_timer2.Start();
            }

        }

        private void main_Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
