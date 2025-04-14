using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace star_class_practice
{
    public class Explosion : PictureBox
    {
        Timer timer;
        public Explosion(Main main, Alien alien)
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\explosion.gif";
            this.Image = Image.FromFile(imagePath);
            this.Location = alien.getAlienLocation();
            this.Size = new Size(45, 45);
            main.Controls.Add(this);
            this.BringToFront();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += EndExplosion;
            timer.Start();
        }
        public Explosion(Main main, Ship ship)
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\explosion.gif";
            this.Image = Image.FromFile(imagePath);
            this.Location = ship.getShipLocation();
            this.Size = new Size(45, 45);
            main.Controls.Add(this);
            this.BringToFront();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += EndExplosion;
            timer.Start();
        }
        public void EndExplosion(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
