namespace Interface
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            labelUsername = new Label();
            labelPassword = new Label();
            getStarted = new Label();
            panel1 = new Panel();
            createAcount = new Label();
            haveAcount = new Label();
            buttonClear = new Button();
            buttonLogin = new Button();
            checkBoxShowPassword = new CheckBox();
            textPassword = new TextBox();
            Password = new Label();
            textUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.Name = "labelUsername";
            // 
            // labelPassword
            // 
            resources.ApplyResources(labelPassword, "labelPassword");
            labelPassword.Name = "labelPassword";
            // 
            // getStarted
            // 
            resources.ApplyResources(getStarted, "getStarted");
            getStarted.BackColor = Color.Transparent;
            getStarted.ForeColor = Color.Khaki;
            getStarted.Name = "getStarted";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 100, 0, 0);
            panel1.Controls.Add(createAcount);
            panel1.Controls.Add(haveAcount);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(textUsername);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // createAcount
            // 
            resources.ApplyResources(createAcount, "createAcount");
            createAcount.BackColor = Color.Transparent;
            createAcount.ForeColor = Color.Khaki;
            createAcount.Name = "createAcount";
            createAcount.Click += createAcount_Click;
            // 
            // haveAcount
            // 
            resources.ApplyResources(haveAcount, "haveAcount");
            haveAcount.BackColor = Color.Transparent;
            haveAcount.ForeColor = Color.Black;
            haveAcount.Name = "haveAcount";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Khaki;
            resources.ApplyResources(buttonClear, "buttonClear");
            buttonClear.ForeColor = Color.Brown;
            buttonClear.Name = "buttonClear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Brown;
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.ForeColor = Color.Khaki;
            buttonLogin.Name = "buttonLogin";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // checkBoxShowPassword
            // 
            resources.ApplyResources(checkBoxShowPassword, "checkBoxShowPassword");
            checkBoxShowPassword.BackColor = Color.Transparent;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.ForeColor = Color.Khaki;
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.UseVisualStyleBackColor = false;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.Window;
            textPassword.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textPassword, "textPassword");
            textPassword.Name = "textPassword";
            // 
            // Password
            // 
            resources.ApplyResources(Password, "Password");
            Password.BackColor = Color.Transparent;
            Password.ForeColor = Color.Khaki;
            Password.Name = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = SystemColors.Window;
            textUsername.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textUsername, "textUsername");
            textUsername.Name = "textUsername";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Khaki;
            label1.Name = "label1";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPassword);
            Controls.Add(getStarted);
            Controls.Add(labelUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label getStarted;
        private Panel panel1;
        private Label createAcount;
        private Label haveAcount;
        private Button buttonClear;
        private Button buttonLogin;
        private CheckBox checkBoxShowPassword;
        private TextBox textPassword;
        private Label Password;
        private TextBox textUsername;
        private Label label1;
    }
}