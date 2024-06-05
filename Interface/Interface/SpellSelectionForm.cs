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
        private bool sortOrderAscending = true;
        public SpellSelectionForm(List<Spell> spells, User user)
        {
            
            InitializeComponent();
            Spells = spells ?? new List<Spell>();
            SelectedSpells = new List<Spell>();
            if (user.Role == "admin")
            {
                button1.Enabled = true;
                Create.Enabled = true;  
                Delete.Enabled = true;
            }


            order.Items.AddRange(new string[] { "Name", "Rank", "Actions", "Rarity", "Range" });
            order.SelectedIndex = 0;

            comboBoxRankFilter.Items.AddRange(new string[] { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxRankFilter.SelectedIndex = 0;

            comboBoxRarityFilter.Items.AddRange(new string[] { "All", "Common", "Uncommon", "Rare", "Very Rare" });
            comboBoxRarityFilter.SelectedIndex = 0;

            numericUpDownLimit.Value = 20;

            DisplaySpells(Spells);

        }


        private void DisplaySpells(List<Spell> spells)
        {
            listViewSpells.Items.Clear();


            if (listViewSpells.Columns.Count == 0)
            {
                listViewSpells.Columns.Add("Name", 150);
                listViewSpells.Columns.Add("Rank", 100);
                listViewSpells.Columns.Add("Action", 150);
                listViewSpells.Columns.Add("Rarity", 250);
                listViewSpells.Columns.Add("Range", 50);
                listViewSpells.Columns.Add("ID", 50);
            }

            foreach (var spell in spells)
            {
                var item = new ListViewItem(spell.Name)
                {
                    Tag = spell
                };
                item.SubItems.Add(spell.Rank.ToString());
                item.SubItems.Add(spell.Actions);
                item.SubItems.Add(spell.Rarity);
                item.SubItems.Add(spell.Range);
                item.SubItems.Add(spell.ID.ToString());
                listViewSpells.Items.Add(item);
            }
        }

        private void LoadSpells()
        {
            string searchText = textBoxSearch?.Text ?? string.Empty;
            string sortBy = order?.SelectedItem?.ToString() ?? "name";
            int limit = numericUpDownLimit != null ? (int)numericUpDownLimit.Value : 20;

            string rankFilter = comboBoxRankFilter?.SelectedItem?.ToString() != "All" ? comboBoxRankFilter?.SelectedItem?.ToString() : null;
            string rarityFilter = comboBoxRarityFilter?.SelectedItem?.ToString() != "All" ? comboBoxRarityFilter?.SelectedItem?.ToString() : null;

            Spells = DatabaseHelper.GetSpellsFromDatabase(limit, "name", searchText, rankFilter, rarityFilter, sortBy, sortOrderAscending);

            DisplaySpells(Spells);
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
                numericUpDownLimit.Maximum = Spells.Count;
                numericUpDownLimit.Value = Spells.Count;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSpells.CheckedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewSpells.CheckedItems)
                {
                    var spell = (Spell)selectedItem.Tag;

                    using (var editForm = new EditSpellForm(spell))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            selectedItem.SubItems[0].Text = spell.Name;
                            selectedItem.SubItems[1].Text = spell.Rank.ToString();
                            selectedItem.SubItems[2].Text = spell.Actions;
                            selectedItem.SubItems[3].Text = spell.Rarity;
                            selectedItem.SubItems[4].Text = spell.Range;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a spell to edit.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listViewSpells.CheckedItems.Count > 0)
            {
                List<int> spellIds = new List<int>();
                foreach (ListViewItem selectedItem in listViewSpells.CheckedItems)
                {
                    int spellId = Convert.ToInt32(selectedItem.SubItems[5].Text);
                    spellIds.Add(spellId);
                }

                if (DatabaseHelper.DeleteRecordsByIds("Spells", "ID", spellIds))
                {
                    MessageBox.Show("Spells deleted successfully.");

                    foreach (ListViewItem selectedItem in listViewSpells.CheckedItems)
                    {
                        listViewSpells.Items.Remove(selectedItem);
                    }
                }
                else
                {
                    MessageBox.Show("Error deleting spells.");
                }
            }
            else
            {
                MessageBox.Show("Please select spells to delete.");
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateSpellForm createSepll = new CreateSpellForm();
            createSepll.ShowDialog();
            Spells = DatabaseHelper.GetSpellsFromDatabase();
            DisplaySpells(Spells);
        }

        private void order_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSpells();
        }

        private void sortOrder_Click(object sender, EventArgs e)
        {
            sortOrderAscending = !sortOrderAscending;
            sortOrder.Text = sortOrderAscending ? "Asc" : "Desc";
            LoadSpells();
        }

        private void comboBoxRankFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSpells();
        }

        private void comboBoxRarityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSpells();
        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {
            LoadSpells();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSpells();
        }

        private void SpellSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void serach_Click(object sender, EventArgs e)
        {

        }
    }
}
