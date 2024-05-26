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
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Simulação de autenticação
            if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
            {
                HomePage home = new HomePage();

                IsAuthenticated = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
                

                //landingPage.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.");
            }
        }

        
    }
}
