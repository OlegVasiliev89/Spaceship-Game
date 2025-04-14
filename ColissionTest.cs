using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using System.Drawing;


namespace star_class_practice
{
    public class ColissionTest : PictureBox
    {
        public static void Check_Colissions_On_Alien(Main mainForm, Alien alien, List<Bullet> playerBullets)
        {
            for (int i = playerBullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = playerBullets[i];

                if (bullet.Bounds.IntersectsWith(alien.Bounds))
                {
                    mainForm.Game_Score_Increase();

                    mainForm.Controls.Remove(bullet);
                    playerBullets.RemoveAt(i);
                    bullet.Dispose();

                    mainForm.RemoveAndRespawnAlien();
                    Explosion explosion = new Explosion(mainForm, alien);
                }
            }
        }
        public static void Check_Colissions_On_Ship(Main mainForm, Ship ship, List<Bullet> playerBullets)
        {
            for (int i = playerBullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = playerBullets[i];


                if (bullet.Bounds.IntersectsWith(ship.Bounds))
                {
                    mainForm.Game_Score_Decrease();


                    mainForm.Controls.Remove(bullet);
                    playerBullets.RemoveAt(i);
                    bullet.Dispose();

                    mainForm.RemoveAndRespawnShip();
                    Explosion explosion = new Explosion(mainForm, ship);
                }
            }
        }
        public static void Check_Colissions_On_Player(Lives lives, Main mainForm, Player player, List<Bullet> alienBullets, Alien alien, Ship ship)
        {
            if (player.isGodModeActive)
            {
                return;
            }

            for (int i = alienBullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = alienBullets[i];
                if (bullet.Bounds.IntersectsWith(player.Bounds))
                {
                    lives.Deacrease_Lives();

                    lives.Deacrease_Heart(mainForm, alien, ship);
                    player.Activate_God_Mode(mainForm);

                    if (lives.lives == 0)
                    {
                        player.Player_Explodes();
                        mainForm.timer.Stop();
                    }


                }
            }
        }
        public static void Check_Player_Ship_Colissions(Lives lives, Main mainForm, Player player, Ship ship, Alien alien)
        {

            if (player.Bounds.IntersectsWith(ship.Bounds))
            {
                Explosion explosion = new Explosion(mainForm, ship);
                mainForm.RemoveAndRespawnShip();
                lives.Deacrease_Lives();
                lives.Deacrease_Heart(mainForm, alien, ship);

                if(lives.lives == 0)
                {
                    player.Player_Explodes();
                    mainForm.timer.Stop();
                }
            }

        }
        public static void Check_Player_Alien_Colissions(Lives lives, Main mainForm, Player player, Alien alien, Ship ship)
        {

            if (player.Bounds.IntersectsWith(alien.Bounds))
            {
                Explosion explosion = new Explosion(mainForm, alien);
                mainForm.RemoveAndRespawnAlien();
                lives.Deacrease_Lives();
                lives.Deacrease_Heart(mainForm, alien, ship);

                if (lives.lives == 0)
                {
                    player.Player_Explodes();
                    mainForm.timer.Stop();
                }

            }

        }
    }
}



