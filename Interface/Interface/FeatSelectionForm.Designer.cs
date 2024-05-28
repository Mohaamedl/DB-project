namespace Interface
{
    partial class FeatSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewFeats;
        private Button btnSelect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewFeats = new ListView();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // listViewFeats
            // 
            listViewFeats.CheckBoxes = true;
            listViewFeats.FullRowSelect = true;
            listViewFeats.GridLines = true;
            listViewFeats.HideSelection = false;
            listViewFeats.Location = new Point(12, 12);
            listViewFeats.Name = "listViewFeats";
            listViewFeats.Size = new Size(600, 300);
            listViewFeats.TabIndex = 0;
            listViewFeats.UseCompatibleStateImageBehavior = false;
            listViewFeats.View = View.Details;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(537, 318);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // FeatSelectionForm
            // 
            ClientSize = new Size(624, 353);
            Controls.Add(btnSelect);
            Controls.Add(listViewFeats);
            Name = "FeatSelectionForm";
            Text = "Select Feats";
            Load += FeatSelectionForm_Load;
            ResumeLayout(false);
        }
    }
}
