using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_class_practice
{
    public class Lives
    {
        public PictureBox heartOne;
        public PictureBox heartTwo;
        public PictureBox heartThree;
        public int lives = 3;
        public Lives(Main mainForm)
        {
            heartOne = mainForm.heartOne;
            heartTwo = mainForm.heartTwo;
            heartThree = mainForm.heartThree;
        }
        public void Deacrease_Heart(Main mainForm, Alien alien, Ship ship)
        {
            if (lives == 2)
            {
                heartOne.Visible = false;
            }
            if (lives == 1)
            {
                heartTwo.Visible = false;
            }
            if (lives == 0)
            {
                heartThree.Visible = false;
                mainForm.Game_Menu.Show();
                mainForm.alien.Hide();
                mainForm.ship.Hide();
            }
        }
        public void Deacrease_Lives()
        {
            lives--;
        }
        public void ResetLives()
        {
            // Set lives back to initial value (e.g., 3)
            this.lives = 3; // Assuming `livesCount` tracks the player's lives
            heartOne.Visible = true;
            heartTwo.Visible = true;
            heartThree.Visible = true;



        }



    }
}
