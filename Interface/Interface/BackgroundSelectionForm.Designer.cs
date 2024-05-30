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
            listViewBackgrounds.Location = new Point(41, 24);
            listViewBackgrounds.MultiSelect = false;
            listViewBackgrounds.Name = "listViewBackgrounds";
            listViewBackgrounds.Size = new Size(711, 365);
            listViewBackgrounds.TabIndex = 2;
            listViewBackgrounds.UseCompatibleStateImageBehavior = false;
            listViewBackgrounds.View = View.Details;
            listViewBackgrounds.ItemCheck += ListViewBackground_ItemCheck;
            // 
            // BackgroundSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewBackgrounds);
            Controls.Add(Select);
            Controls.Add(loadAll);
            Name = "BackgroundSelectionForm";
            Text = "BackgroundSelectionForm";
            Load += BackgroundSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button loadAll;
        private new Button Select;
        private ListView listViewBackgrounds;
    }
}