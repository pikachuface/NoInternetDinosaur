using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NoInternetDinosaur
{
    class Dinosaur : PictureBox
    {
        public int Lives;

        private float jumpSpeed;
        private bool onGround = true;
        Panel gameCanvas;

        #region ctor
        public Dinosaur(int size, Panel parent,int lives = 1 )
        {
            this.gameCanvas = parent;
            this.Parent = parent;
            this.BackColor = Color.DarkGreen;
            this.Size = new Size(size, size);
            this.Location = new Point((int)(size * 1.5), gameCanvas.Height - size);
            this.Lives = lives;
        }



        #endregion

        public void Jump()
        {
            if (onGround)
            {
                jumpSpeed = 8.5f;
                this.Location = new Point(this.Location.X, this.Location.Y - (int)jumpSpeed);
                onGround = false;
            }
        }

        new public void Update()
        {
            if (!onGround)
            {
                this.Location = new Point(this.Location.X, (int)(this.Location.Y - jumpSpeed));
                jumpSpeed -= Settings.Gravity;
                if (this.Location.Y >= gameCanvas.Height - this.Height)
                {
                    onGround = true;
                    this.Location = new Point(this.Location.X, gameCanvas.Height - this.Height);
                }
            }
        }

    }
}
