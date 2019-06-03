namespace SimonSays
{
    partial class Form1
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
            this.Orange = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Orange
            // 
            this.Orange.AutoSize = true;
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(12, 12);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(75, 73);
            this.Orange.TabIndex = 0;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(12, 249);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(156, 43);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(12, 91);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(75, 73);
            this.Blue.TabIndex = 7;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(12, 170);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(75, 73);
            this.Green.TabIndex = 8;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Purple
            // 
            this.Purple.AutoSize = true;
            this.Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Purple.Location = new System.Drawing.Point(93, 12);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(75, 73);
            this.Purple.TabIndex = 9;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(93, 91);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(75, 73);
            this.Red.TabIndex = 10;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(93, 170);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(75, 73);
            this.Yellow.TabIndex = 11;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(12, 295);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(47, 13);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score: 0";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Location = new System.Drawing.Point(96, 295);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(72, 13);
            this.HighScore.TabIndex = 13;
            this.HighScore.Text = "High Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(175, 313);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Orange);
            this.Name = "Form1";
            this.Text = "Simon Says";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label HighScore;
    }
}

