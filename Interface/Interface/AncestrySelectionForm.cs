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

    }
}
