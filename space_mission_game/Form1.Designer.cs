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
            this.actor_gunner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.actor_gunner)).BeginInit();
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
            // main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 511);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer stars_timer1;
        private System.Windows.Forms.PictureBox actor_gunner;
        private System.Windows.Forms.Timer go_left_timer1;
        private System.Windows.Forms.Timer go_right_timer2;
        private System.Windows.Forms.Timer go_up_timer3;
        private System.Windows.Forms.Timer go_down_timer4;
    }
}

