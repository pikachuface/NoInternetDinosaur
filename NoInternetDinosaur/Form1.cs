using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoInternetDinosaur
{
    public partial class MainForm : Form
    {
        List<Obstacle> obstacles = new List<Obstacle>();
        Dinosaur player;
        int score; 
        

        public MainForm()
        {
            InitializeComponent();
            player = new Dinosaur(40, gameCanvas, 20);
        }

        void StartGame()
        {
            label1.Text = "No Internet!";
            player.Dispose();
            foreach (var obstacle in obstacles)
            {
                obstacle.Dispose();
            }
            player = new Dinosaur(40, gameCanvas, 20);
            score = 0;
            gameTick.Start();
            obstacleTimer.Start();
            CollisonDetection.Start();
        }

        void EndGame()
        {
            label1.Text = "Game Over!";
            infoLabel.Visible = true;
            gameTick.Stop();
            obstacleTimer.Stop();
            CollisonDetection.Stop();
            Settings.GameOver = true;
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Settings.GameOver)
            {
                StartGame();
                Settings.GameOver = false;
                infoLabel.Visible = false;
            }
            else
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    player.Jump();
                }
            }
        }


        private void gameTick_Tick(object sender, EventArgs e)
        {
            player.Update();
            foreach (var obstacle in obstacles)
            {
                obstacle.Update();
            }
            scoreLabel.Text = $"Score: {score++}";
        }

        private void obstacleTimer_Tick(object sender, EventArgs e)
        {
            obstacles.Add(new Obstacle(gameCanvas));
        }

        private void CollisonDetection_Tick(object sender, EventArgs e)
        {
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(player.Bounds))
                {
                    EndGame();
                }   
            }
        }
    }
}
