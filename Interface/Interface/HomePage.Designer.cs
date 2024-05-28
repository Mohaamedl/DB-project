namespace Interface
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Label labelCharacterHP;
        private System.Windows.Forms.Label labelCharacterLevel;
        private System.Windows.Forms.Label labelCharacterClass;
        private System.Windows.Forms.Button buttonCreateCharacter;
        private System.Windows.Forms.Button buttonEditCharacter;
        private System.Windows.Forms.Button buttonDeleteCharacter;
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
            labelPlayerName = new Label();
            listBoxCharacters = new ListBox();
            labelCharacterName = new Label();
            labelCharacterHP = new Label();
            labelCharacterLevel = new Label();
            labelCharacterClass = new Label();
            buttonCreateCharacter = new Button();
            buttonEditCharacter = new Button();
            buttonDeleteCharacter = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new Point(12, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(74, 15);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // listBoxCharacters
            // 
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.ItemHeight = 15;
            listBoxCharacters.Location = new Point(12, 40);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(200, 259);
            listBoxCharacters.TabIndex = 1;
            listBoxCharacters.SelectedIndexChanged += listBoxCharacters_SelectedIndexChanged;
            // 
            // labelCharacterName
            // 
            labelCharacterName.AutoSize = true;
            labelCharacterName.Location = new Point(230, 40);
            labelCharacterName.Name = "labelCharacterName";
            labelCharacterName.Size = new Size(93, 15);
            labelCharacterName.TabIndex = 2;
            labelCharacterName.Text = "Character Name";
            // 
            // labelCharacterHP
            // 
            labelCharacterHP.AutoSize = true;
            labelCharacterHP.Location = new Point(230, 70);
            labelCharacterHP.Name = "labelCharacterHP";
            labelCharacterHP.Size = new Size(23, 15);
            labelCharacterHP.TabIndex = 3;
            labelCharacterHP.Text = "HP";
            // 
            // labelCharacterLevel
            // 
            labelCharacterLevel.AutoSize = true;
            labelCharacterLevel.Location = new Point(230, 100);
            labelCharacterLevel.Name = "labelCharacterLevel";
            labelCharacterLevel.Size = new Size(34, 15);
            labelCharacterLevel.TabIndex = 4;
            labelCharacterLevel.Text = "Level";
            // 
            // labelCharacterClass
            // 
            labelCharacterClass.AutoSize = true;
            labelCharacterClass.Location = new Point(230, 130);
            labelCharacterClass.Name = "labelCharacterClass";
            labelCharacterClass.Size = new Size(34, 15);
            labelCharacterClass.TabIndex = 5;
            labelCharacterClass.Text = "Class";
            // 
            // buttonCreateCharacter
            // 
            buttonCreateCharacter.Location = new Point(230, 170);
            buttonCreateCharacter.Name = "buttonCreateCharacter";
            buttonCreateCharacter.Size = new Size(120, 23);
            buttonCreateCharacter.TabIndex = 6;
            buttonCreateCharacter.Text = "Create Character";
            buttonCreateCharacter.UseVisualStyleBackColor = true;
            buttonCreateCharacter.Click += buttonCreateCharacter_Click;
            // 
            // buttonEditCharacter
            // 
            buttonEditCharacter.Location = new Point(230, 210);
            buttonEditCharacter.Name = "buttonEditCharacter";
            buttonEditCharacter.Size = new Size(120, 23);
            buttonEditCharacter.TabIndex = 7;
            buttonEditCharacter.Text = "Edit Character";
            buttonEditCharacter.UseVisualStyleBackColor = true;
            buttonEditCharacter.Click += buttonEditCharacter_Click;
            // 
            // buttonDeleteCharacter
            // 
            buttonDeleteCharacter.Location = new Point(230, 250);
            buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            buttonDeleteCharacter.Size = new Size(120, 23);
            buttonDeleteCharacter.TabIndex = 8;
            buttonDeleteCharacter.Text = "Delete Character";
            buttonDeleteCharacter.UseVisualStyleBackColor = true;
            buttonDeleteCharacter.Click += buttonDeleteCharacter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonDeleteCharacter);
            Controls.Add(buttonEditCharacter);
            Controls.Add(buttonCreateCharacter);
            Controls.Add(labelCharacterClass);
            Controls.Add(labelCharacterLevel);
            Controls.Add(labelCharacterHP);
            Controls.Add(labelCharacterName);
            Controls.Add(listBoxCharacters);
            Controls.Add(labelPlayerName);
            Name = "HomePage";
            Text = "Home Page";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
    }
}