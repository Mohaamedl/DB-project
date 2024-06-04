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
    public partial class EditAncestryForm : Form
    {
        private Ancestry _ancestry;

        public EditAncestryForm(Ancestry ancestry)
        {
            InitializeComponent();
            _ancestry = ancestry;

            // Preencher os campos com os dados da ancestry
            textBoxName.Text = _ancestry.name;
            textBoxHP.Text = _ancestry.HP.ToString();
            textBoxSize.Text = _ancestry.size;
            textBoxSpeed.Text = _ancestry.speed.ToString();
            textBoxAbilityBoost.Text = _ancestry.ability_boost;
            textBoxAbilityFlaw.Text = _ancestry.ability_flaw;
            textBoxRarity.Text = _ancestry.rarity;
        }

        

        private void EditAncestryForm_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Atualizar os valores da ancestry
            _ancestry.name = textBoxName.Text;
            _ancestry.HP = int.Parse(textBoxHP.Text);
            _ancestry.size = textBoxSize.Text;
            _ancestry.speed = int.Parse(textBoxSpeed.Text);
            _ancestry.ability_boost = textBoxAbilityBoost.Text;
            _ancestry.ability_flaw = textBoxAbilityFlaw.Text;
            _ancestry.rarity = textBoxRarity.Text;

            // Atualizar no banco de dados
            if (DatabaseHelper.UpdateAncestry(_ancestry))
            {
                MessageBox.Show("Ancestry updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating ancestry.");
            }
        }
    }
}
