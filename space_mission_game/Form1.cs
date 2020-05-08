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
        int background_speed = 4;
        PictureBox [] bckgnd_stars;
        Random stars_pst;
        PictureBox[] bullet;
        PictureBox[] enemyjets;
        int enemyspeed = 4;


        private void main_Form1_Load(object sender, EventArgs e)
        {

            bckgnd_stars = new PictureBox[10];
            stars_pst = new Random();
            bullet = new PictureBox[6];
            enemyjets = new PictureBox[7];
            bullet_speed = 19;
            string bullet_path = Application.StartupPath + "\\images\\actor_bullet.png";
            
            string ene1 = Application.StartupPath + "\\images\\enemy1.png";
            string ene2 = Application.StartupPath + "\\images\\enemy2.png";
            string ene3 = Application.StartupPath + "\\images\\enemy3.png";
            string ene4 = Application.StartupPath + "\\images\\enemy4.png";
            string ene5 = Application.StartupPath + "\\images\\enemy5.png";
            string ene6 = Application.StartupPath + "\\images\\enemy6.png";
            string ene7 = Application.StartupPath + "\\images\\enemy7.png";
            
           

            for (int i = 0; i < enemyjets.Length; i++)
            {

                enemyjets[i] = new PictureBox();
                enemyjets[i].Size = new Size(50, 50);
                enemyjets[i].BorderStyle = BorderStyle.None;
                enemyjets[i].SizeMode = PictureBoxSizeMode.StretchImage;
                enemyjets[i].Location = new Point((i * 1) * 105, 10);

                this.Controls.Add(enemyjets[i]);
            }
                enemyjets[0].Image = Image.FromFile(ene1);
                enemyjets[1].Image = Image.FromFile(ene2);
                enemyjets[2].Image = Image.FromFile(ene3);
                enemyjets[3].Image = Image.FromFile(ene4);
                enemyjets[4].Image = Image.FromFile(ene5);
                enemyjets[5].Image = Image.FromFile(ene6);
                enemyjets[6].Image = Image.FromFile(ene7);

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
                    bckgnd_stars[i].BackColor = Color.LightGray;
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

        private void enemyj_jet_timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyjets.Length; i++)
            {
                if (i % 2 == 1)
                {
                    enemyjets[i].Top += enemyspeed;
                    if (enemyjets[i].Top > 550)
                    {
                        enemyjets[i].Location = new Point(stars_pst.Next(5, 290), -250);
                    }
                }
                else
                {
                    enemyjets[i].Top += enemyspeed - 2;
                    if (enemyjets[i].Top > 550)
                    {
                        enemyjets[i].Location = new Point(stars_pst.Next(300, 630), -250);
                    }
                }
            }
        }

        private void collition_timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyjets.Length; i++)
            {
                if(bullet[0].Bounds.IntersectsWith(enemyjets[i].Bounds) ||
                    bullet[2].Bounds.IntersectsWith(enemyjets[i].Bounds) || bullet[3].Bounds.IntersectsWith(enemyjets[i].Bounds))
                {
                    enemyjets[i].Location = new Point(stars_pst.Next(5, 600), -150);
                }
            }
        }
    }
}
