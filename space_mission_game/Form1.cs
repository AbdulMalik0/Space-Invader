using space_mission_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        int bullet_speed ;
        int background_speed = 6;
        PictureBox [] bckgnd_stars;
        Random stars_pst;
        PictureBox[] bullet;


        private void main_Form1_Load(object sender, EventArgs e)
        {

            bckgnd_stars = new PictureBox[16];
            stars_pst = new Random();
            bullet = new PictureBox[6];
            bullet_speed = 19;
            string bullet_path = Application.StartupPath + "\\images\\actor_bullet.png";

            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i] = new PictureBox();
                bullet[i].Image = Image.FromFile(bullet_path);
                bullet[i].Size = new Size(8, 8);
                bullet[i].BorderStyle = BorderStyle.None;
                bullet[i].SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(bullet[i]);
            }

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
            if (actor_gunner.Left >= 10)
            {
                actor_gunner.Left -= background_speed;
            }
        }

        private void go_right_timer2_Tick(object sender, EventArgs e)
        {
            if (actor_gunner.Left <= 620) 
            {
                actor_gunner.Left += background_speed;
            }
        }

        private void go_up_timer3_Tick(object sender, EventArgs e)
        {
            if(actor_gunner.Top > 10)
            {
                actor_gunner.Top -= background_speed;
            }
        }

        private void go_down_timer4_Tick(object sender, EventArgs e)
        {
            if(actor_gunner.Top <= 450)
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
            if(e.KeyCode == Keys.Up)
            {
                go_up_timer3.Start();
            }
            if(e.KeyCode == Keys.Down)
            {
                go_down_timer4.Start();
            }
        }

        private void main_Form1_KeyUp(object sender, KeyEventArgs e)
        {
            go_left_timer1.Stop();
            go_right_timer2.Stop();
            go_up_timer3.Stop();
            go_down_timer4.Stop();

        }

        private void bullet_timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullet.Length; i++)
            {
                if (bullet[i].Top > 0)
                {
                        bullet[i].Visible = true;
                        bullet[i].Top -= bullet_speed;
                }
                else
                {
                    bullet[i].Visible = false;
                    bullet[i].Location = new Point(actor_gunner.Location.X + 20, actor_gunner.Location.Y - i * 30);
                }
            }
        }
    }
}
