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
        public User actual_user;


        private void HomePage_Load(object sender, EventArgs e)
        {

            // Verificar se há personagens
            if (listBoxCharacters.Items.Count > 0)
            {
                // Selecionar o primeiro personagem na lista
                listBoxCharacters.SelectedIndex = 0;
            }
        }
        public HomePage(User user)
        {
            InitializeComponent();


            // Armazenar o nome de usuário recebido como parâmetro
            this.actual_user = user;
            // Você pode usar o nome de usuário aqui como quiser, por exemplo, definindo o texto de uma label
            labelPlayerName.Text = $"Player Name: {user.Username}";
            LoadCharacters();
        }
        private void LoadCharacters()
        {
            // Obter personagens do banco de dados
            characters = DatabaseHelper.GetCharacters(actual_user.ID);

            // Vincular personagens à lista
            listBoxCharacters.DataSource = null;
            listBoxCharacters.DataSource = characters;
            listBoxCharacters.DisplayMember = "Name";
        }
        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o personagem selecionado
            selectedCharacter = listBoxCharacters.SelectedItem as Character;
            if (selectedCharacter != null)
            {
                // Exibir informações do personagem
                labelCharacterName.Text = $"Character Name: {selectedCharacter.name}";
                labelCharacterHP.Text = $"HP: {selectedCharacter.HP}";
                labelCharacterLevel.Text = $"Level: {selectedCharacter.Level}";
                labelClass.Text = $"Class: {selectedCharacter.Class.name}";
                labelAncestry.Text = $"Ancestry: {selectedCharacter.ancestry.name}";
                labelBackground.Text = $"Background: {selectedCharacter.background.name}";
                labelSpeed.Text = $"Speed: {selectedCharacter.speed}";
                labelStrength.Text = $"Strength: {selectedCharacter.Str}";
                labelWisdom.Text = $"Wisdom: {selectedCharacter.Wis}";
                labelIntelligence.Text = $"Intelligence: {selectedCharacter.Int}";
                labelCharisma.Text = $"Charisma: {selectedCharacter.Cha}";
                labelDexterity.Text = $"Dexterity: {selectedCharacter.Dex}";
                labelConstitution.Text = $"Constitution: {selectedCharacter.Con}";
                labelStrengthModifier.Text = $"Strength Modifier: {selectedCharacter.Str_mod}";
                labelWisdomModifier.Text = $"Wisdom Modifier: {selectedCharacter.Wis_mod}";
                labelIntelligenceModifier.Text = $"Intelligence Modifier: {selectedCharacter.Int_mod}";
                labelCharismaModifier.Text = $"Charisma Modifier: {selectedCharacter.Cha_mod}";
                labelDexterityModifier.Text = $"Dexterity Modifier: {selectedCharacter.Dex_mod}";
                labelConstitutionModifier.Text = $"Constitution Modifier: {selectedCharacter.Con_mod}";
                string languages = string.Join(", ", selectedCharacter.Languages);
                labelLanguages.Text = $"Languages: {languages}";

                // Limpar e exibir equipamentos, habilidades e magias
                listViewCharacterDetails.Items.Clear();
                AddCharacterDetailsInRows(selectedCharacter.feats.Select(f => f.name).ToList(), selectedCharacter.spells.Select(s => s.Name).ToList(), selectedCharacter.equipment.Select(e => e.name).ToList());

                // Ajustar automaticamente o tamanho das colunas ao conteúdo
                AdjustListViewColumns();

            }
        }
        private void AddCharacterDetailsInRows(List<string> feats, List<string> spells, List<string> equipments)
        {
            // Determinar o número máximo de linhas necessárias
            int maxRows = Math.Max(feats.Count, Math.Max(spells.Count, equipments.Count));

            // Adicionar as linhas
            for (int i = 0; i < maxRows; i++)
            {
                var listViewItem = new ListViewItem(feats.Count > i ? feats[i] : "");
                listViewItem.SubItems.Add(spells.Count > i ? spells[i] : "");
                listViewItem.SubItems.Add(equipments.Count > i ? equipments[i] : "");
                listViewCharacterDetails.Items.Add(listViewItem);
            }
        }

        private void AdjustListViewColumns()
        {
            // Ajustar automaticamente o tamanho das colunas ao conteúdo
            foreach (ColumnHeader column in listViewCharacterDetails.Columns)
            {
                column.Width = -2;
            }
        }
        private void buttonCreateCharacter_Click(object sender, EventArgs e)
        {
            using (var createForm = new CreateCharacter(actual_user))
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
                editCharacter(selectedCharacter);
            }
            else
            {
                MessageBox.Show("Please select a character to edit.");
            }
        }
        private void editCharacter(Character character)
        {
            using (var editForm = new EditCharacter(actual_user, character))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCharacters();

                }
            }
        }

        private void buttonDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                // Confirmação de exclusão
                var result = MessageBox.Show($"Are you sure you want to delete {selectedCharacter.name}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove do banco de dados
                    DatabaseHelper.DeleteCharacter(selectedCharacter.ID);

                    // Remove da lista
                    characters.Remove(selectedCharacter);

                    // Atualiza a listBox e exibe o próximo personagem ou limpa os campos
                    LoadCharacters();
                    if (characters.Count > 0)
                    {
                        listBoxCharacters.SelectedIndex = 0;
                    }
                    else
                    {
                        ClearCharacterDetails();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a character to delete.");
            }
        }
        private void ClearCharacterDetails()
        {
            // Limpar informações do personagem
            labelCharacterName.Text = "Character Name:";
            labelCharacterHP.Text = "HP:";
            labelCharacterLevel.Text = "Level:";
            labelClass.Text = "Class:";
            labelAncestry.Text = "Ancestry:";
            labelBackground.Text = "Background:";
            labelSpeed.Text = "Speed:";
            labelStrength.Text = "Strength:";
            labelWisdom.Text = "Wisdom:";
            labelIntelligence.Text = "Intelligence:";
            labelCharisma.Text = "Charisma:";
            labelDexterity.Text = "Dexterity:";
            labelConstitution.Text = "Constitution:";
            labelStrengthModifier.Text = "Strength Modifier:";
            labelWisdomModifier.Text = "Wisdom Modifier:";
            labelIntelligenceModifier.Text = "Intelligence Modifier:";
            labelCharismaModifier.Text = "Charisma Modifier:";
            labelDexterityModifier.Text = "Dexterity Modifier:";
            labelConstitutionModifier.Text = "Constitution Modifier:";
            labelLanguages.Text = "Languages:";

            listViewCharacterDetails.Items.Clear();
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

        private void orderby_Click(object sender, EventArgs e)
        {

        }
    }
}
