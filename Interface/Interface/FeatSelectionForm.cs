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
            Feats.Add(new Feat { name = "Feat1", rarity = "Common", prerequisite = "None", summary = "Summary1", level = 1 });
            Feats.Add(new Feat { name = "Feat2", rarity = "Uncommon", prerequisite = "None", summary = "Summary2", level = 2 });
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
    }
}
