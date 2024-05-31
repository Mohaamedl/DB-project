using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            IsAuthenticated = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textUsername.Text == "" && textPassword.Text == "")
            {
                MessageBox.Show("Username and password fields are empty", "Resistration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textUsername.Text == "admin" && textPassword.Text == "admin")
            {
                MessageBox.Show("Login successful!");

                IsAuthenticated = true;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                string username = textUsername.Text;
                string password = textPassword.Text;
                bool isLoggedIn = DatabaseHelper.LoginUser(username, password);

                if (isLoggedIn)
                {
                    MessageBox.Show("Login successful!");
                    IsAuthenticated = true;
                    this.DialogResult = DialogResult.OK;
                    textPassword.Text = "";
                    textUsername.Text = "";
                    textUsername.Focus();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password.");
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
