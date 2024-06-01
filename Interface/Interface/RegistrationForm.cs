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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" && textPassword.Text == "" && textPasswordConfirm.Text == "")
            {
                MessageBox.Show("User name and password fields are empty", "Resistration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text.Equals(textPasswordConfirm.Text))
            {
                string username = textUsername.Text;
                string password = textPassword.Text;

                try
                {
                    bool isRegistered = DatabaseHelper.Register(username, password, "nomal");
                    if (isRegistered)
                    {
                        MessageBox.Show("User registered successfully!");
                        textPassword.Text = "";
                        textPasswordConfirm.Text = "";
                        textUsername.Text = "";
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User registration failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password does not math");
                textPassword.Text = "";
                textPasswordConfirm.Text = "";
                textPassword.Focus();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxShowPassword.Checked == true))
            {
                textPassword.PasswordChar = '\0';
                textPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '•';
                textPasswordConfirm.PasswordChar = '•';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textPassword.Text = "";
            textPasswordConfirm.Text = "";
            textUsername.Text = "";
            textUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            string username = textUsername.Text;

            if (!string.IsNullOrEmpty(username))
            {
                bool userExists = DatabaseHelper.UserExists(username);
                if (userExists)
                {
                    labelUsernameStatus.Text = "Username already exists";
                    labelUsernameStatus.ForeColor = Color.Red;
                }
                else
                {
                    labelUsernameStatus.Text = "Username available";
                    labelUsernameStatus.ForeColor = Color.Green;
                }

                // Exibir a label apenas quando começar a digitar
                labelUsernameStatus.Visible = true;
            }
            else
            {
                // Esconder a label quando o campo de texto está vazio
                labelUsernameStatus.Visible = false;
            }
        }
    }
}
