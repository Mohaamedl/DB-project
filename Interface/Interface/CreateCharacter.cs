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
        private List<Feat> availableFeats;
        public CreateCharacter()
        {
            InitializeComponent();
            InitializeFeats();
        }
        private void InitializeFeats()
        {
            // Inicialize sua lista de feats aqui
            availableFeats = new List<Feat>
            {
                 new Feat { name = "Feat1", rarity = "Common", prerequisite = "None", summary = "Summary1", level = 1 },
                new Feat { name = "Feat2", rarity = "Uncommon", prerequisite = "None", summary = "Summary2", level = 2 },
                // Adicione mais feats conforme necessário
            };
        }
        private void CreateCharacter_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCharacter = new Character
            {
                name = textBoxName.Text,
                HP = int.Parse(textBoxHP.Text),
                Level = int.Parse(textBoxLevel.Text),

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var featSelectionForm = new FeatSelectionForm(availableFeats))
            {
                if (featSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedFeats = featSelectionForm.SelectedFeats;
                    feats.Text = string.Join(", ", selectedFeats.Select(f => f.name));
                }
            }
        }
        private void feats_MouseClick(object sender, MouseEventArgs e)
        {
            this.feats.Text =" clicou";//setting cursor to the begining  on a mouse click

        }
    }
}
