using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytypingGameProject
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void circularButtonStartGame_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void circularButtonScoreboard_Click(object sender, EventArgs e)
        {
            new FormScoreboard().Show();
            this.Hide();
        }

        private void labelBackLogout1_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
