namespace NoInternetDinosaur
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameCanvas = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.obstacleTimer = new System.Windows.Forms.Timer(this.components);
            this.CollisonDetection = new System.Windows.Forms.Timer(this.components);
            this.gameCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.Color.BurlyWood;
            this.gameCanvas.Controls.Add(this.infoLabel);
            this.gameCanvas.Controls.Add(this.scoreLabel);
            this.gameCanvas.Location = new System.Drawing.Point(0, 65);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(686, 195);
            this.gameCanvas.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(196, 87);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(283, 25);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "Press Space, arrow Up or W";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(47, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameTick
            // 
            this.gameTick.Interval = 1;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "No Internet!";
            // 
            // obstacleTimer
            // 
            this.obstacleTimer.Interval = 1200;
            this.obstacleTimer.Tick += new System.EventHandler(this.obstacleTimer_Tick);
            // 
            // CollisonDetection
            // 
            this.CollisonDetection.Interval = 1;
            this.CollisonDetection.Tick += new System.EventHandler(this.CollisonDetection_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "No Internet!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gameCanvas.ResumeLayout(false);
            this.gameCanvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel gameCanvas;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer obstacleTimer;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer CollisonDetection;
    }
}

