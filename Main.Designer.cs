namespace star_class_practice
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.heartOne = new System.Windows.Forms.PictureBox();
            this.heartThree = new System.Windows.Forms.PictureBox();
            this.heartTwo = new System.Windows.Forms.PictureBox();
            this.Game_Menu = new System.Windows.Forms.GroupBox();
            this.lbl_game_over = new System.Windows.Forms.Label();
            this.lbl_Quit = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartTwo)).BeginInit();
            this.Game_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Score :  0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // heartOne
            // 
            this.heartOne.Image = ((System.Drawing.Image)(resources.GetObject("heartOne.Image")));
            this.heartOne.Location = new System.Drawing.Point(382, 8);
            this.heartOne.Name = "heartOne";
            this.heartOne.Size = new System.Drawing.Size(26, 23);
            this.heartOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartOne.TabIndex = 3;
            this.heartOne.TabStop = false;
            // 
            // heartThree
            // 
            this.heartThree.Image = ((System.Drawing.Image)(resources.GetObject("heartThree.Image")));
            this.heartThree.Location = new System.Drawing.Point(446, 8);
            this.heartThree.Name = "heartThree";
            this.heartThree.Size = new System.Drawing.Size(26, 23);
            this.heartThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartThree.TabIndex = 4;
            this.heartThree.TabStop = false;
            // 
            // heartTwo
            // 
            this.heartTwo.Image = ((System.Drawing.Image)(resources.GetObject("heartTwo.Image")));
            this.heartTwo.Location = new System.Drawing.Point(414, 8);
            this.heartTwo.Name = "heartTwo";
            this.heartTwo.Size = new System.Drawing.Size(26, 23);
            this.heartTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartTwo.TabIndex = 5;
            this.heartTwo.TabStop = false;
            // 
            // Game_Menu
            // 
            this.Game_Menu.Controls.Add(this.lbl_game_over);
            this.Game_Menu.Controls.Add(this.lbl_Quit);
            this.Game_Menu.Controls.Add(this.lbl_restart);
            this.Game_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Menu.Location = new System.Drawing.Point(83, 109);
            this.Game_Menu.Name = "Game_Menu";
            this.Game_Menu.Size = new System.Drawing.Size(314, 242);
            this.Game_Menu.TabIndex = 6;
            this.Game_Menu.TabStop = false;
            // 
            // lbl_game_over
            // 
            this.lbl_game_over.AutoSize = true;
            this.lbl_game_over.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game_over.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_game_over.Location = new System.Drawing.Point(60, 44);
            this.lbl_game_over.Name = "lbl_game_over";
            this.lbl_game_over.Size = new System.Drawing.Size(194, 41);
            this.lbl_game_over.TabIndex = 2;
            this.lbl_game_over.Text = "Game Over!";
            // 
            // lbl_Quit
            // 
            this.lbl_Quit.AutoSize = true;
            this.lbl_Quit.BackColor = System.Drawing.Color.Crimson;
            this.lbl_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quit.Location = new System.Drawing.Point(126, 166);
            this.lbl_Quit.Name = "lbl_Quit";
            this.lbl_Quit.Size = new System.Drawing.Size(55, 25);
            this.lbl_Quit.TabIndex = 1;
            this.lbl_Quit.Text = "Quit";
            this.lbl_Quit.Click += new System.EventHandler(this.lbl_Quit_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.Location = new System.Drawing.Point(109, 108);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(88, 25);
            this.lbl_restart.TabIndex = 0;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Game_Menu);
            this.Controls.Add(this.heartTwo);
            this.Controls.Add(this.heartThree);
            this.Controls.Add(this.heartOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartTwo)).EndInit();
            this.Game_Menu.ResumeLayout(false);
            this.Game_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox heartOne;
        public System.Windows.Forms.PictureBox heartThree;
        public System.Windows.Forms.PictureBox heartTwo;
        public System.Windows.Forms.GroupBox Game_Menu;
        public System.Windows.Forms.Label lbl_Quit;
        public System.Windows.Forms.Label lbl_restart;
        public System.Windows.Forms.Label lbl_game_over;
    }
}

