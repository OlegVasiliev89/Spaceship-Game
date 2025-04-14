using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace star_class_practice
{
    public partial class Main : Form
    {   
        Player player;
        public Alien alien;
        public Ship ship;
        Background background;
        Lives lives;
        bool right, left, space;
        int result = 0;
        public Timer timer;

        public Main()
        {
            InitializeComponent();
            Game_Menu.Hide();

            this.ClientSize = new Size(500,500);
            this.BackColor = Color.Black;

            background = new Background(this);
            lives = new Lives(this);


            Player_Creation();
            Ship_Creation();
            Alien_Creation();          
            Score_Creation();


            timer = new Timer();
            timer.Interval = 20; 
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        public void Score_Creation()
        {
            label1.BringToFront();
            label1.ForeColor = Color.Red;           
        }
        public void RemoveAndRespawnAlien()
        {
            if (alien != null) 
            {
                this.Controls.Remove(alien);
                alien.Dispose();
                alien = null;
            }
            Alien_Creation();
        }
        public void RemoveAndRespawnShip()
        {
            if (ship != null)
            {
                this.Controls.Remove(ship);
                ship.Dispose();
                ship = null;
            }
            Ship_Creation();
        }
        public void Game_Score_Increase()
        {
            result++;
            label1.Text = "Game Score : " + result;
        }
        public void Game_Score_Decrease()
        {
            result -= 3;
            label1.Text = "Game Score : " + result;
        }
        
        public void Alien_Creation()
        {
            alien = new Alien(ship.GetShipXCoordinate());
            this.Controls.Add(alien);
            alien.BringToFront();
        }
        public void Ship_Creation()
        {
            ship = new Ship();
            this.Controls.Add(ship);
            ship.BringToFront();
        }
        public void Player_Creation()
        {
            player = new Player();
            this.Controls.Add(player);
            player.BringToFront();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Player_Movement(left, right);
            alien.Alien_Movement(ship.GetShipXCoordinate());
            ship.Ship_Movement();

            ColissionTest.Check_Colissions_On_Alien(this, alien, player.playerBullets);
            ColissionTest.Check_Colissions_On_Ship(this, ship, player.playerBullets);
            ColissionTest.Check_Colissions_On_Player(lives, this, player, alien.alienBullets, alien, ship);
            ColissionTest.Check_Player_Ship_Colissions(lives, this, player, ship, alien);
            ColissionTest.Check_Player_Alien_Colissions(lives, this, player, alien, ship);

            Random random = new Random();
            if ((random.Next(0, 100) < 10))
            {
                alien.Fire_Wepon(this);
            }          
        }
        public void Restart_Game()
        {
            result = 0;
            label1.Text = "Game Score : " + result;

            RemoveAndRespawnShip();
            RemoveAndRespawnAlien();
            Player_Creation();

            lives.ResetLives();
            
            timer.Start();
        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            Game_Menu.Hide(); 

            Restart_Game(); 
        }

        private void lbl_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                player.Fire_Wepon(this);
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
    }
}
