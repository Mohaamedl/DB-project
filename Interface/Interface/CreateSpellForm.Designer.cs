namespace Interface
{
    partial class CreateSpellForm
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
            textBoxName = new TextBox();
            boxRank = new TextBox();
            Rarity = new TextBox();
            boxRange = new TextBox();
            Actions = new TextBox();
            Create = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(74, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Spell name";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Name";
            // 
            // boxRank
            // 
            boxRank.Location = new Point(292, 92);
            boxRank.Name = "boxRank";
            boxRank.Size = new Size(100, 23);
            boxRank.TabIndex = 1;
            boxRank.Text = "1";
            // 
            // Rarity
            // 
            Rarity.Location = new Point(292, 35);
            Rarity.Name = "Rarity";
            Rarity.Size = new Size(100, 23);
            Rarity.TabIndex = 2;
            Rarity.Text = "Rarity";
            // 
            // boxRange
            // 
            boxRange.Location = new Point(74, 150);
            boxRange.Name = "boxRange";
            boxRange.Size = new Size(100, 23);
            boxRange.TabIndex = 4;
            boxRange.Text = "Range";
            // 
            // Actions
            // 
            Actions.Location = new Point(74, 92);
            Actions.Name = "Actions";
            Actions.Size = new Size(100, 23);
            Actions.TabIndex = 5;
            Actions.Text = "Actions";
            // 
            // Create
            // 
            Create.Location = new Point(579, 377);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 8;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click_1;
            // 
            // CreateSpellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Create);
            Controls.Add(Actions);
            Controls.Add(boxRange);
            Controls.Add(Rarity);
            Controls.Add(boxRank);
            Controls.Add(textBoxName);
            Name = "CreateSpellForm";
            Text = "CreateSpellForm";
            Load += CreateSpellForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox boxRank;
        private TextBox Rarity;
        private TextBox boxRange;
        private TextBox Actions;
        private Button Create;
    }
}