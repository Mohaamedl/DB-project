using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class CreateCharacter : Form
    {
        public Character NewCharacter { get; private set; }
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCharacter = new Character
            {
                Name = textBoxName.Text,
                HP = int.Parse(textBoxHP.Text),
                Level = int.Parse(textBoxLevel.Text),
                Class = textBoxClass.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void STRENGTH_TextChanged(object sender, EventArgs e)
        {

            if (Int32.TryParse(this.textBoxStr.Text, out int value))
            {
                Console.WriteLine(value);
                int modifier = (value - 10) / 2;
                this.stre_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.stre_mod.Text = "Erro";
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONSTITUTION_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("batatas");
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.textBoxStr.Text, out int value))
            {
                Console.WriteLine(value);
                int modifier = (value - 10) / 2;
                this.stre_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.stre_mod.Text = "Erro";
            }
        }
    }
}
