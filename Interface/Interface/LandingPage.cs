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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            // Definir a imagem de fundo
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de login
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.IsAuthenticated)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
