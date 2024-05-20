namespace mytypingGameProject
{
    partial class FormStart
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
            this.circularButtonStartGame = new mytypingGameProject.CircularButton();
            this.circularButtonScorboard = new mytypingGameProject.CircularButton();
            this.labelBackGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circularButtonStartGame
            // 
            this.circularButtonStartGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.circularButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonStartGame.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtonStartGame.ForeColor = System.Drawing.Color.White;
            this.circularButtonStartGame.Location = new System.Drawing.Point(226, 108);
            this.circularButtonStartGame.Name = "circularButtonStartGame";
            this.circularButtonStartGame.Size = new System.Drawing.Size(149, 146);
            this.circularButtonStartGame.TabIndex = 0;
            this.circularButtonStartGame.Text = "Start Game";
            this.circularButtonStartGame.UseVisualStyleBackColor = false;
            this.circularButtonStartGame.Click += new System.EventHandler(this.circularButtonStartGame_Click);
            // 
            // circularButtonScorboard
            // 
            this.circularButtonScorboard.BackColor = System.Drawing.Color.Plum;
            this.circularButtonScorboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonScorboard.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtonScorboard.ForeColor = System.Drawing.Color.White;
            this.circularButtonScorboard.Location = new System.Drawing.Point(226, 334);
            this.circularButtonScorboard.Name = "circularButtonScorboard";
            this.circularButtonScorboard.Size = new System.Drawing.Size(149, 146);
            this.circularButtonScorboard.TabIndex = 1;
            this.circularButtonScorboard.Text = "Scoreboard";
            this.circularButtonScorboard.UseVisualStyleBackColor = false;
            this.circularButtonScorboard.Click += new System.EventHandler(this.circularButtonScorboard_Click);
            // 
            // labelBackGame
            // 
            this.labelBackGame.AutoSize = true;
            this.labelBackGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackGame.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackGame.ForeColor = System.Drawing.Color.Blue;
            this.labelBackGame.Location = new System.Drawing.Point(32, 26);
            this.labelBackGame.Name = "labelBackGame";
            this.labelBackGame.Size = new System.Drawing.Size(53, 19);
            this.labelBackGame.TabIndex = 10;
            this.labelBackGame.Text = "Logout";
            this.labelBackGame.Click += new System.EventHandler(this.labelBackGame_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 522);
            this.Controls.Add(this.labelBackGame);
            this.Controls.Add(this.circularButtonScorboard);
            this.Controls.Add(this.circularButtonStartGame);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton circularButtonStartGame;
        private CircularButton circularButtonScorboard;
        private System.Windows.Forms.Label labelBackGame;
    }
}