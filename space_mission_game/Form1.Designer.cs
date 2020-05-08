namespace space_mission_game
{
    partial class main_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stars_timer1 = new System.Windows.Forms.Timer(this.components);
            this.go_left_timer1 = new System.Windows.Forms.Timer(this.components);
            this.go_right_timer2 = new System.Windows.Forms.Timer(this.components);
            this.go_up_timer3 = new System.Windows.Forms.Timer(this.components);
            this.go_down_timer4 = new System.Windows.Forms.Timer(this.components);
            this.bullet_timer1 = new System.Windows.Forms.Timer(this.components);
            this.actor_gunner = new System.Windows.Forms.PictureBox();
            this.enemyj_jet_timer1 = new System.Windows.Forms.Timer(this.components);
            this.collition_timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.actor_gunner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // stars_timer1
            // 
            this.stars_timer1.Enabled = true;
            this.stars_timer1.Interval = 10;
            this.stars_timer1.Tick += new System.EventHandler(this.stars_timer1_Tick);
            // 
            // go_left_timer1
            // 
            this.go_left_timer1.Interval = 5;
            this.go_left_timer1.Tick += new System.EventHandler(this.go_left_timer1_Tick);
            // 
            // go_right_timer2
            // 
            this.go_right_timer2.Interval = 5;
            this.go_right_timer2.Tick += new System.EventHandler(this.go_right_timer2_Tick);
            // 
            // go_up_timer3
            // 
            this.go_up_timer3.Interval = 5;
            this.go_up_timer3.Tick += new System.EventHandler(this.go_up_timer3_Tick);
            // 
            // go_down_timer4
            // 
            this.go_down_timer4.Interval = 5;
            this.go_down_timer4.Tick += new System.EventHandler(this.go_down_timer4_Tick);
            // 
            // bullet_timer1
            // 
            this.bullet_timer1.Enabled = true;
            this.bullet_timer1.Interval = 20;
            this.bullet_timer1.Tick += new System.EventHandler(this.bullet_timer1_Tick);
            // 
            // actor_gunner
            // 
            this.actor_gunner.BackgroundImage = global::space_mission_game.Properties.Resources.jet;
            this.actor_gunner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor_gunner.Location = new System.Drawing.Point(302, 451);
            this.actor_gunner.Name = "actor_gunner";
            this.actor_gunner.Size = new System.Drawing.Size(50, 50);
            this.actor_gunner.TabIndex = 0;
            this.actor_gunner.TabStop = false;
            // 
            // enemyj_jet_timer1
            // 
            this.enemyj_jet_timer1.Enabled = true;
            this.enemyj_jet_timer1.Interval = 20;
            this.enemyj_jet_timer1.Tick += new System.EventHandler(this.enemyj_jet_timer1_Tick);
            // 
            // collition_timer1
            // 
            this.collition_timer1.Enabled = true;
            this.collition_timer1.Interval = 30;
            this.collition_timer1.Tick += new System.EventHandler(this.collition_timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(204, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 2);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Location = new System.Drawing.Point(446, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 2);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox3.Location = new System.Drawing.Point(536, 367);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 2);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox4.Location = new System.Drawing.Point(359, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(3, 3);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox5.Location = new System.Drawing.Point(66, 420);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(2, 2);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox6.Location = new System.Drawing.Point(428, 434);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 3);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox7.Location = new System.Drawing.Point(40, 71);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(5, 5);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox8.Location = new System.Drawing.Point(340, 253);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(2, 2);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actor_gunner);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 550);
            this.MinimizeBox = false;
            this.Name = "main_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Mission";
            this.Load += new System.EventHandler(this.main_Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.main_Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.actor_gunner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer stars_timer1;
        private System.Windows.Forms.PictureBox actor_gunner;
        private System.Windows.Forms.Timer go_left_timer1;
        private System.Windows.Forms.Timer go_right_timer2;
        private System.Windows.Forms.Timer go_up_timer3;
        private System.Windows.Forms.Timer go_down_timer4;
        private System.Windows.Forms.Timer bullet_timer1;
        private System.Windows.Forms.Timer enemyj_jet_timer1;
        private System.Windows.Forms.Timer collition_timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

