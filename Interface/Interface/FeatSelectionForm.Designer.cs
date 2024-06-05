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
            Create = new Button();
            numericUpDownLimit = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            comboBoxRarityFilter = new ComboBox();
            comboBoxLevelFilter = new ComboBox();
            sortOrder = new Button();
            textBoxSearch = new TextBox();
            search = new Label();
            orderby = new Label();
            order = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLimit).BeginInit();
            SuspendLayout();
            // 
            // listViewFeats
            // 
            listViewFeats.CheckBoxes = true;
            listViewFeats.FullRowSelect = true;
            listViewFeats.GridLines = true;
            listViewFeats.Location = new Point(12, 68);
            listViewFeats.Name = "listViewFeats";
            listViewFeats.Size = new Size(600, 277);
            listViewFeats.TabIndex = 0;
            listViewFeats.UseCompatibleStateImageBehavior = false;
            listViewFeats.View = View.Details;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(537, 351);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // load_all
            // 
            load_all.Location = new Point(50, 351);
            load_all.Name = "load_all";
            load_all.Size = new Size(75, 23);
            load_all.TabIndex = 2;
            load_all.Text = "Load All";
            load_all.UseVisualStyleBackColor = true;
            load_all.Click += load_all_Click;
            // 
            // Create
            // 
            Create.Enabled = false;
            Create.Location = new Point(156, 351);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 36;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // numericUpDownLimit
            // 
            numericUpDownLimit.Location = new Point(492, 41);
            numericUpDownLimit.Name = "numericUpDownLimit";
            numericUpDownLimit.Size = new Size(120, 23);
            numericUpDownLimit.TabIndex = 52;
            numericUpDownLimit.ValueChanged += numericUpDownLimit_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 46);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 51;
            label2.Text = "Rarity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 50;
            label1.Text = "Level";
            // 
            // comboBoxRarityFilter
            // 
            comboBoxRarityFilter.FormattingEnabled = true;
            comboBoxRarityFilter.Location = new Point(307, 43);
            comboBoxRarityFilter.Name = "comboBoxRarityFilter";
            comboBoxRarityFilter.Size = new Size(121, 23);
            comboBoxRarityFilter.TabIndex = 49;
            comboBoxRarityFilter.SelectedIndexChanged += comboBoxRarityFilter_SelectedIndexChanged;
            // 
            // comboBoxLevelFilter
            // 
            comboBoxLevelFilter.FormattingEnabled = true;
            comboBoxLevelFilter.Location = new Point(89, 43);
            comboBoxLevelFilter.Name = "comboBoxLevelFilter";
            comboBoxLevelFilter.Size = new Size(121, 23);
            comboBoxLevelFilter.TabIndex = 48;
            comboBoxLevelFilter.SelectedIndexChanged += comboBoxRankFilter_SelectedIndexChanged;
            // 
            // sortOrder
            // 
            sortOrder.Location = new Point(216, 15);
            sortOrder.Name = "sortOrder";
            sortOrder.Size = new Size(75, 23);
            sortOrder.TabIndex = 47;
            sortOrder.Text = "Order";
            sortOrder.UseVisualStyleBackColor = true;
            sortOrder.Click += sortOrder_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(466, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 46;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new Font("Segoe UI", 12F);
            search.Location = new Point(400, 12);
            search.Name = "search";
            search.Size = new Size(57, 21);
            search.TabIndex = 45;
            search.Text = "Search";
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(11, 12);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 44;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(89, 14);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 43;
            order.SelectedIndexChanged += order_SelectedIndexChanged;
            // 
            // FeatSelectionForm
            // 
            ClientSize = new Size(632, 388);
            Controls.Add(numericUpDownLimit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRarityFilter);
            Controls.Add(comboBoxLevelFilter);
            Controls.Add(sortOrder);
            Controls.Add(textBoxSearch);
            Controls.Add(search);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(Create);
            Controls.Add(load_all);
            Controls.Add(btnSelect);
            Controls.Add(listViewFeats);
            Name = "FeatSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Feats";
            Load += FeatSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLimit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button load_all;
        private Button Create;
        private NumericUpDown numericUpDownLimit;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRarityFilter;
        private ComboBox comboBoxLevelFilter;
        private Button sortOrder;
        private TextBox textBoxSearch;
        private Label search;
        private Label orderby;
        private ComboBox order;
    }
}
