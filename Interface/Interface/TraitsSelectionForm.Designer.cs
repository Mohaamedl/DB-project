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
            listViewTraits.Location = new Point(53, 22);
            listViewTraits.Name = "listViewTraits";
            listViewTraits.Size = new Size(389, 452);
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
            // TraitsSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 541);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewTraits);
            Controls.Add(Select);
            Controls.Add(loadAll);
            Name = "TraitsSelectionForm";
            Text = "TraitsSelectionForm";
            Load += TraitsSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button loadAll;
        private Button Select;
        private ListView listViewTraits;
        private Button button2;
        private Button button1;
    }
}