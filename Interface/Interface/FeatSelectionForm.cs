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
    public partial class FeatSelectionForm : Form
    {



        private List<Feat> Feats { get; set; }
        public List<Feat> SelectedFeats { get; set; }

        public FeatSelectionForm(List<Feat> feats)
        {

            InitializeComponent();
            Feats = feats ?? new List<Feat>();
            SelectedFeats = new List<Feat>();

            order.Items.AddRange(new string[] { "Name", "Rarity", "Level"});
            order.SelectedIndex = 0;

            comboBoxLevelFilter.Items.AddRange(new string[] { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBoxLevelFilter.SelectedIndex = 0;

            comboBoxRarityFilter.Items.AddRange(new string[] { "All", "Common", "Uncommon", "Rare", "Very Rare" });
            comboBoxRarityFilter.SelectedIndex = 0;

            numericUpDownLimit.Value = 20;

            DisplayFeats(Feats);
        }

        private void FeatSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayFeats(Feats);
        }
        private void DisplayFeats(List<Feat> feats)
        {
            listViewFeats.Columns.Add("Name", 150);
            listViewFeats.Columns.Add("Rarity", 100);
            listViewFeats.Columns.Add("Prerequisite", 150);
            listViewFeats.Columns.Add("Summary", 250);
            listViewFeats.Columns.Add("Level", 50);

            foreach (var feat in Feats)
            {
                var item = new ListViewItem(feat.name)
                {
                    Tag = feat
                };
                item.SubItems.Add(feat.rarity);
                item.SubItems.Add(feat.prerequisite);
                item.SubItems.Add(feat.summary);
                item.SubItems.Add(feat.level.ToString());
                listViewFeats.Items.Add(item);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedFeats.Clear();
            foreach (ListViewItem item in listViewFeats.CheckedItems)
            {
                SelectedFeats.Add((Feat)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listViewFeats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load_all_Click(object sender, EventArgs e)
        {
            LoadAllFeats();
        }
        private void LoadAllFeats()
        {
            try
            {
                Feats = DatabaseHelper.GetAllFeatsFromDatabase();
                DisplayFeats(Feats);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all feats from database: " + ex.Message);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateFeatForm createFeat = new CreateFeatForm();
            createFeat.ShowDialog();
            if (DialogResult.OK == createFeat.DialogResult)
            {
                Feats = DatabaseHelper.GetFeatsFromDatabase();
                Feats.Add(createFeat.feat);
                DisplayFeats(Feats);

            }

        }

        private void order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRankFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortOrder_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRarityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
