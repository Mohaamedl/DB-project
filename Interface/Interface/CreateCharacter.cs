using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class CreateCharacter : Form
    {
        public Character NewCharacter { get; private set; }
        private List<Feat> availableFeats;
        private List<Spell> availableSpells;
        private List<Trait> availableTraits;
        public CreateCharacter()
        {
            InitializeComponent();
            LoadInitialFeats();
            LoadInitialSpells();
            LoadInitialTraits();

        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {

        }
        private void LoadInitialFeats()
        {
            try
            {
                availableFeats = DatabaseHelper.GetFeatsFromDatabase();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feats from database: " + ex.Message);
            }
        }
        private void LoadInitialSpells()
        {
            try
            {
                availableSpells = DatabaseHelper.GetSpellsFromDatabase();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Spells from database: " + ex.Message);
            }
        }
        private void LoadInitialTraits()
        {
            try
            {
                availableTraits = DatabaseHelper.GetTraitsFromDatabase();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Traits from database: " + ex.Message);
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCharacter = new Character
            {
                name = textBoxName.Text,
                HP = int.Parse(textBoxHP.Text),
                Level = int.Parse(textBoxLevel.Text),

            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void STRENGTH_TextChanged(object sender, EventArgs e)
        {

            if (Int32.TryParse(this.textBoxStr.Text, out int value))
            {
                Console.WriteLine(value);
                int modifier = (value - 10) / 2;
                this.stre_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.stre_mod.Text = "Erro";
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONSTITUTION_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("batatas");
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.textBoxStr.Text, out int value))
            {
                Console.WriteLine(value);
                int modifier = (value - 10) / 2;
                this.stre_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.stre_mod.Text = "Erro";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var featSelectionForm = new FeatSelectionForm(availableFeats))
            {
                if (featSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedFeats = featSelectionForm.SelectedFeats;
                    feats_sel.Text = string.Join(", ", selectedFeats.Select(f => f.name));
                    foreach (var feat in selectedFeats)
                    {
                        var item = new ListViewItem(new[]
                        {
                            feat.name,
                            feat.rarity,
                            feat.prerequisite,
                            feat.level.ToString()
                        });

                        selectedFeatsListView.Items.Add(item);
                    }
                }
            }
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            using (var spellSelectionForm = new SpellSelectionForm(availableSpells))
            {
                if (spellSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedSpells = spellSelectionForm.SelectedSpells;

                    foreach (var spell in selectedSpells)
                    {
                        var item = new ListViewItem(new[]
                        {
                            spell.Name,
                            spell.Rarity,
                            spell.Actions,
                            spell.Rank.ToString(),
                            spell.Range
                        });

                        selectedSpellsListView.Items.Add(item);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var traitSelectionForm = new TraitsSelectionForm(availableTraits))
            {
                if (traitSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedTraits = traitSelectionForm.SelectedTraits;

                    foreach (var trait in selectedTraits)
                    {
                        var item = new ListViewItem(new[]
                        {
                            trait.designation,
                            trait.details
                            
                        });

                        selectedTraitsListView.Items.Add(item);
                    }
                }
            }
        }
    }
}
