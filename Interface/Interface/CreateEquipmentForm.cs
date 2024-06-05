using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class CreateEquipmentForm : Form
    {   
        public Equipment equipment;
        public CreateEquipmentForm()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            equipment = new Equipment
            {
                name = name.Text,
                item_category = item_category.Text,
                item_sub_category = item_sub_category.Text,
                usage = usage.Text,
                bulk = bulk.Text,
                rarity = rarity.Text,
                weapon_category = weapon_category.Text,
                level = Int16.Parse(level.Text),
                price = Int16.Parse(price.Text),
            };
            if (DatabaseHelper.CreateEquipment(equipment))
            {
                MessageBox.Show("Equipment created!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while creating new Equipment!");
            }
        }
    }
}
