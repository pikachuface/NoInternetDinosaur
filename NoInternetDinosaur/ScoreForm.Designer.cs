namespace NoInternetDinosaur
{
    partial class ScoreForm
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newScorePanel = new System.Windows.Forms.Panel();
            this.newScoreClosebtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.newScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(0, 42);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(296, 254);
            this.outputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highscore Board";
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(209, 307);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(6, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(38, 21);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newScorePanel
            // 
            this.newScorePanel.Controls.Add(this.newScoreClosebtn);
            this.newScorePanel.Controls.Add(this.addBtn);
            this.newScorePanel.Controls.Add(this.inputNameBox);
            this.newScorePanel.Controls.Add(this.NameLabel);
            this.newScorePanel.Controls.Add(this.scoreLabel);
            this.newScorePanel.Location = new System.Drawing.Point(0, 0);
            this.newScorePanel.Name = "newScorePanel";
            this.newScorePanel.Size = new System.Drawing.Size(296, 102);
            this.newScorePanel.TabIndex = 4;
            this.newScorePanel.Visible = false;
            // 
            // newScoreClosebtn
            // 
            this.newScoreClosebtn.Location = new System.Drawing.Point(111, 57);
            this.newScoreClosebtn.Name = "newScoreClosebtn";
            this.newScoreClosebtn.Size = new System.Drawing.Size(75, 23);
            this.newScoreClosebtn.TabIndex = 2;
            this.newScoreClosebtn.Text = "Close";
            this.newScoreClosebtn.UseVisualStyleBackColor = true;
            this.newScoreClosebtn.Click += new System.EventHandler(this.newScoreClosebtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(192, 57);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Okay";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // inputNameBox
            // 
            this.inputNameBox.Location = new System.Drawing.Point(57, 31);
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.Size = new System.Drawing.Size(210, 20);
            this.inputNameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: ";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.newScorePanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScoreForm";
            this.Text = "Score";
            this.newScorePanel.ResumeLayout(false);
            this.newScorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel newScorePanel;
        private System.Windows.Forms.Button newScoreClosebtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}