using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditCharacter : Form
    {
        public Character NewCharacter { get; private set; }
        private List<Feat> availableFeats;
        private List<Feat> selectedFeats;
        private List<Spell> availableSpells;
        private List<Spell> selectedSpells;
        private List<Trait> availableTraits;
        private List<Ancestry> availableAncestries;
        private List<Background> availableBackgrounds;
        private List<Equipment> availableEquipments;
        private List<Equipment> selectedEquipments;
        private List<Class> availableClasses;
        private List<Skill> availableSkills;
        private Class selectedClass;
        private Background selectedBackground;
        private Ancestry selectedAncestry;
        private User actual_user { get; set; }
        public EditCharacter(User user,Character character)
        {
            InitializeComponent();
            actual_user = user;
            NewCharacter = character;
            textBoxName.Text = NewCharacter.name;
            HP.Text = NewCharacter.HP.ToString();
            textBoxLevel.Text = NewCharacter.Level.ToString();
            speed.Text = NewCharacter.speed.ToString();
            STRENGTH.Text = NewCharacter.Str.ToString();
            WISDOM.Text = NewCharacter.Wis.ToString();
            INTELLIGENCE.Text = NewCharacter.Int.ToString();
            CHARISMA.Text = NewCharacter.Cha.ToString();
            DEXTERITY.Text = NewCharacter.Dex.ToString();
            CONSTITUTION.Text = NewCharacter.Con.ToString();
            stre_mod.Text = NewCharacter.Str_mod.ToString();
            wisd_mod.Text = NewCharacter.Wis_mod.ToString();
            intel_mod.Text = NewCharacter.Int_mod.ToString();
            char_mod.Text = NewCharacter.Cha_mod.ToString();
            dex_mod.Text = NewCharacter.Dex_mod.ToString();
            const_mod.Text = NewCharacter.Con_mod.ToString();

            // Carregar informações adicionais (anexos, habilidades, etc.) se necessário
            LoadAdditionalInfo();
            LoadInitialFeats();
            LoadInitialSpells();
            LoadInitialTraits();
            LoadInitialAncestries();
            LoadInitialBackgrounds();
            LoadInitialEquipments();
            LoadInitialClasses();
            LoadSkills();
        }
        private void LoadAdditionalInfo()
        {
            
            LoadSelectedFeats();
            LoadSelectedSpells();
            LoadSelectedEquipments();
            LoadSelectedAncestry();
            LoadSelectedBackground();
            LoadSelectedClass();
        }
        private void LoadSelectedFeats()
        {
            try
            {
                selectedFeatsListView.Items.Clear();

                selectedFeats = NewCharacter.feats;

                // Preenche a lista de feitos selecionados no formulário
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected feats: " + ex.Message);
            }
        }

        private void LoadSelectedSpells()
        {
            try
            {
                selectedSpellsListView.Items.Clear();

                selectedSpells = NewCharacter.spells;

                foreach (var spell in selectedSpells)
                {
                    var item = new ListViewItem(new[]
                    {
                spell.Name,
                spell.Rank.ToString(),
                spell.Actions,
                spell.Rarity,
                spell.Range
            });

                    selectedSpellsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected spells: " + ex.Message);
            }
        }

        private void LoadSelectedEquipments()
        {
            try
            {
                selectedEquipmentsListView.Items.Clear();

                selectedEquipments = NewCharacter.equipment;

                foreach (var equipment in selectedEquipments)
                {
                    var item = new ListViewItem(new[]
                    {
                equipment.name,
                equipment.item_category,
                //equipment.item_sub_category,
                //equipment.weapon_category,
                equipment.level.ToString(),
                equipment.price.ToString(),
                //equipment.rarity,
                equipment.usage,
                //equipment.bulk
            });

                    selectedEquipmentsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected equipments: " + ex.Message);
            }
        }

        private void LoadSelectedAncestry()
        {
            try
            {
                selectedAncestry = NewCharacter.ancestry;

                if (selectedAncestry != null)
                {
                    int classHP = selectedClass != null ? (selectedClass.HP) : 0;
                    int ancestryHP = selectedAncestry != null ? (selectedAncestry.HP) : 0;
                    int totalHP = classHP + ancestryHP;

                    speed.Text = selectedAncestry.speed.ToString();
                    HP.Text = totalHP.ToString();
                    ancestry_sel.Text = selectedAncestry.name;
                    LanguagesList.Text = string.Join(", ", DatabaseHelper.GetLanguagesByAncestry(selectedAncestry.name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected ancestry: " + ex.Message);
            }
        }

        private void LoadSelectedBackground()
        {
            try
            {
                selectedBackground = NewCharacter.background;

                if (selectedBackground != null)
                {
                    background_sel.Text = selectedBackground.name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected background: " + ex.Message);
            }
        }

        private void LoadSelectedClass()
        {
            try
            {
                selectedClass = NewCharacter.Class;
                if (selectedClass != null)
                {
                    int classHP = selectedClass != null ? (selectedClass.HP) : 0;
                    int ancestryHP = selectedAncestry != null ? (selectedAncestry.HP) : 0;
                    int totalHP = classHP + ancestryHP;
                    HP.Text = totalHP.ToString();
                    class_sel.Text = selectedClass.name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected class: " + ex.Message);
            }

        }




            private void EditCharacter_Load(object sender, EventArgs e)
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
        private void LoadInitialAncestries()
        {
            try
            {
                availableAncestries = DatabaseHelper.GetAncestriesFromDatabase();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Ancestries from database: " + ex.Message);
            }
        }
        private void LoadInitialBackgrounds()
        {
            try
            {
                availableBackgrounds = DatabaseHelper.GetBackgroundsFromDatabase();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Backgrounds from database: " + ex.Message);
            }
        }
        private void LoadInitialEquipments()
        {
            try
            {
                availableEquipments = DatabaseHelper.GetEquipmentsFromDatabase();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Equipments from database: " + ex.Message);
            }
        }
        private void LoadSkills()
        {
            try
            {
                availableSkills = DatabaseHelper.GetSkillsFromDatabase();

                foreach (var skill in availableSkills)
                {
                    var item = new ListViewItem(new[]
                    {
                            skill.designation,
                            skill.value.ToString(),
                            skill.details

                        });

                    listViewSkills.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Equipments from database: " + ex.Message);
            }
        }
        private void LoadInitialClasses()
        {
            try
            {
                availableClasses = DatabaseHelper.GetClassesFromDatabase(20);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Classes from database: " + ex.Message);
            }
        }





        private void buttonSave_Click(object sender, EventArgs e)
        {
            Character nc = new Character
            { ID = NewCharacter.ID,
                name = textBoxName.Text,
                HP = int.Parse(HP.Text),
                Level = int.Parse(textBoxLevel.Text),
                Class = selectedClass,
                ancestry = selectedAncestry,
                background = selectedBackground,
                speed = Int16.Parse(this.speed.Text),
                equipment = selectedEquipments,
                feats = selectedFeats,
                spells = selectedSpells,
                Str = Int16.Parse(STRENGTH.Text),
                Wis = Int16.Parse(WISDOM.Text),
                Int = Int16.Parse(INTELLIGENCE.Text),
                Cha = Int16.Parse(CHARISMA.Text),
                Dex = Int16.Parse(DEXTERITY.Text),
                Con = Int16.Parse(CONSTITUTION.Text),
                Str_mod = Int16.Parse(stre_mod.Text),
                Wis_mod = Int16.Parse(wisd_mod.Text),
                Int_mod = Int16.Parse(intel_mod.Text),
                Cha_mod = Int16.Parse(char_mod.Text),
                Dex_mod = Int16.Parse(dex_mod.Text),
                Con_mod = Int16.Parse(const_mod.Text),
                Languages = DatabaseHelper.GetLanguagesByAncestry(ancestry_sel.Text),
                id_abilityScores = NewCharacter.id_abilityScores


            };

            NewCharacter = DatabaseHelper.UpdateCharacter(nc);
            
            DatabaseHelper.UpdateCharacterEquipment(NewCharacter.ID, selectedEquipments);
            DatabaseHelper.UpdateCharacterFeats(NewCharacter.ID, selectedFeats);
            DatabaseHelper.UpdateCharacterSpells(NewCharacter.ID, selectedSpells);
            DatabaseHelper.UpdateCharacterLanguages(NewCharacter.ID, NewCharacter.Languages);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void STRENGTH_TextChanged(object sender, EventArgs e)
        {

            if (Int32.TryParse(this.STRENGTH.Text, out int value))
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



        private void CONSTITUTION_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.CONSTITUTION.Text, out int value))
            {
                Console.WriteLine(value);
                int modifier = (value - 10) / 2;
                this.const_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.const_mod.Text = "Erro";
            }
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.STRENGTH.Text, out int value))
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var featSelectionForm = new FeatSelectionForm(availableFeats,actual_user))
            {
                if (featSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedFeats = featSelectionForm.SelectedFeats;
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
            using (var spellSelectionForm = new SpellSelectionForm(availableSpells, actual_user))
            {
                if (spellSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedSpells = spellSelectionForm.SelectedSpells;

                    foreach (var spell in selectedSpells)
                    {
                        var item = new ListViewItem(new[]
                        {
                            spell.Name,
                            spell.Rank.ToString(),
                            spell.Actions,
                            spell.Rarity,
                            spell.Range
                        });

                        selectedSpellsListView.Items.Add(item);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var traitSelectionForm = new TraitsSelectionForm(availableTraits,actual_user))
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

        private void button7_Click(object sender, EventArgs e)
        {
            using (var ancestrySelectionForm = new AncestrySelectionForm(availableAncestries,actual_user))
            {
                if (ancestrySelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedAncestry = ancestrySelectionForm.SelectedAncestries.FirstOrDefault();


                    if (selectedAncestry != null)
                    {
                        // Adiciona os detalhes da ascendência na ListView


                        // Armazena o nome da ascendência no TextBox
                        int classHP = selectedClass != null ? (selectedClass.HP) : 0;
                        int ancestryHP = selectedAncestry != null ? (selectedAncestry.HP) : 0;

                        int totalHP = classHP + ancestryHP;
                        speed.Text = selectedAncestry.speed.ToString();
                        HP.Text = totalHP.ToString();
                        ancestry_sel.Text = selectedAncestry.name;
                        LanguagesList.Text = string.Join(", ", DatabaseHelper.GetLanguagesByAncestry(ancestry_sel.Text));

                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var backgroundSelectionForm = new BackgroundSelectionForm(availableBackgrounds))
            {
                if (backgroundSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedBackground = backgroundSelectionForm.SelectedBackground.FirstOrDefault();

                    if (selectedBackground != null)
                    {
                        // Adiciona os detalhes da ascendência na ListView


                        // Armazena o nome da ascendência no TextBox
                        background_sel.Text = selectedBackground.name;


                    }
                }

            }
        }

        private void DEXTERITY_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.DEXTERITY.Text, out int value))
            {
                int modifier = (value - 10) / 2;
                this.dex_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.dex_mod.Text = "Erro";
            }

        }

        private void INTELLIGENCE_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.INTELLIGENCE.Text, out int value))
            {
                int modifier = (value - 10) / 2;
                this.intel_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.intel_mod.Text = "Erro";
            }

        }

        private void WISDOM_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.WISDOM.Text, out int value))
            {
                int modifier = (value - 10) / 2;
                this.wisd_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.wisd_mod.Text = "Erro";
            }
        }

        private void CHARISMA_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.CHARISMA.Text, out int value))
            {
                int modifier = (value - 10) / 2;
                this.char_mod.Text = modifier.ToString();
            }
            else
            {
                Console.WriteLine("Erro ao converter o valor de força.");
                this.char_mod.Text = "Erro";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var equipmentsSelectionForm = new EquipmentSelectionForm(availableEquipments,actual_user))
            {
                if (equipmentsSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedEquipments = equipmentsSelectionForm.SelectedEquipments;

                    foreach (var equipment in selectedEquipments)
                    {
                        var item = new ListViewItem(new[]
                        {
                            equipment.name,
                            equipment.item_category,
                            //equipment.item_sub_category,
                            //equipment.weapon_category,
                            equipment.level.ToString(),
                            equipment.price.ToString(),
                            //equipment.rarity,
                            equipment.usage,
                            //equipment.bulk

                        });


                        selectedEquipmentsListView.Items.Add(item);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var classSelectionForm = new ClassSelectionForm(availableClasses,actual_user))
            {
                if (classSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    selectedClass = classSelectionForm.SelectedClass.FirstOrDefault();

                    if (selectedClass != null)
                    {


                        int classHP = selectedClass != null ? (selectedClass.HP) : 0;
                        int ancestryHP = selectedAncestry != null ? (selectedAncestry.HP) : 0;

                        int totalHP = classHP + ancestryHP;
                        HP.Text = totalHP.ToString();


                        class_sel.Text = selectedClass.name;


                    }
                }

            }
        }


    }
}
