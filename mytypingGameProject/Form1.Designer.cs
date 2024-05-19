namespace mytypingGameProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_score = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label_accuracy = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBack1 = new System.Windows.Forms.Label();
            this.panel_test = new System.Windows.Forms.Panel();
            this.label_char_test = new System.Windows.Forms.Label();
            this.panel_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(505, 499);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(102, 32);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(625, 499);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(102, 32);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(745, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_score
            // 
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(22, 419);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(106, 25);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "score: ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vecteezy_red-heart-in-pixel-art-style-8-bit-icon-valentine-s-day_5644880.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label_accuracy
            // 
            this.label_accuracy.AutoSize = true;
            this.label_accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accuracy.Location = new System.Drawing.Point(22, 470);
            this.label_accuracy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_accuracy.Name = "label_accuracy";
            this.label_accuracy.Size = new System.Drawing.Size(136, 24);
            this.label_accuracy.TabIndex = 5;
            this.label_accuracy.Text = "Accuracy: 0%";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed.Location = new System.Drawing.Point(22, 518);
            this.label_speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(83, 24);
            this.label_speed.TabIndex = 6;
            this.label_speed.Text = "Speed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // labelBack1
            // 
            this.labelBack1.AutoSize = true;
            this.labelBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack1.ForeColor = System.Drawing.Color.Blue;
            this.labelBack1.Location = new System.Drawing.Point(35, 569);
            this.labelBack1.Name = "labelBack1";
            this.labelBack1.Size = new System.Drawing.Size(38, 19);
            this.labelBack1.TabIndex = 9;
            this.labelBack1.Text = "Back";
            this.labelBack1.Click += new System.EventHandler(this.labelBackLogout_Click);
            // 
            // panel_test
            // 
            this.panel_test.BackgroundImage = global::mytypingGameProject.Properties.Resources._15Z_2102_w026_n002_163B_p1_163;
            this.panel_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_test.Controls.Add(this.label_char_test);
            this.panel_test.Location = new System.Drawing.Point(2, 0);
            this.panel_test.Margin = new System.Windows.Forms.Padding(2);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(965, 375);
            this.panel_test.TabIndex = 0;
            this.panel_test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_char_test
            // 
            this.label_char_test.BackColor = System.Drawing.SystemColors.Info;
            this.label_char_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_char_test.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_char_test.Location = new System.Drawing.Point(273, 69);
            this.label_char_test.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_char_test.Name = "label_char_test";
            this.label_char_test.Size = new System.Drawing.Size(34, 40);
            this.label_char_test.TabIndex = 0;
            this.label_char_test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 597);
            this.Controls.Add(this.labelBack1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_accuracy);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            this.panel_test.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label_char_test;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label_accuracy;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBack1;
    }
}

