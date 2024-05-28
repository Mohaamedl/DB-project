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
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCharacter = new Character
            {
                Name = textBoxName.Text,
                HP = int.Parse(textBoxHP.Text),
                Level = int.Parse(textBoxLevel.Text),
                Class = textBoxClass.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
