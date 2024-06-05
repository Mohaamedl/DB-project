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
        public User user;

        // Método para definir o nome de usuário
        public void SetUser(User userr)
        {
            this.user = userr;
        }
        private void LandingPage_Load(object sender, EventArgs e)
        {
            // Definir a imagem de fundo
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (!DatabaseHelper.UserExists("admin"))
            {
                // Users para exemplificar
                DatabaseHelper.Register("admin", "admin", "admin");
                DatabaseHelper.AddUserCharacter(1, 1);
                DatabaseHelper.AddUserCharacter(1, 2);
                DatabaseHelper.AddUserCharacter(1, 3);
                DatabaseHelper.AddUserCharacter(1, 4);
                DatabaseHelper.AddUserCharacter(1, 5);
                DatabaseHelper.AddUserCharacter(1, 6);
                DatabaseHelper.AddUserCharacter(1, 7);
                DatabaseHelper.AddUserCharacter(1, 8);
                DatabaseHelper.AddUserCharacter(1, 9);
                DatabaseHelper.AddUserCharacter(1, 10);
                DatabaseHelper.AddUserCharacter(1, 11);
                DatabaseHelper.Register("user1", "12345678", "normal"); 
                DatabaseHelper.Register("user2", "12345678", "normal");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de login
            LoginForm loginForm = new LoginForm(this);

            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.IsAuthenticated)
            {
                HomePage homePage = new HomePage(this.user);
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
