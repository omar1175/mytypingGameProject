namespace mytypingGameProject
{
    partial class FormScoreboard
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
            this.labelBackGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBackGame
            // 
            this.labelBackGame.AutoSize = true;
            this.labelBackGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackGame.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackGame.ForeColor = System.Drawing.Color.Blue;
            this.labelBackGame.Location = new System.Drawing.Point(12, 422);
            this.labelBackGame.Name = "labelBackGame";
            this.labelBackGame.Size = new System.Drawing.Size(121, 19);
            this.labelBackGame.TabIndex = 9;
            this.labelBackGame.Text = "Back to the game ";
            this.labelBackGame.Click += new System.EventHandler(this.labelShowScoreboard_Click);
            // 
            // FormScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBackGame);
            this.Name = "FormScoreboard";
            this.Text = "FormScoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackGame;
    }
}