using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace star_class_practice
{
    public class Background : PictureBox
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        Timer timer;
        public Background(Main mainForm)
        {
            pictureBox1 = mainForm.pictureBox1;
            pictureBox2 = mainForm.pictureBox2;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Background_Movement;
            timer.Start();
        }
        public void Background_Movement(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top > 400)
            {
                pictureBox1.Top = 0;
            }
            pictureBox2.Top += 5;

            if (pictureBox2.Top > 400)
            {
                pictureBox2.Top = 0;
            }
        }
    }
}
