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
            serach = new Label();
            filter = new Button();
            orderby = new Label();
            order = new ComboBox();
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
            listViewSpells.Location = new Point(24, 37);
            listViewSpells.Name = "listViewSpells";
            listViewSpells.Size = new Size(722, 340);
            listViewSpells.TabIndex = 2;
            listViewSpells.UseCompatibleStateImageBehavior = false;
            listViewSpells.View = View.Details;
            // 
            // Delete
            // 
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
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(537, 9);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 34;
            serach.Text = "Serach";
            // 
            // filter
            // 
            filter.Location = new Point(25, 7);
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
            orderby.Location = new Point(106, 9);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(184, 7);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            // 
            // SpellSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(Delete);
            Controls.Add(button1);
            Controls.Add(listViewSpells);
            Controls.Add(select);
            Controls.Add(loadAll);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SpellSelectionForm";
            Text = "SpellSelectionForm";
            Load += SpellSelectionForm_Load;
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
        private Label serach;
        private Button filter;
        private Label orderby;
        private ComboBox order;
    }
}