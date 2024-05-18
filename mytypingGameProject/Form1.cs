using System;
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
        long score = 0;
        public Form1()
        {
            InitializeComponent();
        }

       //*********************************    start  ******************

        private void start_btn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            // randomly choose char
            label_char_test.Text = GetRandomCharater().ToString();
            // randomly choose char location
            label_char_test.Location = getNewPoint();

        }

        //******************  close / end  ***********************

        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            score = 0;
            label_score.Text = "Score " + score;
            label_char_test.Location = new Point(200, 100);
            label_char_test.Text = "";
        }

        //******************** stop **********************
        private void stop_btn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
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
            // increas top pixsels by 5
            label_char_test.Top += 5;
            // when char reach bottom
            if (label_char_test.Top >= panel_test.Height)
            {

                score -= 5;
                label_score.Text = "Score " + score;
                // randomly choose char location
                label_char_test.Location = getNewPoint();
                // randomly choose char
                label_char_test.Text = GetRandomCharater().ToString();
            }

        } //***************************************************


        //*************** choose character *************************


        Random randomRharacter = new Random();
        private char GetRandomCharater()
        {
            // rendomly choose char 
            return (char)randomRharacter.Next(97, 123);
        }


        //***************************** position ****************


        Random xLocation = new Random();
        private Point getNewPoint()
        {
            // randomly choose x from zero to the panal width - label width
            // and y = 0 
            int x = xLocation.Next(0, panel_test.Width - label_char_test.Width);
            return new Point(x, 0);
        }

        
            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            if (label_char_test.Text == userPressKey.ToString())
            {
                score += 5;
                label_score.Text = "Score " + score;
                label_char_test.Location = getNewPoint();
                label_char_test.Text = GetRandomCharater().ToString();
            }
            else
            {
                score -= 5;
                label_score.Text = "Score " + score;
            }
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            if (label_char_test.Text == userPressKey.ToString())
            {
                score += 5;
                label_score.Text = "Score " + score;
                label_char_test.Location = getNewPoint();
                label_char_test.Text = GetRandomCharater().ToString();
            }
            else
            {
                score -= 5;
                label_score.Text = "Score " + score;
            }
        }
    }
}
