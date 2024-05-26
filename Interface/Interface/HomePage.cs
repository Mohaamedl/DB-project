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
    public partial class HomePage : Form
    {
        private List<Character> characters;
        private Character selectedCharacter;
        public HomePage()
        {
            InitializeComponent();
            LoadCharacters();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        private void LoadCharacters()
        {
            // Carregar alguns personagens para exemplo
            characters = new List<Character>
            {
                new Character { Name = "Hero1", HP = 100, Level = 1, Class = "Warrior" },
                new Character { Name = "Hero2", HP = 150, Level = 2, Class = "Mage" }
            };
            listBoxCharacters.DataSource = null;
            listBoxCharacters.DataSource = characters;
            listBoxCharacters.DisplayMember = "Name";
        }
        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = listBoxCharacters.SelectedItem as Character;
            if (selectedCharacter != null)
            {
                labelCharacterName.Text = selectedCharacter.Name;
                labelCharacterHP.Text = $"HP: {selectedCharacter.HP}";
                labelCharacterLevel.Text = $"Level: {selectedCharacter.Level}";
                labelCharacterClass.Text = $"Class: {selectedCharacter.Class}";
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
