namespace mytypingGameProject
{
    partial class FormRegister
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
            this.labelStart1 = new System.Windows.Forms.Label();
            this.labelUserNameRegister = new System.Windows.Forms.Label();
            this.textBoxUserNameRegister = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.labelPasswordRegister = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPasswordRegister = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelAlreadyHaveAccount = new System.Windows.Forms.Label();
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStart1
            // 
            this.labelStart1.AutoSize = true;
            this.labelStart1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart1.ForeColor = System.Drawing.Color.Teal;
            this.labelStart1.Location = new System.Drawing.Point(72, 33);
            this.labelStart1.Name = "labelStart1";
            this.labelStart1.Size = new System.Drawing.Size(185, 33);
            this.labelStart1.TabIndex = 0;
            this.labelStart1.Text = "Typing Test";
            this.labelStart1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUserNameRegister
            // 
            this.labelUserNameRegister.AutoSize = true;
            this.labelUserNameRegister.Location = new System.Drawing.Point(56, 111);
            this.labelUserNameRegister.Name = "labelUserNameRegister";
            this.labelUserNameRegister.Size = new System.Drawing.Size(69, 17);
            this.labelUserNameRegister.TabIndex = 1;
            this.labelUserNameRegister.Text = "Username";
            // 
            // textBoxUserNameRegister
            // 
            this.textBoxUserNameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUserNameRegister.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameRegister.Location = new System.Drawing.Point(59, 131);
            this.textBoxUserNameRegister.Multiline = true;
            this.textBoxUserNameRegister.Name = "textBoxUserNameRegister";
            this.textBoxUserNameRegister.Size = new System.Drawing.Size(225, 30);
            this.textBoxUserNameRegister.TabIndex = 2;
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPasswordRegister.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(59, 268);
            this.textBoxPasswordRegister.Multiline = true;
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.PasswordChar = '*';
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(225, 30);
            this.textBoxPasswordRegister.TabIndex = 4;
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.AutoSize = true;
            this.labelPasswordRegister.Location = new System.Drawing.Point(59, 248);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(66, 17);
            this.labelPasswordRegister.TabIndex = 3;
            this.labelPasswordRegister.Text = "Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(59, 340);
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(225, 30);
            this.textBoxConfirmPassword.TabIndex = 6;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(59, 320);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(120, 17);
            this.labelConfirmPassword.TabIndex = 5;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // checkBoxShowPasswordRegister
            // 
            this.checkBoxShowPasswordRegister.AutoSize = true;
            this.checkBoxShowPasswordRegister.Location = new System.Drawing.Point(162, 376);
            this.checkBoxShowPasswordRegister.Name = "checkBoxShowPasswordRegister";
            this.checkBoxShowPasswordRegister.Size = new System.Drawing.Size(122, 21);
            this.checkBoxShowPasswordRegister.TabIndex = 7;
            this.checkBoxShowPasswordRegister.Text = "Show Password";
            this.checkBoxShowPasswordRegister.UseVisualStyleBackColor = true;
            this.checkBoxShowPasswordRegister.CheckedChanged += new System.EventHandler(this.checkBoxShowPasswordRegister_CheckedChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Teal;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(62, 429);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(205, 41);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(59, 180);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(58, 17);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Palestine",
            "Qatar ",
            "Saudi Arabia",
            "Egypt",
            "Jordan",
            "Kuwait",
            "Lebanon",
            "Morocco",
            "Oman"});
            this.comboBoxCountry.Location = new System.Drawing.Point(62, 200);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(222, 25);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // labelAlreadyHaveAccount
            // 
            this.labelAlreadyHaveAccount.AutoSize = true;
            this.labelAlreadyHaveAccount.Location = new System.Drawing.Point(85, 491);
            this.labelAlreadyHaveAccount.Name = "labelAlreadyHaveAccount";
            this.labelAlreadyHaveAccount.Size = new System.Drawing.Size(144, 17);
            this.labelAlreadyHaveAccount.TabIndex = 11;
            this.labelAlreadyHaveAccount.Text = "Already Have Account";
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackToLogin.ForeColor = System.Drawing.Color.Teal;
            this.labelBackToLogin.Location = new System.Drawing.Point(107, 518);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(97, 17);
            this.labelBackToLogin.TabIndex = 12;
            this.labelBackToLogin.Text = "Back to LOGIN";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.labelAlreadyHaveAccount);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.checkBoxShowPasswordRegister);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxPasswordRegister);
            this.Controls.Add(this.labelPasswordRegister);
            this.Controls.Add(this.textBoxUserNameRegister);
            this.Controls.Add(this.labelUserNameRegister);
            this.Controls.Add(this.labelStart1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegister";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart1;
        private System.Windows.Forms.Label labelUserNameRegister;
        private System.Windows.Forms.TextBox textBoxUserNameRegister;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.Label labelPasswordRegister;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPasswordRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelAlreadyHaveAccount;
        private System.Windows.Forms.Label labelBackToLogin;
    }
}