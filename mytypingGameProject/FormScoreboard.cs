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
    public partial class FormScoreboard : Form
    {
        public FormScoreboard()
        {
            InitializeComponent();
        }

        private void labelShowScoreboard_Click(object sender, EventArgs e)
        {
            new FormStart().Show();
            this.Hide();
        }
    }
}
