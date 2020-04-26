using System;
using System.Windows.Forms;
using System.Drawing;

namespace NoInternetDinosaur
{
    class Obstacle : Button
    {
        Panel gameCanvas;
        int type;


        public Obstacle(Panel parent)
        {

            //Apereance
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.DarkGray;
            this.FlatStyle = FlatStyle.Flat;
            this.Enabled = false;

            //Function
            Random rnd = new Random(DateTime.Now.Second);
            type = rnd.Next(0, 2);

            this.Parent = parent;
            this.gameCanvas = parent;
            
            if (type == 1)
            {
                this.Size = new Size(50 ,10);
                this.Location = new Point(gameCanvas.Width + 2 * this.Width, 80);
            }
            else
            {
                this.Size = new Size(20, 60);
                this.Location = new Point(gameCanvas.Width + 2 * this.Width, gameCanvas.Height - this.Height);
            }
        }

        new public void Update()
        {
            this.Location = new Point(this.Location.X - (int)Settings.GameSpeed, this.Location.Y);
            if (this.Location.X < -2 * Width) this.Dispose();
        }
    }
}
