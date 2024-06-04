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
    public partial class AncestrySelectionForm : Form
    {




        private List<Ancestry> Ancestries { get; set; }
        public List<Ancestry> SelectedAncestries { get; set; }

        public AncestrySelectionForm(List<Ancestry> ancestries)
        {

            InitializeComponent();
            Ancestries = ancestries ?? new List<Ancestry>();
            SelectedAncestries = new List<Ancestry>();
            listViewAncestries.LabelEdit = true;
            listViewAncestries.AfterLabelEdit += ListViewAncestries_AfterLabelEdit;


        }
        private void ListViewAncestries_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                var ancestry = (Ancestry)listViewAncestries.Items[e.Item].Tag;
                ancestry.name = e.Label;
            }
        }

        private void AncestrySelectionForm_Load(object sender, EventArgs e)
        {
            DisplayAncestrys(Ancestries);
        }
        private void DisplayAncestrys(List<Ancestry> ancestries)
        {
            listViewAncestries.Columns.Add("name", 150);
            listViewAncestries.Columns.Add("HP", 50);
            listViewAncestries.Columns.Add("size", 70);
            listViewAncestries.Columns.Add("speed", 50);
            listViewAncestries.Columns.Add("ability_boost", 150);
            listViewAncestries.Columns.Add("ability_flaw", 150);
            listViewAncestries.Columns.Add("rarity", 70);

            foreach (var ancestry in Ancestries)
            {
                var item = new ListViewItem(ancestry.name)
                {
                    Tag = ancestry
                };

                item.SubItems.Add(ancestry.HP.ToString());
                item.SubItems.Add(ancestry.size);
                item.SubItems.Add(ancestry.speed.ToString());
                item.SubItems.Add(ancestry.ability_boost);
                item.SubItems.Add(ancestry.ability_flaw);
                item.SubItems.Add(ancestry.rarity);
                item.SubItems.Add(ancestry.ID.ToString());
                listViewAncestries.Items.Add(item);
            }
        }






        private void LoadAllAncestrys()
        {
            try
            {
                Ancestries = DatabaseHelper.GetAllAncestriesFromDatabase();
                DisplayAncestrys(Ancestries);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all ancestrys from database: " + ex.Message);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedAncestries.Clear();
            foreach (ListViewItem item in listViewAncestries.CheckedItems)
            {
                SelectedAncestries.Add((Ancestry)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadAll_Click(object sender, EventArgs e)
        {
            LoadAllAncestrys();
        }
        private void ListViewAncestries_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Se a caixa de seleção está sendo marcada
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar todas as outras caixas de seleção
                foreach (ListViewItem item in listViewAncestries.Items)
                {
                    if (item.Index != e.Index)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listViewAncestries.CheckedItems.Count > 0)
            {
                var selectedItem = listViewAncestries.CheckedItems[0];
                var ancestry = (Ancestry)selectedItem.Tag;

                using (var editForm = new EditAncestryForm(ancestry))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Atualizar a ListView com os novos valores
                        selectedItem.SubItems[0].Text = ancestry.name;
                        selectedItem.SubItems[1].Text = ancestry.HP.ToString();
                        selectedItem.SubItems[2].Text = ancestry.size;
                        selectedItem.SubItems[3].Text = ancestry.speed.ToString();
                        selectedItem.SubItems[4].Text = ancestry.ability_boost;
                        selectedItem.SubItems[5].Text = ancestry.ability_flaw;
                        selectedItem.SubItems[6].Text = ancestry.rarity;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an ancestry to edit.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listViewAncestries.CheckedItems.Count > 0)
            {
                var selectedItem = listViewAncestries.CheckedItems[0];
                List<int> ancestryId = [Convert.ToInt32(selectedItem.SubItems[7].Text)];
                

                if (DatabaseHelper.DeleteRecordsByIds("Ancestry", "ID", ancestryId))
                {
                    MessageBox.Show("Ancestry deleted successfully.");
                    // Refresh the ListView or remove the item directly
                    listViewAncestries.Items.Remove(selectedItem);
                }
                else
                {
                    MessageBox.Show("Error deleting ancestry.");
                }
            }
            else
            {
                MessageBox.Show("Please select an ancestry to delete.");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
