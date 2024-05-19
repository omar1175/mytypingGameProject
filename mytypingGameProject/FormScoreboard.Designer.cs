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
            this.labelBack2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBack2
            // 
            this.labelBack2.AutoSize = true;
            this.labelBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack2.ForeColor = System.Drawing.Color.Blue;
            this.labelBack2.Location = new System.Drawing.Point(12, 422);
            this.labelBack2.Name = "labelBack2";
            this.labelBack2.Size = new System.Drawing.Size(42, 19);
            this.labelBack2.TabIndex = 9;
            this.labelBack2.Text = "Back ";
            this.labelBack2.Click += new System.EventHandler(this.labelShowScoreboard_Click);
            // 
            // FormScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBack2);
            this.Name = "FormScoreboard";
            this.Text = "FormScoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBack2;
    }
}