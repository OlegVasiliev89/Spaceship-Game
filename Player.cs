using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace star_class_practice
{
    public class Player : PictureBox
    {
        public List<Bullet> playerBullets = new List<Bullet>();
        public bool isGodModeActive = false;

        public Player() 
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\player_img.gif";
            this.Image = Image.FromFile(imagePath);
            this.Top = 440;
            this.Left = 230;
            this.Size = new Size(45, 45);
            this.BringToFront();
        }
        public void Fire_Wepon(Form gameForm)
        {
            Bullet bullet = new Bullet(new Point(this.Left + this.Width / 2, this.Top - 10), -1 );
            gameForm.Controls.Add(bullet);
            playerBullets.Add(bullet);
        }
        public void Player_Movement(bool left, bool right)
        {
            if (right && this.Left < 425)
            {
                this.Left += 20; // Adjust speed for smoother movement
            }
            if (left && this.Left > 10)
            {
                this.Left -= 20;
            }
        }
        public void Activate_God_Mode(Main mainForm)
        {
            if (isGodModeActive) return; // Prevent multiple activations

            isGodModeActive = true;

            Timer godModeTimer = new Timer();
            godModeTimer.Interval = 3000; // 3 seconds
            godModeTimer.Tick += (s, e) =>
            {
                isGodModeActive = false;
                godModeTimer.Stop();
                godModeTimer.Dispose();
            };

            godModeTimer.Start();
        }
        public void Player_Explodes()
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\explosion.gif";
            this.Image = Image.FromFile(imagePath);
        }
    }
}
