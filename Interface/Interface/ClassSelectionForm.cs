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
    public partial class ClassSelectionForm : Form
    {
        public ClassSelectionForm(List<Class> classes, User user)
        {
            
            InitializeComponent();
            Classes = classes ?? new List<Class>();
            SelectedClass = new List<Class>();
            if(user.Role == "admin")
            {
                button1.Enabled = true; button2.Enabled = true;

            }
        }

        private void ClasseSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayClasses(Classes);
        }
        private List<Class> Classes { get; set; }
        public List<Class> SelectedClass { get; set; }




        private void DisplayClasses(List<Class> classe)
        {
            listViewClasses.Columns.Add("Name", 100);
            listViewClasses.Columns.Add("HP", 40);
            listViewClasses.Columns.Add("Proficiency Attack", 450);
            listViewClasses.Columns.Add("Proficiency Defense", 450);
            listViewClasses.Columns.Add("Ability", 50);




            foreach (var cl in Classes)
            {
                var item = new ListViewItem(cl.name)
                {
                    Tag = cl
                };

                item.SubItems.Add(cl.HP.ToString());
                item.SubItems.Add(cl.prof_attack);
                item.SubItems.Add(cl.prof_defense);
                item.SubItems.Add(cl.ability);


                listViewClasses.Items.Add(item);
            }
        }






        private void LoadAllClasses()
        {
            try
            {
                Classes = DatabaseHelper.GetAllClassesFromDatabase();
                DisplayClasses(Classes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all classes from database: " + ex.Message);
            }
        }




        private void ListViewClass_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Se a caixa de seleção está sendo marcada
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar todas as outras caixas de seleção
                foreach (ListViewItem item in listViewClasses.Items)
                {
                    if (item.Index != e.Index)
                    {
                        item.Checked = false;
                    }
                }
            }
        }









        private void ClassSelectionForm_Load(object sender, EventArgs e)
        {
            LoadAllClasses();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SelectedClass.Clear();
            foreach (ListViewItem item in listViewClasses.CheckedItems)
            {
                SelectedClass.Add((Class)item.Tag);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
