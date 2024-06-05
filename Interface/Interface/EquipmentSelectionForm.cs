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
    public partial class EquipmentSelectionForm : Form
    {
        private List<Equipment> Equipments { get; set; }
        public List<Equipment> SelectedEquipments { get; set; }

        public EquipmentSelectionForm(List<Equipment> equipments,User user)
        {
            

            InitializeComponent();
            Equipments = equipments ?? new List<Equipment>();
            SelectedEquipments = new List<Equipment>();
            if (user.Role == "admin")
            {
                Create.Enabled = true; button2.Enabled = true;

            }


        }

        private void EquipmentSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayEquipments(Equipments);
        }
        private void DisplayEquipments(List<Equipment> equipments)
        {
            listViewEquipments.Columns.Add("Name", 150);
            listViewEquipments.Columns.Add("Item Category", 100);
            listViewEquipments.Columns.Add("Item sub-Category", 100);
            listViewEquipments.Columns.Add("Weapon Category", 100);
            listViewEquipments.Columns.Add("level", 50);
            listViewEquipments.Columns.Add("Price", 50);
            listViewEquipments.Columns.Add("Rarity", 70);
            listViewEquipments.Columns.Add("Usage", 100);
            listViewEquipments.Columns.Add("Bulk", 50);

            foreach (var equipment in Equipments)
            {
                var item = new ListViewItem(equipment.name)
                {
                    Tag = equipment
                };
                item.SubItems.Add(equipment.item_category);
                item.SubItems.Add(equipment.item_sub_category);
                item.SubItems.Add(equipment.weapon_category);
                item.SubItems.Add(equipment.level.ToString());
                item.SubItems.Add(equipment.price.ToString());
                item.SubItems.Add(equipment.rarity);
                item.SubItems.Add(equipment.usage);
                item.SubItems.Add(equipment.bulk);
                listViewEquipments.Items.Add(item);
            }
        }



        private void listViewEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadAllEquipments()
        {
            try
            {
                Equipments = DatabaseHelper.GetAllEquipmentsFromDatabase();
                DisplayEquipments(Equipments);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all equipments from database: " + ex.Message);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedEquipments.Clear();
            foreach (ListViewItem item in listViewEquipments.CheckedItems)
            {
                SelectedEquipments.Add((Equipment)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void Load_all_Click_1(object sender, EventArgs e)
        {
            LoadAllEquipments();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateEquipmentForm createEquipment = new CreateEquipmentForm();
            createEquipment.ShowDialog();
            if (DialogResult.OK == createEquipment.DialogResult)
            {
                Equipments = DatabaseHelper.GetEquipmentsFromDatabase();
                Equipments.Add(createEquipment.equipment);
                DisplayEquipments(Equipments);

            }
        }
    }
}
