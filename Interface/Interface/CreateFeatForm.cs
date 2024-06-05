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
    public partial class CreateFeatForm : Form
    {
        public Feat feat;
        public CreateFeatForm()
        {
            InitializeComponent();
        }

        private void CreateFeatForm_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            feat = new Feat
            {
                name = name.Text,
                prerequisite = Preprequisite.Text,
                summary = Summary.Text,
                rarity = Rarity.Text,
                level = Int16.Parse(Level.Text)
            };
            if (DatabaseHelper.CreateFeat(feat))
            {
                MessageBox.Show("Feat created!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while creating new Feat!");
            }

        }
    }
}
