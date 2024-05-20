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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void labelBackGame_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void circularButtonStartGame_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void circularButtonScorboard_Click(object sender, EventArgs e)
        {
            new FormScoreboard().Show();
            this.Hide();
        }
    }
}
