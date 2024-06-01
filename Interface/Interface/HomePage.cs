using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interface
{
    public partial class HomePage : Form
    {
        private List<Character> characters;
        private Character selectedCharacter;
        public User user;


        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }
        public HomePage(User user)
        {
            InitializeComponent();
            LoadCharacters();
            // Armazenar o nome de usuário recebido como parâmetro
            this.user = user;

            // Você pode usar o nome de usuário aqui como quiser, por exemplo, definindo o texto de uma label
            labelPlayerName.Text = $"Player Name: {user.Username}";
        }
        private void LoadCharacters()
        {
            // Carregar alguns personagens para exemplo
            characters = new List<Character>();

            listBoxCharacters.DataSource = null;

            listBoxCharacters.DataSource = characters;
            listBoxCharacters.DisplayMember = "Name";
        }
        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = listBoxCharacters.SelectedItem as Character;
            if (selectedCharacter != null)
            {
                // Define o nome do personagem
                labelCharacterName.Text = $"Character Name: {selectedCharacter.name}" ;

                // Define o HP do personagem
                labelCharacterHP.Text = $"HP: {selectedCharacter.HP}";

                // Define o nível do personagem
                labelCharacterLevel.Text = $"Level: {selectedCharacter.Level}";

                // Limpa a ListView
                listViewCharacterDetails.Items.Clear();

                // Adiciona detalhes do personagem à ListView
                listViewCharacterDetails.Items.Clear();

                // Adiciona detalhes do personagem como labels
                labelClass.Text = $"Class: {selectedCharacter.Class.name}";
                labelAncestry.Text = $"Ancestry: {selectedCharacter.ancestry.name}";
                labelBackground.Text = $"Background: {selectedCharacter.background.name}";
                labelSpeed.Text = $"Speed: {selectedCharacter.speed}";

                // Atributos do personagem
                labelStrength.Text = $"Strength: {selectedCharacter.Str}";
                labelWisdom.Text = $"Wisdom: {selectedCharacter.Wis}";
                labelIntelligence.Text = $"Intelligence: {selectedCharacter.Int}";
                labelCharisma.Text = $"Charisma: {selectedCharacter.Cha}";
                labelDexterity.Text = $"Dexterity: {selectedCharacter.Dex}";
                labelConstitution.Text = $"Constitution: {selectedCharacter.Con}";

                // Modificadores de atributos
                labelStrengthModifier.Text = $"Strength Modifier: {selectedCharacter.Str_mod}";
                labelWisdomModifier.Text = $"Wisdom Modifier: {selectedCharacter.Wis_mod}";
                labelIntelligenceModifier.Text = $"Intelligence Modifier: {selectedCharacter.Int_mod}";
                labelCharismaModifier.Text = $"Charisma Modifier: {selectedCharacter.Cha_mod}";
                labelDexterityModifier.Text = $"Dexterity Modifier: {selectedCharacter.Dex_mod}";
                labelConstitutionModifier.Text = $"Constitution Modifier: {selectedCharacter.Con_mod}";
                string languages = string.Join(", ", selectedCharacter.Languages);
                labelLanguages.Text = $"Languages: {languages}";

                // Equipamentos
                foreach (var equipment in selectedCharacter.equipment)
                {
                    listViewCharacterDetails.Items.Add(new ListViewItem(new[] { "Equipment", equipment.name.ToString() }));
                }

                // Habilidades (Feats)
                foreach (var feat in selectedCharacter.feats)
                {
                    listViewCharacterDetails.Items.Add(new ListViewItem(new[] { "Feat", feat.name.ToString() }));
                }

                // Magias (Spells)
                foreach (var spell in selectedCharacter.spells)
                {
                    listViewCharacterDetails.Items.Add(new ListViewItem(new[] { "Spell", spell.Name.ToString() }));
                }

                
            }
        }
        private void buttonCreateCharacter_Click(object sender, EventArgs e)
        {
            using (var createForm = new CreateCharacter())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    characters.Add(createForm.NewCharacter);
                    UpdateCharacterList();
                }
            }
        }


        private void buttonEditCharacter_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedItem != null)
            {
                var selectedCharacter = (Character)listBoxCharacters.SelectedItem;
                EditCharacter(selectedCharacter);
            }
            else
            {
                MessageBox.Show("Please select a character to edit.");
            }
        }
        private void EditCharacter(Character character)
        {
            using (var editForm = new EditCharacter(character))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateCharacterList();
                }
            }
        }

        private void buttonDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                characters.Remove(selectedCharacter);
                listBoxCharacters.DataSource = null;
                listBoxCharacters.DataSource = characters;
            }
        }
        private void UpdateCharacterList()
        {
            listBoxCharacters.DataSource = null;
            listBoxCharacters.DataSource = characters;
            listBoxCharacters.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Close();
        }
    }
}
