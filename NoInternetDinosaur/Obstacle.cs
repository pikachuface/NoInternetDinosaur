using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NoInternetDinosaur
{
    class Obstacle : PictureBox
    {
        Panel gameCanvas;
        int type;


        public Obstacle(Panel parent)
        {
            Random rnd = new Random(DateTime.Now.Second);
            type = rnd.Next(0, 2);
            this.gameCanvas = parent;
            this.Parent = parent;
            this.BackColor = Color.DarkGray;
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
