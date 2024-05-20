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
            this.labelShowScoreboard = new System.Windows.Forms.Label();
            this.labelBackLogout = new System.Windows.Forms.Label();
            this.level_1_btn = new System.Windows.Forms.Button();
            this.level_2_btn = new System.Windows.Forms.Button();
            this.level_3_btn = new System.Windows.Forms.Button();
            this.theme1 = new System.Windows.Forms.Button();
            this.themes_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel_test = new System.Windows.Forms.Panel();
            this.label_char_test = new System.Windows.Forms.Label();
            this.panel_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(47, 712);
            this.start_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(136, 39);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(190, 713);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(136, 39);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 712);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_score
            // 
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(44, 601);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(141, 31);
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
            this.label_accuracy.Location = new System.Drawing.Point(186, 601);
            this.label_accuracy.Name = "label_accuracy";
            this.label_accuracy.Size = new System.Drawing.Size(168, 29);
            this.label_accuracy.TabIndex = 5;
            this.label_accuracy.Text = "Accuracy: 0%";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed.Location = new System.Drawing.Point(423, 601);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(104, 29);
            this.label_speed.TabIndex = 6;
            this.label_speed.Text = "Speed: ";
            // 
            // labelShowScoreboard
            // 
            this.labelShowScoreboard.AutoSize = true;
            this.labelShowScoreboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShowScoreboard.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowScoreboard.ForeColor = System.Drawing.Color.Blue;
            this.labelShowScoreboard.Location = new System.Drawing.Point(656, 744);
            this.labelShowScoreboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowScoreboard.Name = "labelShowScoreboard";
            this.labelShowScoreboard.Size = new System.Drawing.Size(158, 23);
            this.labelShowScoreboard.TabIndex = 8;
            this.labelShowScoreboard.Text = "Show Scoreboard ";
            this.labelShowScoreboard.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBackLogout
            // 
            this.labelBackLogout.AutoSize = true;
            this.labelBackLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackLogout.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackLogout.ForeColor = System.Drawing.Color.Blue;
            this.labelBackLogout.Location = new System.Drawing.Point(513, 744);
            this.labelBackLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackLogout.Name = "labelBackLogout";
            this.labelBackLogout.Size = new System.Drawing.Size(68, 23);
            this.labelBackLogout.TabIndex = 9;
            this.labelBackLogout.Text = "Logout";
            this.labelBackLogout.Click += new System.EventHandler(this.labelBackLogout_Click);
            // 
            // level_1_btn
            // 
            this.level_1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_1_btn.Location = new System.Drawing.Point(48, 649);
            this.level_1_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level_1_btn.Name = "level_1_btn";
            this.level_1_btn.Size = new System.Drawing.Size(136, 39);
            this.level_1_btn.TabIndex = 10;
            this.level_1_btn.Text = "Level 1 ";
            this.level_1_btn.UseVisualStyleBackColor = true;
            this.level_1_btn.Click += new System.EventHandler(this.level_1_btn_Click);
            // 
            // level_2_btn
            // 
            this.level_2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_2_btn.Location = new System.Drawing.Point(190, 649);
            this.level_2_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level_2_btn.Name = "level_2_btn";
            this.level_2_btn.Size = new System.Drawing.Size(136, 39);
            this.level_2_btn.TabIndex = 11;
            this.level_2_btn.Text = "Level 2";
            this.level_2_btn.UseVisualStyleBackColor = true;
            this.level_2_btn.Click += new System.EventHandler(this.level_2_btn_Click);
            // 
            // level_3_btn
            // 
            this.level_3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_3_btn.Location = new System.Drawing.Point(332, 649);
            this.level_3_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level_3_btn.Name = "level_3_btn";
            this.level_3_btn.Size = new System.Drawing.Size(136, 39);
            this.level_3_btn.TabIndex = 12;
            this.level_3_btn.Text = "Level 3 ";
            this.level_3_btn.UseVisualStyleBackColor = true;
            this.level_3_btn.Click += new System.EventHandler(this.level_3_btn_Click);
            // 
            // theme1
            // 
            this.theme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme1.Location = new System.Drawing.Point(874, 628);
            this.theme1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theme1.Name = "theme1";
            this.theme1.Size = new System.Drawing.Size(65, 39);
            this.theme1.TabIndex = 13;
            this.theme1.Text = "1 ";
            this.theme1.UseVisualStyleBackColor = true;
            this.theme1.Click += new System.EventHandler(this.theme1_Click);
            // 
            // themes_label
            // 
            this.themes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themes_label.Location = new System.Drawing.Point(942, 584);
            this.themes_label.Name = "themes_label";
            this.themes_label.Size = new System.Drawing.Size(100, 31);
            this.themes_label.TabIndex = 1;
            this.themes_label.Text = "Themes";
            this.themes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(946, 628);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1017, 628);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1088, 628);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(874, 669);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 39);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(946, 669);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 39);
            this.button6.TabIndex = 18;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1017, 669);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 39);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1088, 669);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 39);
            this.button8.TabIndex = 20;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(874, 710);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 39);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(946, 710);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 38);
            this.button10.TabIndex = 0;
            this.button10.Text = "10";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1017, 710);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 39);
            this.button11.TabIndex = 22;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(1088, 710);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 39);
            this.button12.TabIndex = 23;
            this.button12.Text = "12 ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel_test
            // 
            this.panel_test.BackgroundImage = global::mytypingGameProject.Properties.Resources.Frame1;
            this.panel_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_test.Controls.Add(this.label_char_test);
            this.panel_test.Location = new System.Drawing.Point(3, 0);
            this.panel_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(1287, 582);
            this.panel_test.TabIndex = 0;
            this.panel_test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_char_test
            // 
            this.label_char_test.BackColor = System.Drawing.SystemColors.Info;
            this.label_char_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_char_test.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_char_test.Location = new System.Drawing.Point(364, 85);
            this.label_char_test.Name = "label_char_test";
            this.label_char_test.Size = new System.Drawing.Size(45, 49);
            this.label_char_test.TabIndex = 0;
            this.label_char_test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 761);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.themes_label);
            this.Controls.Add(this.theme1);
            this.Controls.Add(this.level_3_btn);
            this.Controls.Add(this.level_2_btn);
            this.Controls.Add(this.level_1_btn);
            this.Controls.Add(this.labelBackLogout);
            this.Controls.Add(this.labelShowScoreboard);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_accuracy);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label labelShowScoreboard;
        private System.Windows.Forms.Label labelBackLogout;
        private System.Windows.Forms.Button level_1_btn;
        private System.Windows.Forms.Button level_2_btn;
        private System.Windows.Forms.Button level_3_btn;
        private System.Windows.Forms.Button theme1;
        private System.Windows.Forms.Label themes_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

