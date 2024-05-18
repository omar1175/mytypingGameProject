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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameLogin.Text == "" || textBoxPasswordLogin.Text == "")
            {
                MessageBox.Show("Username or Password is empty", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your have been logged in successfully", "Regisration succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form1().Show();
                this.Hide();
            }
        }

        private void checkBoxShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPasswordLogin.Checked)
            {
                textBoxPasswordLogin.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordLogin.PasswordChar = '*';
            }
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
