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
    public partial class EditSpellForm : Form
    {
        private Spell _spell;

        public EditSpellForm(Spell spell)
        {
            InitializeComponent();
            _spell = spell;

            textBoxName.Text = _spell.Name;
            textBoxRank.Text = _spell.Rank.ToString();
            textBoxActions.Text = _spell.Actions;
            textBoxRarity.Text = _spell.Rarity;
            textBoxRange.Text = _spell.Range;
        }



        private void Save_Click(object sender, EventArgs e)
        {
            _spell.Name = textBoxName.Text;
            _spell.Rank = int.Parse(textBoxRank.Text);
            _spell.Actions = textBoxActions.Text;
            _spell.Rarity = textBoxRarity.Text;
            _spell.Range = textBoxRange.Text;

            if (DatabaseHelper.UpdateSpell(_spell))
            {
                MessageBox.Show("Spell updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating spell.");
            }
        }
    }
}
