using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace star_class_practice
{
    public class Alien : PictureBox
    {
        public List<Bullet> alienBullets = new List<Bullet>();
        Random rand = new Random();
         
        public Alien(int shipXCoordinate)
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\alien_gif.gif";
            this.Image = Image.FromFile(imagePath);
            Alien_Starting_Position(shipXCoordinate);
            this.Size = new Size(60, 60);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BringToFront();
        }
        public Point getAlienLocation()
        {
            return this.Location;
        }
        public void Fire_Wepon(Main gameForm)
        {
            Bullet bullet = new Bullet(new Point(this.Left + this.Width / 2, this.Top + 50), 1);
            gameForm.Controls.Add(bullet);
            alienBullets.Add(bullet);            
        }
        public void Alien_Starting_Position(int shipXCoordinate)
        {
            int alienXCoordinate;
            do
            {
                alienXCoordinate = rand.Next(0, 450);
            }
            while (Math.Abs(alienXCoordinate - shipXCoordinate) < 80);
            this.Location = new Point(alienXCoordinate, 0);
        }
        public void Alien_Movement(int shipXCoordinate)
        {
            if(this.Top < 500 && this.Top > -200)
            {
                this.Top += 5;
            }
            else 
            {
                Alien_Starting_Position(shipXCoordinate);
            }
        }
    }
}
