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
            this.circularButtonScoreboard = new mytypingGameProject.CircularButton();
            this.labelBackLogout1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circularButtonStartGame
            // 
            this.circularButtonStartGame.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.circularButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtonStartGame.ForeColor = System.Drawing.Color.White;
            this.circularButtonStartGame.Location = new System.Drawing.Point(167, 74);
            this.circularButtonStartGame.Name = "circularButtonStartGame";
            this.circularButtonStartGame.Size = new System.Drawing.Size(146, 137);
            this.circularButtonStartGame.TabIndex = 0;
            this.circularButtonStartGame.Text = "Start Game";
            this.circularButtonStartGame.UseVisualStyleBackColor = false;
            this.circularButtonStartGame.Click += new System.EventHandler(this.circularButtonStartGame_Click);
            // 
            // circularButtonScoreboard
            // 
            this.circularButtonScoreboard.BackColor = System.Drawing.Color.MediumOrchid;
            this.circularButtonScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtonScoreboard.ForeColor = System.Drawing.Color.White;
            this.circularButtonScoreboard.Location = new System.Drawing.Point(167, 281);
            this.circularButtonScoreboard.Name = "circularButtonScoreboard";
            this.circularButtonScoreboard.Size = new System.Drawing.Size(146, 137);
            this.circularButtonScoreboard.TabIndex = 1;
            this.circularButtonScoreboard.Text = "Scoreboard";
            this.circularButtonScoreboard.UseVisualStyleBackColor = false;
            this.circularButtonScoreboard.Click += new System.EventHandler(this.circularButtonScoreboard_Click);
            // 
            // labelBackLogout1
            // 
            this.labelBackLogout1.AutoSize = true;
            this.labelBackLogout1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackLogout1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackLogout1.ForeColor = System.Drawing.Color.Blue;
            this.labelBackLogout1.Location = new System.Drawing.Point(12, 20);
            this.labelBackLogout1.Name = "labelBackLogout1";
            this.labelBackLogout1.Size = new System.Drawing.Size(53, 19);
            this.labelBackLogout1.TabIndex = 10;
            this.labelBackLogout1.Text = "Logout";
            this.labelBackLogout1.Click += new System.EventHandler(this.labelBackLogout1_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(475, 488);
            this.Controls.Add(this.labelBackLogout1);
            this.Controls.Add(this.circularButtonScoreboard);
            this.Controls.Add(this.circularButtonStartGame);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton circularButtonStartGame;
        private CircularButton circularButtonScoreboard;
        private System.Windows.Forms.Label labelBackLogout1;
    }
}