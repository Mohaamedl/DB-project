namespace Interface
{
    partial class TraitsSelectionForm
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
            listViewTraits = new ListView();
            button2 = new Button();
            button1 = new Button();
            textBoxSearch = new TextBox();
            serach = new Label();
            orderby = new Label();
            order = new ComboBox();
            SuspendLayout();
            // 
            // loadAll
            // 
            loadAll.Location = new Point(53, 480);
            loadAll.Name = "loadAll";
            loadAll.Size = new Size(75, 23);
            loadAll.TabIndex = 0;
            loadAll.Text = "Load all";
            loadAll.UseVisualStyleBackColor = true;
            loadAll.Click += loadAll_Click_1;
            // 
            // Select
            // 
            Select.Location = new Point(367, 480);
            Select.Name = "Select";
            Select.Size = new Size(75, 23);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click_2;
            // 
            // listViewTraits
            // 
            listViewTraits.CheckBoxes = true;
            listViewTraits.GridLines = true;
            listViewTraits.Location = new Point(53, 40);
            listViewTraits.Name = "listViewTraits";
            listViewTraits.Size = new Size(389, 434);
            listViewTraits.TabIndex = 2;
            listViewTraits.UseCompatibleStateImageBehavior = false;
            listViewTraits.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(268, 480);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(144, 480);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(309, 11);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(146, 23);
            textBoxSearch.TabIndex = 35;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(246, 12);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 34;
            serach.Text = "Serach";
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(31, 12);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 32;
            orderby.Text = "Order by";
            // 
            // order
            // 
            order.FormattingEnabled = true;
            order.Location = new Point(109, 10);
            order.Name = "order";
            order.Size = new Size(121, 23);
            order.TabIndex = 31;
            order.SelectedIndexChanged += order_SelectedIndexChanged;
            // 
            // TraitsSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 541);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(orderby);
            Controls.Add(order);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewTraits);
            Controls.Add(Select);
            Controls.Add(loadAll);
            Name = "TraitsSelectionForm";
            Text = "TraitsSelectionForm";
            Load += TraitsSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAll;
        private new Button Select;
        private ListView listViewTraits;
        private Button button2;
        private Button button1;
        private TextBox textBoxSearch;
        private Label serach;
        private Label orderby;
        private ComboBox order;
    }
}