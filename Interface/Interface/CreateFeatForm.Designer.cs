namespace Interface
{
    partial class CreateFeatForm
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
            name = new TextBox();
            Level = new TextBox();
            Summary = new TextBox();
            Rarity = new TextBox();
            Preprequisite = new TextBox();
            Create = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(78, 46);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // Level
            // 
            Level.Location = new Point(78, 189);
            Level.Name = "Level";
            Level.Size = new Size(100, 23);
            Level.TabIndex = 1;
            Level.Text = "1";
            // 
            // Summary
            // 
            Summary.Location = new Point(247, 118);
            Summary.Name = "Summary";
            Summary.Size = new Size(100, 23);
            Summary.TabIndex = 2;
            Summary.Text = "Summary";
            // 
            // Rarity
            // 
            Rarity.Location = new Point(78, 118);
            Rarity.Name = "Rarity";
            Rarity.Size = new Size(100, 23);
            Rarity.TabIndex = 3;
            Rarity.Text = "Rarity";
            // 
            // Preprequisite
            // 
            Preprequisite.Location = new Point(247, 46);
            Preprequisite.Name = "Preprequisite";
            Preprequisite.Size = new Size(100, 23);
            Preprequisite.TabIndex = 4;
            Preprequisite.Text = "Preprequisite ";
            // 
            // Create
            // 
            Create.Location = new Point(274, 207);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 5;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // CreateFeatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(Create);
            Controls.Add(Preprequisite);
            Controls.Add(Rarity);
            Controls.Add(Summary);
            Controls.Add(Level);
            Controls.Add(name);
            Name = "CreateFeatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateFeatForm";
            Load += CreateFeatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox Level;
        private TextBox Summary;
        private TextBox Rarity;
        private TextBox Preprequisite;
        private Button Create;
    }
}