namespace Interface
{
    partial class BackgroundSelectionForm
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
            Select = new Button();
            listViewBackgrounds = new ListView();
            textBoxSearch = new TextBox();
            serach = new Label();
            filter = new Button();
            orderby = new Label();
            order = new ComboBox();
            SuspendLayout();
            // 
            // loadAll
            // 
            loadAll.Location = new Point(41, 404);
            loadAll.Name = "loadAll";
            loadAll.Size = new Size(75, 23);
            loadAll.TabIndex = 0;
            loadAll.Text = "Load All";
            loadAll.UseVisualStyleBackColor = true;
            loadAll.Click += loadAll_Click;
            // 
            // Select
            // 
            Select.Location = new Point(677, 404);
            Select.Name = "Select";
            Select.Size = new Size(75, 23);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // listViewBackgrounds
            // 
            listViewBackgrounds.CheckBoxes = true;
            listViewBackgrounds.GridLines = true;
            listViewBackgrounds.Location = new Point(41, 50);
            listViewBackgrounds.MultiSelect = false;
            listViewBackgrounds.Name = "listViewBackgrounds";
            listViewBackgrounds.Size = new Size(711, 339);
            listViewBackgrounds.TabIndex = 2;
            listViewBackgrounds.UseCompatibleStateImageBehavior = false;
            listViewBackgrounds.View = View.Details;
            listViewBackgrounds.ItemCheck += ListViewBackground_ItemCheck;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(606, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 35;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(543, 23);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 34;
            serach.Text = "Serach";
            // 
            // filter
            // 
            filter.Location = new Point(42, 21);
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
            orderby.Location = new Point(123, 23);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(201, 21);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            // 
            // BackgroundSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(listViewBackgrounds);
            Controls.Add(Select);
            Controls.Add(loadAll);
            Name = "BackgroundSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BackgroundSelectionForm";
            Load += BackgroundSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAll;
        private new Button Select;
        private ListView listViewBackgrounds;
        private TextBox textBoxSearch;
        private Label serach;
        private Button filter;
        private Label orderby;
        private ComboBox order;
    }
}