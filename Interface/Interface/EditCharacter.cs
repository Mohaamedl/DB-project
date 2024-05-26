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
        private Character character;
        public EditCharacter(Character character)
        {
            InitializeComponent();
            this.character = character;
            LoadCharacterData();
        }

        private void EditCharacter_Load(object sender, EventArgs e)
        {

        }
        private void LoadCharacterData()
        {
            textBoxName.Text = character.Name;
            textBoxHP.Text = character.HP.ToString();
            textBoxLevel.Text = character.Level.ToString();
            textBoxClass.Text = character.Class;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            character.Name = textBoxName.Text;
            character.HP = int.Parse(textBoxHP.Text);
            character.Level = int.Parse(textBoxLevel.Text);
            character.Class = textBoxClass.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
