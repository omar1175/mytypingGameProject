namespace mytypingGameProject
{
    partial class FormLogin
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
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.labelDontHaveAccount = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPasswordLogin = new System.Windows.Forms.CheckBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.labelUserNameLogin = new System.Windows.Forms.Label();
            this.labelStart2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackToLogin.ForeColor = System.Drawing.Color.Teal;
            this.labelBackToLogin.Location = new System.Drawing.Point(108, 521);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(101, 17);
            this.labelBackToLogin.TabIndex = 25;
            this.labelBackToLogin.Text = "Create Account";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            // 
            // labelDontHaveAccount
            // 
            this.labelDontHaveAccount.AutoSize = true;
            this.labelDontHaveAccount.Location = new System.Drawing.Point(94, 493);
            this.labelDontHaveAccount.Name = "labelDontHaveAccount";
            this.labelDontHaveAccount.Size = new System.Drawing.Size(128, 17);
            this.labelDontHaveAccount.TabIndex = 24;
            this.labelDontHaveAccount.Text = "Dont Have Account";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Teal;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(71, 431);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(205, 41);
            this.buttonLogin.TabIndex = 21;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxShowPasswordLogin
            // 
            this.checkBoxShowPasswordLogin.AutoSize = true;
            this.checkBoxShowPasswordLogin.Location = new System.Drawing.Point(171, 301);
            this.checkBoxShowPasswordLogin.Name = "checkBoxShowPasswordLogin";
            this.checkBoxShowPasswordLogin.Size = new System.Drawing.Size(122, 21);
            this.checkBoxShowPasswordLogin.TabIndex = 20;
            this.checkBoxShowPasswordLogin.Text = "Show Password";
            this.checkBoxShowPasswordLogin.UseVisualStyleBackColor = true;
            this.checkBoxShowPasswordLogin.CheckedChanged += new System.EventHandler(this.checkBoxShowPasswordLogin_CheckedChanged);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(68, 254);
            this.textBoxPasswordLogin.Multiline = true;
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '*';
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(225, 30);
            this.textBoxPasswordLogin.TabIndex = 17;
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Location = new System.Drawing.Point(68, 234);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(66, 17);
            this.labelPasswordLogin.TabIndex = 16;
            this.labelPasswordLogin.Text = "Password";
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUserNameLogin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(68, 175);
            this.textBoxUserNameLogin.Multiline = true;
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(225, 30);
            this.textBoxUserNameLogin.TabIndex = 15;
            // 
            // labelUserNameLogin
            // 
            this.labelUserNameLogin.AutoSize = true;
            this.labelUserNameLogin.Location = new System.Drawing.Point(65, 155);
            this.labelUserNameLogin.Name = "labelUserNameLogin";
            this.labelUserNameLogin.Size = new System.Drawing.Size(69, 17);
            this.labelUserNameLogin.TabIndex = 14;
            this.labelUserNameLogin.Text = "Username";
            // 
            // labelStart2
            // 
            this.labelStart2.AutoSize = true;
            this.labelStart2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart2.ForeColor = System.Drawing.Color.Teal;
            this.labelStart2.Location = new System.Drawing.Point(81, 77);
            this.labelStart2.Name = "labelStart2";
            this.labelStart2.Size = new System.Drawing.Size(185, 33);
            this.labelStart2.TabIndex = 13;
            this.labelStart2.Text = "Typing Test";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.labelDontHaveAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxShowPasswordLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.textBoxUserNameLogin);
            this.Controls.Add(this.labelUserNameLogin);
            this.Controls.Add(this.labelStart2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackToLogin;
        private System.Windows.Forms.Label labelDontHaveAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPasswordLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUserNameLogin;
        private System.Windows.Forms.Label labelUserNameLogin;
        private System.Windows.Forms.Label labelStart2;
    }
}