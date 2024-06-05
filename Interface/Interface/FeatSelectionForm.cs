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
    }
}
