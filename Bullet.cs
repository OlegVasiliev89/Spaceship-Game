using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace star_class_practice
{
    public class Bullet : PictureBox
    {
        private Timer timer;
        private int direction;
        private int speed = 10;
        public Bullet(Point startPosition, int direction)
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\bullet_img.png";
            this.Image = Image.FromFile(imagePath);
            this.Location = startPosition;  
            this.direction = direction;
            this.Size = new Size(25, 25);
            this.BringToFront();

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Move_Bullet;
            timer.Start();
        }
        public void Move_Bullet(object sender, EventArgs e)
        {          
            this.Top += speed * direction;
            this.BringToFront();

            if (this.Top > 600 || this.Top < 0)
            {
                timer.Stop();
                timer.Dispose();
                this.Dispose();
            }
        }
    }
}
