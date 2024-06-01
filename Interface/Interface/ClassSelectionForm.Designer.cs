namespace Interface
{
    partial class ClassSelectionForm
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
            Select = new Button();
            listViewClasses = new ListView();
            button2 = new Button();
            button1 = new Button();
            textBoxSearch = new TextBox();
            serach = new Label();
            filter = new Button();
            orderby = new Label();
            order = new ComboBox();
            SuspendLayout();
            // 
            // Select
            // 
            Select.Location = new Point(1091, 451);
            Select.Name = "Select";
            Select.Size = new Size(125, 35);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // listViewClasses
            // 
            listViewClasses.CheckBoxes = true;
            listViewClasses.GridLines = true;
            listViewClasses.Location = new Point(40, 42);
            listViewClasses.MultiSelect = false;
            listViewClasses.Name = "listViewClasses";
            listViewClasses.Size = new Size(1202, 403);
            listViewClasses.TabIndex = 2;
            listViewClasses.UseCompatibleStateImageBehavior = false;
            listViewClasses.View = View.Details;
            listViewClasses.ItemCheck += ListViewClass_ItemCheck;
            // 
            // button2
            // 
            button2.Location = new Point(204, 459);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(63, 463);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(1096, 15);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 35;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(1023, 15);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 34;
            serach.Text = "Serach";
            // 
            // filter
            // 
            filter.Location = new Point(40, 13);
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
            orderby.Location = new Point(146, 15);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(233, 13);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            // 
            // ClassSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 509);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewClasses);
            Controls.Add(Select);
            Name = "ClassSelectionForm";
            Text = "Class Selection";
            Load += ClassSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Select;
        private ListView listViewClasses;
        private Button button2;
        private Button button1;
        private TextBox textBoxSearch;
        private Label serach;
        private Button filter;
        private Label orderby;
        private ComboBox order;
    }
}