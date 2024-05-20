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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameRegister.Text == "" || textBoxPasswordRegister.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Username or Password is empty", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPasswordRegister.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords does not match", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPasswordRegister.Text = "";
                textBoxConfirmPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Your Account has been successfully created", "Regisration succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FormStart().Show();
                this.Hide();
            }
        }

        private void checkBoxShowPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPasswordRegister.Checked)
            {
                textBoxPasswordRegister.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordRegister.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';

            }
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
