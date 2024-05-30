﻿using System;
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
    public partial class BackgroundSelectionForm : Form
    {
        public BackgroundSelectionForm(List<Background> backgrounds)
        {
            InitializeComponent();
            Backgrounds = backgrounds ?? new List<Background>();
            SelectedBackground = new List<Background>();
        }

        private void BackgroundSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayBackgrounds(Backgrounds);
        }
        private List<Background> Backgrounds { get; set; }
        public List<Background> SelectedBackground { get; set; }




        private void DisplayBackgrounds(List<Background> background)
        {
            listViewBackgrounds.Columns.Add("Name", 50);
            listViewBackgrounds.Columns.Add("Ability", 70);
            listViewBackgrounds.Columns.Add("Skill", 70);
            listViewBackgrounds.Columns.Add("Feat", 70);
            listViewBackgrounds.Columns.Add("Rarity", 70);
            listViewBackgrounds.Columns.Add("Summary", 250);
            

            foreach (var ancestry in Backgrounds)
            {
                var item = new ListViewItem(ancestry.name)
                {
                    Tag = ancestry
                };

                item.SubItems.Add(ancestry.ability);
                item.SubItems.Add(ancestry.skill);
                item.SubItems.Add(ancestry.feat);
                item.SubItems.Add(ancestry.rarity);
                item.SubItems.Add(ancestry.summary);
                listViewBackgrounds.Items.Add(item);
            }
        }






        private void LoadAllBackgrounds()
        {
            try
            {
                Backgrounds = DatabaseHelper.GetAllBackgroundsFromDatabase();
                DisplayBackgrounds(Backgrounds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all ancestrys from database: " + ex.Message);
            }
        }




        private void ListViewBackground_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Se a caixa de seleção está sendo marcada
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar todas as outras caixas de seleção
                foreach (ListViewItem item in listViewBackgrounds.Items)
                {
                    if (item.Index != e.Index)
                    {
                        item.Checked = false;
                    }
                }
            }
        }





        private void loadAll_Click(object sender, EventArgs e)
        {
            LoadAllBackgrounds();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedBackground.Clear();
            foreach (ListViewItem item in listViewBackgrounds.CheckedItems)
            {
                SelectedBackground.Add((Background)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}