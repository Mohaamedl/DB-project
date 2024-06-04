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
        private System.Windows.Forms.Label labelClass;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            labelPlayerName = new Label();
            listBoxCharacters = new ListBox();
            labelCharacterName = new Label();
            labelCharacterHP = new Label();
            labelCharacterLevel = new Label();
            labelClass = new Label();
            buttonCreateCharacter = new Button();
            buttonEditCharacter = new Button();
            buttonDeleteCharacter = new Button();
            button1 = new Button();
            listViewCharacterDetails = new ListView();
            labelAncestry = new Label();
            labelStrength = new Label();
            labelWisdom = new Label();
            labelCharisma = new Label();
            labelIntelligence = new Label();
            labelDexterity = new Label();
            labelConstitution = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelStrengthModifier = new Label();
            labelConstitutionModifier = new Label();
            labelWisdomModifier = new Label();
            labelDexterityModifier = new Label();
            labelIntelligenceModifier = new Label();
            labelCharismaModifier = new Label();
            labelBackground = new Label();
            labelSpeed = new Label();
            labelLanguages = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            orderby = new Label();
            filter_character = new Button();
            textBoxSearch = new TextBox();
            serach = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            listBoxCharacters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.ItemHeight = 15;
            listBoxCharacters.Location = new Point(12, 91);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(503, 289);
            listBoxCharacters.TabIndex = 1;
            listBoxCharacters.SelectedIndexChanged += listBoxCharacters_SelectedIndexChanged;
            // 
            // labelCharacterName
            // 
            labelCharacterName.AutoSize = true;
            labelCharacterName.Location = new Point(3, 45);
            labelCharacterName.Name = "labelCharacterName";
            labelCharacterName.Size = new Size(93, 15);
            labelCharacterName.TabIndex = 2;
            labelCharacterName.Text = "Character Name";
            // 
            // labelCharacterHP
            // 
            labelCharacterHP.AutoSize = true;
            labelCharacterHP.Location = new Point(3, 82);
            labelCharacterHP.Name = "labelCharacterHP";
            labelCharacterHP.Size = new Size(23, 15);
            labelCharacterHP.TabIndex = 3;
            labelCharacterHP.Text = "HP";
            // 
            // labelCharacterLevel
            // 
            labelCharacterLevel.AutoSize = true;
            labelCharacterLevel.Location = new Point(3, 115);
            labelCharacterLevel.Name = "labelCharacterLevel";
            labelCharacterLevel.Size = new Size(34, 15);
            labelCharacterLevel.TabIndex = 4;
            labelCharacterLevel.Text = "Level";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(3, 190);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(34, 15);
            labelClass.TabIndex = 5;
            labelClass.Text = "Class";
            // 
            // buttonCreateCharacter
            // 
            buttonCreateCharacter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateCharacter.Location = new Point(1031, 428);
            buttonCreateCharacter.Name = "buttonCreateCharacter";
            buttonCreateCharacter.Size = new Size(120, 39);
            buttonCreateCharacter.TabIndex = 6;
            buttonCreateCharacter.Text = "Create Character";
            buttonCreateCharacter.UseVisualStyleBackColor = true;
            buttonCreateCharacter.Click += buttonCreateCharacter_Click;
            // 
            // buttonEditCharacter
            // 
            buttonEditCharacter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditCharacter.Location = new Point(1031, 473);
            buttonEditCharacter.Name = "buttonEditCharacter";
            buttonEditCharacter.Size = new Size(120, 34);
            buttonEditCharacter.TabIndex = 7;
            buttonEditCharacter.Text = "Edit Character";
            buttonEditCharacter.UseVisualStyleBackColor = true;
            buttonEditCharacter.Click += buttonEditCharacter_Click;
            // 
            // buttonDeleteCharacter
            // 
            buttonDeleteCharacter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeleteCharacter.Location = new Point(1031, 513);
            buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            buttonDeleteCharacter.Size = new Size(120, 34);
            buttonDeleteCharacter.TabIndex = 8;
            buttonDeleteCharacter.Text = "Delete Character";
            buttonDeleteCharacter.UseVisualStyleBackColor = true;
            buttonDeleteCharacter.Click += buttonDeleteCharacter_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1103, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listViewCharacterDetails
            // 
            listViewCharacterDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listViewCharacterDetails.GridLines = true;
            listViewCharacterDetails.Location = new Point(12, 425);
            listViewCharacterDetails.Name = "listViewCharacterDetails";
            listViewCharacterDetails.Size = new Size(918, 140);
            listViewCharacterDetails.TabIndex = 10;
            listViewCharacterDetails.UseCompatibleStateImageBehavior = false;
            // 
            // labelAncestry
            // 
            labelAncestry.AutoSize = true;
            labelAncestry.Location = new Point(3, 236);
            labelAncestry.Name = "labelAncestry";
            labelAncestry.Size = new Size(53, 15);
            labelAncestry.TabIndex = 11;
            labelAncestry.Text = "Ancestry";
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Location = new Point(50, 63);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(52, 15);
            labelStrength.TabIndex = 12;
            labelStrength.Text = "Strength";
            // 
            // labelWisdom
            // 
            labelWisdom.AutoSize = true;
            labelWisdom.Location = new Point(50, 103);
            labelWisdom.Name = "labelWisdom";
            labelWisdom.Size = new Size(51, 15);
            labelWisdom.TabIndex = 13;
            labelWisdom.Text = "Wisdom";
            // 
            // labelCharisma
            // 
            labelCharisma.AutoSize = true;
            labelCharisma.Location = new Point(50, 194);
            labelCharisma.Name = "labelCharisma";
            labelCharisma.Size = new Size(57, 15);
            labelCharisma.TabIndex = 14;
            labelCharisma.Text = "Charisma";
            // 
            // labelIntelligence
            // 
            labelIntelligence.AutoSize = true;
            labelIntelligence.Location = new Point(50, 148);
            labelIntelligence.Name = "labelIntelligence";
            labelIntelligence.Size = new Size(68, 15);
            labelIntelligence.TabIndex = 15;
            labelIntelligence.Text = "Intelligence";
            // 
            // labelDexterity
            // 
            labelDexterity.AutoSize = true;
            labelDexterity.Location = new Point(50, 234);
            labelDexterity.Name = "labelDexterity";
            labelDexterity.Size = new Size(54, 15);
            labelDexterity.TabIndex = 16;
            labelDexterity.Text = "Dexterity";
            // 
            // labelConstitution
            // 
            labelConstitution.AutoSize = true;
            labelConstitution.Location = new Point(50, 277);
            labelConstitution.Name = "labelConstitution";
            labelConstitution.Size = new Size(73, 15);
            labelConstitution.TabIndex = 17;
            labelConstitution.Text = "Constitution";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelStrengthModifier);
            panel1.Controls.Add(labelConstitutionModifier);
            panel1.Controls.Add(labelWisdomModifier);
            panel1.Controls.Add(labelDexterityModifier);
            panel1.Controls.Add(labelIntelligenceModifier);
            panel1.Controls.Add(labelCharismaModifier);
            panel1.Controls.Add(labelStrength);
            panel1.Controls.Add(labelConstitution);
            panel1.Controls.Add(labelWisdom);
            panel1.Controls.Add(labelDexterity);
            panel1.Controls.Add(labelIntelligence);
            panel1.Controls.Add(labelCharisma);
            panel1.Location = new Point(732, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 334);
            panel1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 23);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 25;
            label3.Text = "Modifiers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 24;
            label2.Text = "Physical Attributes";
            // 
            // labelStrengthModifier
            // 
            labelStrengthModifier.AutoSize = true;
            labelStrengthModifier.Location = new Point(237, 63);
            labelStrengthModifier.Name = "labelStrengthModifier";
            labelStrengthModifier.Size = new Size(52, 15);
            labelStrengthModifier.TabIndex = 18;
            labelStrengthModifier.Text = "Strength";
            // 
            // labelConstitutionModifier
            // 
            labelConstitutionModifier.AutoSize = true;
            labelConstitutionModifier.Location = new Point(237, 277);
            labelConstitutionModifier.Name = "labelConstitutionModifier";
            labelConstitutionModifier.Size = new Size(73, 15);
            labelConstitutionModifier.TabIndex = 23;
            labelConstitutionModifier.Text = "Constitution";
            // 
            // labelWisdomModifier
            // 
            labelWisdomModifier.AutoSize = true;
            labelWisdomModifier.Location = new Point(237, 103);
            labelWisdomModifier.Name = "labelWisdomModifier";
            labelWisdomModifier.Size = new Size(51, 15);
            labelWisdomModifier.TabIndex = 19;
            labelWisdomModifier.Text = "Wisdom";
            // 
            // labelDexterityModifier
            // 
            labelDexterityModifier.AutoSize = true;
            labelDexterityModifier.Location = new Point(237, 234);
            labelDexterityModifier.Name = "labelDexterityModifier";
            labelDexterityModifier.Size = new Size(54, 15);
            labelDexterityModifier.TabIndex = 22;
            labelDexterityModifier.Text = "Dexterity";
            // 
            // labelIntelligenceModifier
            // 
            labelIntelligenceModifier.AutoSize = true;
            labelIntelligenceModifier.Location = new Point(237, 148);
            labelIntelligenceModifier.Name = "labelIntelligenceModifier";
            labelIntelligenceModifier.Size = new Size(68, 15);
            labelIntelligenceModifier.TabIndex = 21;
            labelIntelligenceModifier.Text = "Intelligence";
            // 
            // labelCharismaModifier
            // 
            labelCharismaModifier.AutoSize = true;
            labelCharismaModifier.Location = new Point(237, 194);
            labelCharismaModifier.Name = "labelCharismaModifier";
            labelCharismaModifier.Size = new Size(57, 15);
            labelCharismaModifier.TabIndex = 20;
            labelCharismaModifier.Text = "Charisma";
            // 
            // labelBackground
            // 
            labelBackground.AutoSize = true;
            labelBackground.Location = new Point(3, 279);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new Size(71, 15);
            labelBackground.TabIndex = 19;
            labelBackground.Text = "Background";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(3, 150);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(39, 15);
            labelSpeed.TabIndex = 20;
            labelSpeed.Text = "Speed";
            // 
            // labelLanguages
            // 
            labelLanguages.AutoSize = true;
            labelLanguages.Location = new Point(3, 314);
            labelLanguages.Name = "labelLanguages";
            labelLanguages.Size = new Size(64, 15);
            labelLanguages.TabIndex = 21;
            labelLanguages.Text = "Languages";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 401);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 22;
            label1.Text = "More Details:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // orderby
            // 
            orderby.AutoSize = true;
            orderby.Font = new Font("Segoe UI", 12F);
            orderby.Location = new Point(92, 61);
            orderby.Name = "orderby";
            orderby.Size = new Size(72, 21);
            orderby.TabIndex = 24;
            orderby.Text = "Order by";
            // 
            // filter_character
            // 
            filter_character.Location = new Point(11, 61);
            filter_character.Name = "filter_character";
            filter_character.Size = new Size(75, 23);
            filter_character.TabIndex = 25;
            filter_character.Text = "Filter";
            filter_character.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(397, 58);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(117, 23);
            textBoxSearch.TabIndex = 37;
            // 
            // serach
            // 
            serach.AutoSize = true;
            serach.Font = new Font("Segoe UI", 12F);
            serach.Location = new Point(334, 60);
            serach.Name = "serach";
            serach.Size = new Size(57, 21);
            serach.TabIndex = 36;
            serach.Text = "Serach";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelCharacterName);
            panel2.Controls.Add(labelCharacterHP);
            panel2.Controls.Add(labelLanguages);
            panel2.Controls.Add(labelCharacterLevel);
            panel2.Controls.Add(labelSpeed);
            panel2.Controls.Add(labelClass);
            panel2.Controls.Add(labelBackground);
            panel2.Controls.Add(labelAncestry);
            panel2.Location = new Point(545, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 334);
            panel2.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 15);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 22;
            label4.Text = "General Attributes";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1186, 577);
            Controls.Add(panel2);
            Controls.Add(textBoxSearch);
            Controls.Add(serach);
            Controls.Add(filter_character);
            Controls.Add(orderby);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(listViewCharacterDetails);
            Controls.Add(button1);
            Controls.Add(buttonDeleteCharacter);
            Controls.Add(buttonEditCharacter);
            Controls.Add(buttonCreateCharacter);
            Controls.Add(listBoxCharacters);
            Controls.Add(labelPlayerName);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listViewCharacterDetails;
        private Label labelAncestry;
        private Label labelStrength;
        private Label labelWisdom;
        private Label labelCharisma;
        private Label labelIntelligence;
        private Label labelDexterity;
        private Label labelConstitution;
        private Panel panel1;
        private Label labelBackground;
        private Label labelSpeed;
        private Label labelLanguages;
        private Label labelStrengthModifier;
        private Label labelConstitutionModifier;
        private Label labelWisdomModifier;
        private Label labelDexterityModifier;
        private Label labelIntelligenceModifier;
        private Label labelCharismaModifier;
        private Label label1;
        private ComboBox comboBox1;
        private Label orderby;
        private Button filter_character;
        private TextBox textBoxSearch;
        private Label serach;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label4;
    }
}