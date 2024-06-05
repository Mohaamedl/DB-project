namespace Interface
{
    partial class SpellSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadAll = new Button();
            select = new Button();
            listViewSpells = new ListView();
            Delete = new Button();
            button1 = new Button();
            textBoxSearch = new TextBox();
            search = new Label();
            orderby = new Label();
            order = new ComboBox();
            Create = new Button();
            sortOrder = new Button();
            comboBoxRankFilter = new ComboBox();
            comboBoxRarityFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDownLimit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLimit).BeginInit();
            SuspendLayout();
            // 
            // loadAll
            // 
            loadAll.Location = new Point(59, 405);
            loadAll.Name = "loadAll";
            loadAll.Size = new Size(75, 23);
            loadAll.TabIndex = 0;
            loadAll.Text = "Load All";
            loadAll.UseVisualStyleBackColor = true;
            loadAll.Click += loadAll_Click;
            // 
            // select
            // 
            select.Location = new Point(671, 405);
            select.Name = "select";
            select.Size = new Size(75, 23);
            select.TabIndex = 1;
            select.Text = "Select";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click_1;
            // 
            // listViewSpells
            // 
            listViewSpells.CheckBoxes = true;
            listViewSpells.GridLines = true;
            listViewSpells.Location = new Point(24, 69);
            listViewSpells.Name = "listViewSpells";
            listViewSpells.Size = new Size(722, 308);
            listViewSpells.TabIndex = 2;
            listViewSpells.UseCompatibleStateImageBehavior = false;
            listViewSpells.View = View.Details;
            // 
            // Delete
            // 
            Delete.Enabled = false;
            Delete.Location = new Point(300, 405);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 6;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(176, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(600, 7);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 35;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new Font("Segoe UI", 12F);
            search.Location = new Point(537, 9);
            search.Name = "search";
            search.Size = new Size(57, 21);
            search.TabIndex = 34;
            search.Text = "Search";
            search.Click += serach_Click;
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(24, 9);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(102, 11);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            order.SelectedIndexChanged += order_SelectedIndexChanged;
            // 
            // Create
            // 
            Create.Enabled = false;
            Create.Location = new Point(424, 405);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 36;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // sortOrder
            // 
            sortOrder.Location = new Point(229, 12);
            sortOrder.Name = "sortOrder";
            sortOrder.Size = new Size(75, 23);
            sortOrder.TabIndex = 37;
            sortOrder.Text = "Order";
            sortOrder.UseVisualStyleBackColor = true;
            sortOrder.Click += sortOrder_Click;
            // 
            // comboBoxRankFilter
            // 
            comboBoxRankFilter.FormattingEnabled = true;
            comboBoxRankFilter.Location = new Point(102, 40);
            comboBoxRankFilter.Name = "comboBoxRankFilter";
            comboBoxRankFilter.Size = new Size(121, 23);
            comboBoxRankFilter.TabIndex = 38;
            comboBoxRankFilter.SelectedIndexChanged += comboBoxRankFilter_SelectedIndexChanged;
            // 
            // comboBoxRarityFilter
            // 
            comboBoxRarityFilter.FormattingEnabled = true;
            comboBoxRarityFilter.Location = new Point(354, 40);
            comboBoxRarityFilter.Name = "comboBoxRarityFilter";
            comboBoxRarityFilter.Size = new Size(121, 23);
            comboBoxRarityFilter.TabIndex = 39;
            comboBoxRarityFilter.SelectedIndexChanged += comboBoxRarityFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 40;
            label1.Text = "Rank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 41;
            label2.Text = "Rarity";
            // 
            // numericUpDownLimit
            // 
            numericUpDownLimit.Location = new Point(570, 41);
            numericUpDownLimit.Name = "numericUpDownLimit";
            numericUpDownLimit.Size = new Size(120, 23);
            numericUpDownLimit.TabIndex = 42;
            numericUpDownLimit.ValueChanged += numericUpDownLimit_ValueChanged;
            // 
            // SpellSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownLimit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRarityFilter);
            Controls.Add(comboBoxRankFilter);
            Controls.Add(sortOrder);
            Controls.Add(Create);
            Controls.Add(textBoxSearch);
            Controls.Add(search);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(Delete);
            Controls.Add(button1);
            Controls.Add(listViewSpells);
            Controls.Add(select);
            Controls.Add(loadAll);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SpellSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpellSelectionForm";
            Load += SpellSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLimit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAll;
        private Button select;
        private ListView listViewSpells;
        private Button Delete;
        private Button button1;
        private TextBox textBoxSearch;
        private Label search;
        private Label orderby;
        private ComboBox order;
        private Button Create;
        private Button sortOrder;
        private ComboBox comboBoxRankFilter;
        private ComboBox comboBoxRarityFilter;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownLimit;
    }
}