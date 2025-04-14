using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_class_practice
{
    public class Ship : PictureBox
    {     
        private int shipXCoordinate;
        public Ship()
        {
            string imagePath = @"C:\Users\oleg\Documents\Class Practice\ship_gif.gif";
            this.Image = Image.FromFile(imagePath);
            Ship_Starting_Position();
            this.Size = new Size(60, 60);
            this.BringToFront();
        }
        public Point getShipLocation()
        {
            return this.Location;
        }
        public void Ship_Starting_Position()
        {
            Random random = new Random();
           
            shipXCoordinate = random.Next(0, 450);
            this.Location = new Point(shipXCoordinate, -180);
        }
        public int GetShipXCoordinate() 
        {
            return shipXCoordinate;
        }
        public void Ship_Movement()
        {
            if (this.Top < 500 && this.Top > -200)
            {
                this.Top += 5;
            }
            else
            {
                Ship_Starting_Position();
            }
        }
    }
}
