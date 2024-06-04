using System;
using System.Security.Cryptography;


namespace Interface
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel1 = new Panel();
            labelUsernameStatus = new Label();
            label2 = new Label();
            haveAcount = new Label();
            buttonClear = new Button();
            buttonRegister = new Button();
            checkBoxShowPassword = new CheckBox();
            textPasswordConfirm = new TextBox();
            confirmPassword = new Label();
            textPassword = new TextBox();
            Password = new Label();
            textUsername = new TextBox();
            label1 = new Label();
            getStarted = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 100, 0, 0);
            panel1.Controls.Add(labelUsernameStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(haveAcount);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(textPasswordConfirm);
            panel1.Controls.Add(confirmPassword);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(textUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 400);
            panel1.TabIndex = 0;
            // 
            // labelUsernameStatus
            // 
            labelUsernameStatus.AutoSize = true;
            labelUsernameStatus.BackColor = Color.Khaki;
            labelUsernameStatus.Location = new Point(69, 62);
            labelUsernameStatus.Name = "labelUsernameStatus";
            labelUsernameStatus.Size = new Size(38, 15);
            labelUsernameStatus.TabIndex = 12;
            labelUsernameStatus.Text = "label3";
            labelUsernameStatus.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(112, 369);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 11;
            label2.Text = "Bakc to Login";
            label2.Click += label2_Click;
            // 
            // haveAcount
            // 
            haveAcount.AutoSize = true;
            haveAcount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            haveAcount.ForeColor = Color.Black;
            haveAcount.Location = new Point(81, 344);
            haveAcount.Name = "haveAcount";
            haveAcount.Size = new Size(153, 15);
            haveAcount.TabIndex = 10;
            haveAcount.Text = "Already Have An Account?";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Khaki;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.Brown;
            buttonClear.Location = new Point(69, 288);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(164, 40);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Brown;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.Khaki;
            buttonRegister.Location = new Point(69, 242);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(164, 40);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.ForeColor = Color.Khaki;
            checkBoxShowPassword.Location = new Point(70, 191);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(105, 19);
            checkBoxShowPassword.TabIndex = 1;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // textPasswordConfirm
            // 
            textPasswordConfirm.BackColor = SystemColors.Window;
            textPasswordConfirm.BorderStyle = BorderStyle.None;
            textPasswordConfirm.Font = new Font("Segoe UI", 12F);
            textPasswordConfirm.Location = new Point(69, 159);
            textPasswordConfirm.Multiline = true;
            textPasswordConfirm.Name = "textPasswordConfirm";
            textPasswordConfirm.PasswordChar = '•';
            textPasswordConfirm.Size = new Size(164, 27);
            textPasswordConfirm.TabIndex = 6;
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.Font = new Font("Segoe UI", 12F);
            confirmPassword.ForeColor = Color.Khaki;
            confirmPassword.Location = new Point(69, 135);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(137, 21);
            confirmPassword.TabIndex = 5;
            confirmPassword.Text = "Confirm Password";
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.Window;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 12F);
            textPassword.Location = new Point(69, 101);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '•';
            textPassword.Size = new Size(164, 27);
            textPassword.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F);
            Password.ForeColor = Color.Khaki;
            Password.Location = new Point(69, 77);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = SystemColors.Window;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Segoe UI", 12F);
            textUsername.Location = new Point(69, 32);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(164, 27);
            textUsername.TabIndex = 2;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(69, 8);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // getStarted
            // 
            getStarted.AutoSize = true;
            getStarted.BackColor = Color.Transparent;
            getStarted.Font = new Font("Tempus Sans ITC", 27.75F, FontStyle.Bold);
            getStarted.ForeColor = Color.Khaki;
            getStarted.ImeMode = ImeMode.NoControl;
            getStarted.Location = new Point(100, 33);
            getStarted.Name = "getStarted";
            getStarted.Size = new Size(204, 49);
            getStarted.TabIndex = 12;
            getStarted.Text = "Get Started";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(401, 597);
            Controls.Add(getStarted);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textUsername;
        private Label label1;
        private TextBox textPasswordConfirm;
        private Label confirmPassword;
        private TextBox textPassword;
        private Label Password;
        private Button buttonRegister;
        private CheckBox checkBoxShowPassword;
        private Button buttonClear;
        private Label label2;
        private Label haveAcount;
        private Label getStarted;
        private Label labelUsernameStatus;
    }
}