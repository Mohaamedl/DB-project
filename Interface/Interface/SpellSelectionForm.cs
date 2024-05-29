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
    public partial class SpellSelectionForm : Form
    {
        private List<Spell> Spells { get; set; }
        public List<Spell> SelectedSpells { get; set; }

        public SpellSelectionForm(List<Spell> spells)
        {

            InitializeComponent();
            Spells = spells ?? new List<Spell>();
            SelectedSpells = new List<Spell>();



        }

        private void SpellSelectionForm_Load(object sender, EventArgs e)
        {
            DisplaySpells(Spells);
        }
        private void DisplaySpells(List<Spell> spells)
        {
            listViewSpells.Columns.Add("Name", 150);
            listViewSpells.Columns.Add("Rarity", 100);
            listViewSpells.Columns.Add("Action", 150);
            listViewSpells.Columns.Add("Rank", 250);
            listViewSpells.Columns.Add("Range", 50);

            foreach (var spell in spells)
            {
                var item = new ListViewItem(spell.Name)
                {
                    Tag = spell
                };
                item.SubItems.Add(spell.Rarity);
                item.SubItems.Add(spell.Actions);
                item.SubItems.Add(spell.Rank.ToString());
                item.SubItems.Add(spell.Range);
                listViewSpells.Items.Add(item);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedSpells.Clear();
            foreach (ListViewItem item in listViewSpells.CheckedItems)
            {
                SelectedSpells.Add((Spell)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void LoadAllSpells()
        {
            try
            {
                Spells = DatabaseHelper.GetAllSpellsFromDatabase();
                DisplaySpells(Spells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all Spells from database: " + ex.Message);
            }
        }

        private void loadAll_Click(object sender, EventArgs e)
        {
            LoadAllSpells();
        }

        private void select_Click_1(object sender, EventArgs e)
        {
            SelectedSpells.Clear();
            foreach (ListViewItem item in listViewSpells.CheckedItems)
            {
                SelectedSpells.Add((Spell)item.Tag);
            }
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
