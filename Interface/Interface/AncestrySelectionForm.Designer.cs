namespace Interface
{
    partial class AncestrySelectionForm
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
            LoadAll = new Button();
            Select = new Button();
            listViewAncestries = new ListView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            button1 = new Button();
            filter = new Button();
            orderby = new Label();
            order = new ComboBox();
            serach = new Label();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // LoadAll
            // 
            LoadAll.Location = new Point(59, 396);
            LoadAll.Name = "LoadAll";
            LoadAll.Size = new Size(75, 23);
            LoadAll.TabIndex = 0;
            LoadAll.Text = "Load all";
            LoadAll.UseVisualStyleBackColor = true;
            LoadAll.Click += LoadAll_Click;
            // 
            // Select
            // 
            Select.Location = new Point(636, 396);
            Select.Name = "Select";
            Select.Size = new Size(75, 23);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // listViewAncestries
            // 
            listViewAncestries.CheckBoxes = true;
            listViewAncestries.GridLines = true;
            listViewAncestries.Location = new Point(59, 45);
            listViewAncestries.MultiSelect = false;
            listViewAncestries.Name = "listViewAncestries";
            listViewAncestries.Size = new Size(662, 327);
            listViewAncestries.TabIndex = 2;
            listViewAncestries.UseCompatibleStateImageBehavior = false;
            listViewAncestries.View = View.Details;
            listViewAncestries.ItemCheck += ListViewAncestries_ItemCheck;
            // 
            // button2
            // 
            button2.Location = new Point(402, 396);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(256, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            filter.Location = new Point(62, 16);
            filter.Name = "filter";
            filter.Size = new Size(75, 23);
            filter.TabIndex = 28;
            filter.Text = "Filter";
            filter.UseVisualStyleBackColor = true;
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(143, 18);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 27;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(221, 16);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 26;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(512, 18);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 29;
            serach.Text = "Serach";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(575, 20);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 30;
            // 
            // AncestrySelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewAncestries);
            Controls.Add(Select);
            Controls.Add(LoadAll);
            Name = "AncestrySelectionForm";
            Text = "AncestrySelectionForm";
            Load += AncestrySelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadAll;
        private Button Select;
        private ListView listViewAncestries;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button1;
        private Button filter;
        private Label orderby;
        private ComboBox order;
        private Label serach;
        private TextBox textBoxSearch;
    }
}