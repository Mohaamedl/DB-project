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
    public partial class TraitsSelectionForm : Form
    {
        private List<Trait> Traits { get; set; }
        public List<Trait> SelectedTraits { get; set; }

        public TraitsSelectionForm(List<Trait> traits)
        {

            InitializeComponent();
            Traits = traits ?? new List<Trait>();
            SelectedTraits = new List<Trait>();



        }

        private void TraitSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayTraits(Traits);
        }
        private void DisplayTraits(List<Trait> traits)
        {
            listViewTraits.Columns.Add("Designation", 150);
            listViewTraits.Columns.Add("Details", 100);


            foreach (var trait in traits)
            {
                var item = new ListViewItem(trait.designation)
                {
                    Tag = trait
                };
                item.SubItems.Add(trait.details);

                listViewTraits.Items.Add(item);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedTraits.Clear();
            foreach (ListViewItem item in listViewTraits.CheckedItems)
            {
                SelectedTraits.Add((Trait)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void LoadAllTraits()
        {
            try
            {
                Traits = DatabaseHelper.GetAllTraitsFromDatabase();
                DisplayTraits(Traits);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all Traits from database: " + ex.Message);
            }
        }






        private void Select_Click_2(object sender, EventArgs e)
        {
            SelectedTraits.Clear();
            foreach (ListViewItem item in listViewTraits.CheckedItems)
            {
                SelectedTraits.Add((Trait)item.Tag);
            }
            DialogResult = DialogResult.OK;
            Close();

        }

        private void TraitsSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayTraits(Traits);
        }

        private void loadAll_Click_1(object sender, EventArgs e)
        {
            LoadAllTraits();
        }

        private void order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
