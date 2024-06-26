﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytypingGameProject
{
    public partial class Form1 : Form
    {
        long score = 0; int topDistance=2;
        int totalKeyPresses = 0;
        int correctKeyPresses = 0;
        private List<Label> labels = new List<Label>();
        const int totalCharactersToType = 10; // Adjust as needed

        DateTime startTime;
        DateTime endTime;
        double typingSpeed;

        public Form1()
        {
            InitializeComponent();
            InitializeLabels();
            InitializeScoreAndAccuracyLabels();
            StyleButtons();

            // Set dark mode background color
            this.BackColor = Color.FromArgb(30, 30, 30);
        }

        // Initialize additional labels and style the original label
        private void InitializeLabels()
        {
            StyleLabel(label_char_test);
            labels.Add(label_char_test); // Ensure this label exists in the designer

            for (int i = 1; i <= 5; i++)
            {
                Label lbl = new Label
                {
                    AutoSize = true,
                    Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White, // Set the text color to white
                    BackColor = Color.Transparent, // Set the background color to transparent
                    Location = getNewPoint(i),
                    Text = GetRandomCharater().ToString(),
                    Name = "label_char_test" + i
                };
                panel_test.Controls.Add(lbl);
                labels.Add(lbl);
            }

            // Set panel background color
            panel_test.BackColor = Color.Transparent;

            // Ensure the accuracy label is styled and reset
            StyleLabel(label_accuracy);
            label_accuracy.Text = "Accuracy: 0%";

            // Add label to display typing speed
            //StyleLabel(label_speed);
            label_speed.Text = "Typing Speed: -- CPM"; // Initial value
           // label_speed.Location = new Point(panel_test.Left, label_accuracy.Bottom + 10);
            this.Controls.Add(label_speed);
        }

        // Initialize the score and accuracy labels
        private void InitializeScoreAndAccuracyLabels()
        {
            StyleInfoLabel(label_score);
            StyleInfoLabel(label_accuracy);
            StyleInfoLabel(label_speed);
            StyleInfoLabel(themes_label);
            // Position the labels below the panel
            //label_score.Location = new Point(panel_test.Left, panel_test.Bottom + 10);
            // label_accuracy.Location = new Point(panel_test.Left, label_score.Bottom + 10);
        }

        // Apply the same styling to the original label
        private void StyleLabel(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = Color.White;
            label.BackColor = Color.Transparent;
        }

        // Apply consistent styling to info labels (score and accuracy)
        private void StyleInfoLabel(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = Color.White; // Set text color to white for better visibility
            label.BackColor = Color.Transparent;
        }

        //*********************************    start  ******************

        private void start_btn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            startTime = DateTime.Now; // Record the start time
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = GetRandomCharater().ToString();
                labels[i].Location = getNewPoint(i);
            }
        }

        //******************  close / end  ***********************

        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            score = 0;
            totalKeyPresses = 0;
            correctKeyPresses = 0;
            label_score.Text = "Score " + score;
            label_accuracy.Text = "Accuracy: 0%";
            foreach (Label lbl in labels)
            {
                lbl.Location = new Point(200, 100);
                lbl.Text = "";
            }
        }

        //******************** stop **********************
        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (stop_btn.Text == "Stop")
            {
                gameTimer.Stop();
                stop_btn.Text = "Resume";
            }
            else if (stop_btn.Text == "Resume")
            {
                gameTimer.Start();
                stop_btn.Text = "Stop";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //*************************************************************

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Label lbl in labels)
            {
                lbl.Top += topDistance; 
                if (lbl.Top >= panel_test.Height)
                {
                    score -= 5;
                    label_score.Text = "Score " + score;
                    lbl.Location = getNewPoint(labels.IndexOf(lbl));
                    lbl.Text = GetRandomCharater().ToString();
                }
            }
            UpdateTypingSpeed();
        } //***************************************************

        //*************** choose character *************************

        Random randomCharacter = new Random();
        private char GetRandomCharater()
        {
            // randomly choose char 
            return (char)randomCharacter.Next(97, 123);
        }

        //***************************** position ****************

        private Point getNewPoint(int index)
        {
            // Divide panel width into equal segments and place labels within these segments
            int segmentWidth = panel_test.Width / labels.Count;
            int x = segmentWidth * index + (segmentWidth - label_char_test.Width) / 2;
            int y = randomCharacter.Next(0, panel_test.Height / 2); // Randomize the initial vertical position
            return new Point(x, y);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            Label matchedLabel = labels.FirstOrDefault(lbl => lbl.Text == userPressKey.ToString());

            totalKeyPresses++;
            if (matchedLabel != null)
            {
                correctKeyPresses++;
                score += 5;
                matchedLabel.Location = getNewPoint(labels.IndexOf(matchedLabel));
                matchedLabel.Text = GetRandomCharater().ToString();
            }
            else
            {
                score -= 5;
            }

            label_score.Text = "Score " + score;
            UpdateAccuracy();

            // Check if all characters are typed
            if (correctKeyPresses == totalCharactersToType)
            {
                // Calculate typing speed
                endTime = DateTime.Now;
                TimeSpan timeTaken = endTime - startTime;
                double minutesTaken = timeTaken.TotalMinutes;
                typingSpeed = totalCharactersToType / minutesTaken; // Characters per minute (CPM)

                // Display typing speed
                label_speed.Text = $"Typing Speed: {typingSpeed:F2} CPM";
            }
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Form1_KeyPress(sender, e);
            UpdateTypingSpeed();
        }

        private void UpdateAccuracy()
        {
            double accuracy = 0;
            if (totalKeyPresses > 0)
            {
                accuracy = (double)correctKeyPresses / totalKeyPresses * 100;
            }
            label_accuracy.Text = $"Accuracy: {accuracy:F2}%";

        }
        private void StyleButtons()
        {
            // Style for start_btn
            start_btn.BackColor = Color.FromArgb(52, 152, 219); // Blue background color
            start_btn.ForeColor = Color.White; // White text color
            start_btn.Font = new Font("Arial", 12, FontStyle.Bold); // Bold Arial font, size 12
            level_1_btn.Font = new Font("Arial", 12, FontStyle.Bold);
            level_1_btn.ForeColor = Color.White;
            level_1_btn.BackColor = Color.FromArgb(52, 152, 219);


            // Create buttons (assuming you have buttons created in your form, otherwise you need to create them)
            // Example:
            // Button button2 = new Button();
            // Button button3 = new Button();
            // ...
            StyleButton(theme1);
            StyleButton(button2);
            StyleButton(button3);
            StyleButton(button4);
            StyleButton(button5);
            StyleButton(button6);
            StyleButton(button7);
            StyleButton(button8);
            StyleButton(button9);
            StyleButton(button10);
            StyleButton(button11);
            StyleButton(button12);


            // Style for stop_btn
            stop_btn.BackColor = Color.FromArgb(231, 76, 60); // Red background color
            stop_btn.ForeColor = Color.White; // White text color
            stop_btn.Font = new Font("Arial", 12, FontStyle.Bold); // Bold Arial font, size 12
            level_2_btn.BackColor = Color.FromArgb(231, 76, 60);
            level_2_btn.ForeColor = Color.White;
            level_2_btn.Font = new Font("Arial", 12, FontStyle.Bold); // Bold Arial font, size 12

            // Style for button1
            button1.BackColor = Color.FromArgb(46, 204, 113); // Green background color
            button1.ForeColor = Color.White; // White text color
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            level_3_btn.BackColor = Color.FromArgb(46, 204, 113);
            level_3_btn.ForeColor = Color.White;
            level_3_btn.Font = new Font("Arial", 12, FontStyle.Bold);

            // Bold Arial font, size 12
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new FormScoreboard().Show();
            this.Hide();
        }

        private void labelBackLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void level_1_btn_Click(object sender, EventArgs e)
        {
            topDistance = 3;
        }

        private void level_2_btn_Click(object sender, EventArgs e)
        {
            topDistance = 5;
        }

        private void level_3_btn_Click(object sender, EventArgs e)
        {
            topDistance = 8;
        }

        private void UpdateTypingSpeed()
        {
            // Calculate typing speed
            if (totalKeyPresses > 0)
            {
                endTime = DateTime.Now;
                TimeSpan timeTaken = endTime - startTime;
                double minutesTaken = timeTaken.TotalMinutes;
                typingSpeed = correctKeyPresses / minutesTaken; // Characters per minute (CPM)
            }
            else
            {
                // If no key has been pressed, reduce the typing speed by a certain factor
                typingSpeed *= 0.9; // You can adjust the factor as needed
            }

            // Display typing speed
            label_speed.Text = $"Typing Speed: {typingSpeed:F2} CPM";
        }

        public void StyleButton(Button button)
        {
            button.BackColor = Color.DodgerBlue; // Initial background color
            button.ForeColor = Color.White; // Text color
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat; // Flat style for a modern look
            button.FlatAppearance.BorderSize = 0; // Remove border
            button.Cursor = Cursors.Hand; // Change cursor to hand when hovering

            // Handle the MouseEnter and MouseLeave events to create a hover effect
            button.MouseEnter += (s, e) =>
            {
                button.BackColor = Color.RoyalBlue; // Change to hover color
            };

            button.MouseLeave += (s, e) =>
            {
                button.BackColor = Color.DodgerBlue; // Restore original color
            };
        }
        private void theme1_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.Frame1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.Capture1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.Frame2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources._8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.s;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.dd1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.dfd;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.new8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.new9;

        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.new11;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel_test.BackgroundImage = Properties.Resources.final;

        }

        private void labelBack1_Click(object sender, EventArgs e)
        {
            new FormStart().Show();
            this.Hide();
        }
    }
}
