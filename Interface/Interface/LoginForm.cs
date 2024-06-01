using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interface
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; }
        public LandingPage landingPage;
        public User user;
        public LoginForm(LandingPage landing)
        {
            landingPage = landing;
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            IsAuthenticated = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password fields are empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!");

                IsAuthenticated = true;
                this.user = DatabaseHelper.Login("admin", "admin");
                landingPage.SetUser(user);
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                this.user = DatabaseHelper.Login(username, password);

                if (user != null)
                {
                    MessageBox.Show("Login successful!");

                    IsAuthenticated = true;
                    landingPage.SetUser(user); // Passa o nome de usuário para a landing page
                    this.DialogResult = DialogResult.OK;
                    textPassword.Text = "";
                    textUsername.Text = "";
                    textUsername.Focus();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPassword.Text = "";
                    textUsername.Text = "";
                    textUsername.Focus();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textPassword.Text = "";
            textUsername.Text = "";
            textUsername.Focus();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxShowPassword.Checked == true))
            {
                textPassword.PasswordChar = '\0';

            }
            else
            {
                textPassword.PasswordChar = '•';

            }
        }

        private void createAcount_Click(object sender, EventArgs e)
        {

            RegistrationForm registration = new RegistrationForm();
            this.Hide();
            if (registration.ShowDialog() == DialogResult.OK)
            {


                this.Show();
            }

        }


    }
}
