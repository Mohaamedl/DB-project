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
            load_all = new Button();
            textBoxSearch = new TextBox();
            serach = new Label();
            filter = new Button();
            orderby = new Label();
            order = new ComboBox();
            SuspendLayout();
            // 
            // listViewFeats
            // 
            listViewFeats.CheckBoxes = true;
            listViewFeats.FullRowSelect = true;
            listViewFeats.GridLines = true;
            listViewFeats.Location = new Point(12, 35);
            listViewFeats.Name = "listViewFeats";
            listViewFeats.Size = new Size(600, 277);
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
            // load_all
            // 
            load_all.Location = new Point(50, 318);
            load_all.Name = "load_all";
            load_all.Size = new Size(75, 23);
            load_all.TabIndex = 2;
            load_all.Text = "Load All";
            load_all.UseVisualStyleBackColor = true;
            load_all.Click += load_all_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(466, 10);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 35;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(403, 8);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 34;
            serach.Text = "Serach";
            // 
            // filter
            // 
            filter.Location = new Point(9, 6);
            filter.Name = "filter";
            filter.Size = new Size(75, 23);
            filter.TabIndex = 33;
            filter.Text = "Filter";
            filter.UseVisualStyleBackColor = true;
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(90, 8);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(168, 6);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            // 
            // FeatSelectionForm
            // 
            ClientSize = new Size(624, 353);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(load_all);
            Controls.Add(btnSelect);
            Controls.Add(listViewFeats);
            Name = "FeatSelectionForm";
            Text = "Select Feats";
            Load += FeatSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button load_all;
        private TextBox textBoxSearch;
        private Label serach;
        private Button filter;
        private Label orderby;
        private ComboBox order;
    }
}
