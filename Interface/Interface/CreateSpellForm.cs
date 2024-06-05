using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Interface
{
    public partial class CreateSpellForm : Form
    {
        public CreateSpellForm()
        {
            InitializeComponent();
        }
        private Spell spell;

        private void CreateSpellForm_Load(object sender, EventArgs e)
        {
            



        }

        private void Create_Click(object sender, EventArgs e)
        {
            
        }

        private void Create_Click_1(object sender, EventArgs e)
        {
            spell = new Spell
            {
                Name = textBoxName.Text,
                Rarity = Rarity.Text,
                Actions = Actions.Text,
                Rank = Int16.Parse(boxRank.Text),
                Range = boxRange.Text,
            };
            if (DatabaseHelper.CreateSpell(spell))
            {
                MessageBox.Show("Spell Created sucessfully!");
                DialogResult = DialogResult.OK;
                this.Close();


            }
            else
            {
                MessageBox.Show("Error crating spell!");
            }
        }
    }
}
