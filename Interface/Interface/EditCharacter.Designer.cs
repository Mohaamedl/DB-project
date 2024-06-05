namespace Interface
{
    partial class EditCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TextBox class_sel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelClass;


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
            STRENGTH = new TextBox();
            textBoxName = new TextBox();
            HP = new TextBox();
            textBoxLevel = new TextBox();
            class_sel = new TextBox();
            buttonSave = new Button();
            labelName = new Label();
            labelHP = new Label();
            labelLevel = new Label();
            labelClass = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label16 = new Label();
            char_mod = new TextBox();
            wisd_mod = new TextBox();
            intel_mod = new TextBox();
            const_mod = new TextBox();
            dex_mod = new TextBox();
            CHARISMA = new TextBox();
            WISDOM = new TextBox();
            INTELLIGENCE = new TextBox();
            stre_mod = new TextBox();
            CONSTITUTION = new TextBox();
            DEXTERITY = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            speed = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            background_sel = new TextBox();
            label13 = new Label();
            button4 = new Button();
            ancestry_sel = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label14 = new Label();
            panel2 = new Panel();
            listViewSkills = new ListView();
            skillName = new ColumnHeader();
            skill_value = new ColumnHeader();
            skilDetails = new ColumnHeader();
            label15 = new Label();
            selectedFeatsListView = new ListView();
            name = new ColumnHeader();
            rarity = new ColumnHeader();
            prerequisite = new ColumnHeader();
            level = new ColumnHeader();
            selectedSpellsListView = new ListView();
            nameSpell = new ColumnHeader();
            rankSpell = new ColumnHeader();
            actionSpell = new ColumnHeader();
            raritySpell = new ColumnHeader();
            selectedTraitsListView = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            selectedEquipmentsListView = new ListView();
            equip_name = new ColumnHeader();
            item_category = new ColumnHeader();
            equip_level = new ColumnHeader();
            equip_price = new ColumnHeader();
            equip_usage = new ColumnHeader();
            LanguagesList = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // STRENGTH
            // 
            STRENGTH.Location = new Point(108, 48);
            STRENGTH.Name = "STRENGTH";
            STRENGTH.Size = new Size(54, 23);
            STRENGTH.TabIndex = 18;
            STRENGTH.Text = "10";
            STRENGTH.TextChanged += textBoxStr_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 23);
            textBoxName.TabIndex = 0;
            // 
            // HP
            // 
            HP.Enabled = false;
            HP.Location = new Point(100, 60);
            HP.Name = "HP";
            HP.Size = new Size(150, 23);
            HP.TabIndex = 1;
            // 
            // textBoxLevel
            // 
            textBoxLevel.Location = new Point(100, 100);
            textBoxLevel.Name = "textBoxLevel";
            textBoxLevel.Size = new Size(150, 23);
            textBoxLevel.TabIndex = 2;
            textBoxLevel.Text = "1";
            // 
            // class_sel
            // 
            class_sel.Location = new Point(100, 143);
            class_sel.Name = "class_sel";
            class_sel.Size = new Size(150, 23);
            class_sel.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(98, 384);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 57);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Edit";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(20, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Location = new Point(20, 63);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(23, 15);
            labelHP.TabIndex = 6;
            labelHP.Text = "HP";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(20, 103);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(34, 15);
            labelLevel.TabIndex = 7;
            labelLevel.Text = "Level";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(20, 143);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(34, 15);
            labelClass.TabIndex = 8;
            labelClass.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 243);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Language(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 176);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 12;
            label2.Text = "Ancestry";
            // 
            // panel1
            // 
            panel1.Controls.Add(label16);
            panel1.Controls.Add(char_mod);
            panel1.Controls.Add(wisd_mod);
            panel1.Controls.Add(intel_mod);
            panel1.Controls.Add(const_mod);
            panel1.Controls.Add(dex_mod);
            panel1.Controls.Add(CHARISMA);
            panel1.Controls.Add(WISDOM);
            panel1.Controls.Add(INTELLIGENCE);
            panel1.Controls.Add(stre_mod);
            panel1.Controls.Add(CONSTITUTION);
            panel1.Controls.Add(DEXTERITY);
            panel1.Controls.Add(STRENGTH);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1082, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 562);
            panel1.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(193, 23);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 30;
            label16.Text = "MOD";
            // 
            // char_mod
            // 
            char_mod.Location = new Point(193, 228);
            char_mod.Name = "char_mod";
            char_mod.Size = new Size(54, 23);
            char_mod.TabIndex = 29;
            char_mod.Text = "0";
            // 
            // wisd_mod
            // 
            wisd_mod.Location = new Point(193, 186);
            wisd_mod.Name = "wisd_mod";
            wisd_mod.Size = new Size(54, 23);
            wisd_mod.TabIndex = 28;
            wisd_mod.Text = "0";
            // 
            // intel_mod
            // 
            intel_mod.Location = new Point(193, 151);
            intel_mod.Name = "intel_mod";
            intel_mod.Size = new Size(54, 23);
            intel_mod.TabIndex = 27;
            intel_mod.Text = "0";
            // 
            // const_mod
            // 
            const_mod.Location = new Point(193, 119);
            const_mod.Name = "const_mod";
            const_mod.Size = new Size(54, 23);
            const_mod.TabIndex = 26;
            const_mod.Text = "0";
            // 
            // dex_mod
            // 
            dex_mod.Location = new Point(193, 87);
            dex_mod.Name = "dex_mod";
            dex_mod.Size = new Size(54, 23);
            dex_mod.TabIndex = 25;
            dex_mod.Text = "0";
            // 
            // CHARISMA
            // 
            CHARISMA.Location = new Point(108, 228);
            CHARISMA.Name = "CHARISMA";
            CHARISMA.Size = new Size(54, 23);
            CHARISMA.TabIndex = 24;
            CHARISMA.Text = "10";
            CHARISMA.TextChanged += CHARISMA_TextChanged;
            // 
            // WISDOM
            // 
            WISDOM.Location = new Point(108, 186);
            WISDOM.Name = "WISDOM";
            WISDOM.Size = new Size(54, 23);
            WISDOM.TabIndex = 23;
            WISDOM.Text = "10";
            WISDOM.TextChanged += WISDOM_TextChanged;
            // 
            // INTELLIGENCE
            // 
            INTELLIGENCE.Location = new Point(108, 149);
            INTELLIGENCE.Name = "INTELLIGENCE";
            INTELLIGENCE.Size = new Size(54, 23);
            INTELLIGENCE.TabIndex = 22;
            INTELLIGENCE.Text = "10";
            INTELLIGENCE.TextChanged += INTELLIGENCE_TextChanged;
            // 
            // stre_mod
            // 
            stre_mod.Location = new Point(193, 48);
            stre_mod.Name = "stre_mod";
            stre_mod.Size = new Size(54, 23);
            stre_mod.TabIndex = 21;
            stre_mod.Text = "0";
            // 
            // CONSTITUTION
            // 
            CONSTITUTION.Location = new Point(108, 114);
            CONSTITUTION.Name = "CONSTITUTION";
            CONSTITUTION.Size = new Size(54, 23);
            CONSTITUTION.TabIndex = 20;
            CONSTITUTION.Text = "10";
            CONSTITUTION.TextChanged += CONSTITUTION_TextChanged;
            // 
            // DEXTERITY
            // 
            DEXTERITY.Location = new Point(108, 82);
            DEXTERITY.Name = "DEXTERITY";
            DEXTERITY.Size = new Size(54, 23);
            DEXTERITY.TabIndex = 19;
            DEXTERITY.Text = "10";
            DEXTERITY.TextChanged += DEXTERITY_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 231);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 4;
            label7.Text = "CHARISMA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 194);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 17;
            label10.Text = "WISDOM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 56);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 3;
            label6.Text = "STRENGTH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 157);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 2;
            label5.Text = "INTELLIGENCE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 122);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 1;
            label4.Text = "CONSTITUTION";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "DEXTERITY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 17);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "speed";
            // 
            // speed
            // 
            speed.BackColor = SystemColors.InactiveBorder;
            speed.Enabled = false;
            speed.Location = new Point(350, 14);
            speed.Name = "speed";
            speed.Size = new Size(100, 23);
            speed.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 60);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 19;
            label9.Text = "Feats";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(699, 296);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 21;
            label11.Text = "Equipments";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 205);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 22;
            label12.Text = "Background";
            // 
            // button1
            // 
            button1.Location = new Point(584, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(974, 514);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // background_sel
            // 
            background_sel.Location = new Point(98, 202);
            background_sel.Name = "background_sel";
            background_sel.Size = new Size(152, 23);
            background_sel.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 296);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 31;
            label13.Text = "Spells";
            // 
            // button4
            // 
            button4.Location = new Point(234, 514);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 32;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ancestry_sel
            // 
            ancestry_sel.Location = new Point(100, 173);
            ancestry_sel.Name = "ancestry_sel";
            ancestry_sel.Size = new Size(152, 23);
            ancestry_sel.TabIndex = 34;
            // 
            // button6
            // 
            button6.Location = new Point(256, 140);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 36;
            button6.Text = "Select";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(258, 168);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 37;
            button7.Text = "Select";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(584, 514);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 42;
            button8.Text = "Select";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(370, 296);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 41;
            label14.Text = "Traits";
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewSkills);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(730, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 257);
            panel2.TabIndex = 44;
            // 
            // listViewSkills
            // 
            listViewSkills.Columns.AddRange(new ColumnHeader[] { skillName, skill_value, skilDetails });
            listViewSkills.GridLines = true;
            listViewSkills.Location = new Point(20, 40);
            listViewSkills.Name = "listViewSkills";
            listViewSkills.Size = new Size(278, 174);
            listViewSkills.TabIndex = 1;
            listViewSkills.UseCompatibleStateImageBehavior = false;
            listViewSkills.View = View.Details;
            // 
            // skillName
            // 
            skillName.Text = "Name";
            // 
            // skill_value
            // 
            skill_value.Text = "value";
            // 
            // skilDetails
            // 
            skilDetails.Text = "Details";
            skilDetails.Width = 150;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(114, 18);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 0;
            label15.Text = "Skills";
            // 
            // selectedFeatsListView
            // 
            selectedFeatsListView.Columns.AddRange(new ColumnHeader[] { name, rarity, prerequisite, level });
            selectedFeatsListView.Location = new Point(409, 88);
            selectedFeatsListView.Name = "selectedFeatsListView";
            selectedFeatsListView.Size = new Size(295, 137);
            selectedFeatsListView.TabIndex = 46;
            selectedFeatsListView.UseCompatibleStateImageBehavior = false;
            selectedFeatsListView.View = View.Details;
            // 
            // name
            // 
            name.Text = "name";
            // 
            // rarity
            // 
            rarity.Text = "rarity";
            // 
            // prerequisite
            // 
            prerequisite.Text = "prerequisite";
            // 
            // level
            // 
            level.Text = "level";
            // 
            // selectedSpellsListView
            // 
            selectedSpellsListView.Columns.AddRange(new ColumnHeader[] { nameSpell, rankSpell, actionSpell, raritySpell });
            selectedSpellsListView.Location = new Point(36, 329);
            selectedSpellsListView.Name = "selectedSpellsListView";
            selectedSpellsListView.Size = new Size(273, 170);
            selectedSpellsListView.TabIndex = 47;
            selectedSpellsListView.UseCompatibleStateImageBehavior = false;
            selectedSpellsListView.View = View.Details;
            // 
            // nameSpell
            // 
            nameSpell.Text = "name";
            // 
            // rankSpell
            // 
            rankSpell.Text = "rank";
            // 
            // actionSpell
            // 
            actionSpell.Text = "action";
            // 
            // raritySpell
            // 
            raritySpell.Text = "rarity";
            // 
            // selectedTraitsListView
            // 
            selectedTraitsListView.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            selectedTraitsListView.Location = new Point(350, 329);
            selectedTraitsListView.Name = "selectedTraitsListView";
            selectedTraitsListView.Size = new Size(309, 170);
            selectedTraitsListView.TabIndex = 48;
            selectedTraitsListView.UseCompatibleStateImageBehavior = false;
            selectedTraitsListView.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "designation";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "details";
            // 
            // selectedEquipmentsListView
            // 
            selectedEquipmentsListView.Columns.AddRange(new ColumnHeader[] { equip_name, item_category, equip_level, equip_price, equip_usage });
            selectedEquipmentsListView.Location = new Point(708, 329);
            selectedEquipmentsListView.Name = "selectedEquipmentsListView";
            selectedEquipmentsListView.Size = new Size(341, 170);
            selectedEquipmentsListView.TabIndex = 49;
            selectedEquipmentsListView.UseCompatibleStateImageBehavior = false;
            selectedEquipmentsListView.View = View.Details;
            // 
            // equip_name
            // 
            equip_name.Text = "name";
            equip_name.Width = 100;
            // 
            // item_category
            // 
            item_category.Text = "Item Category";
            item_category.Width = 100;
            // 
            // equip_level
            // 
            equip_level.Text = "Level";
            equip_level.Width = 40;
            // 
            // equip_price
            // 
            equip_price.Text = "Price";
            equip_price.Width = 40;
            // 
            // equip_usage
            // 
            equip_usage.Text = "Usage";
            equip_usage.Width = 70;
            // 
            // LanguagesList
            // 
            LanguagesList.Location = new Point(100, 231);
            LanguagesList.Multiline = true;
            LanguagesList.Name = "LanguagesList";
            LanguagesList.Size = new Size(150, 55);
            LanguagesList.TabIndex = 50;
            // 
            // EditCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1379, 562);
            Controls.Add(LanguagesList);
            Controls.Add(selectedEquipmentsListView);
            Controls.Add(selectedTraitsListView);
            Controls.Add(selectedSpellsListView);
            Controls.Add(selectedFeatsListView);
            Controls.Add(panel2);
            Controls.Add(button8);
            Controls.Add(label14);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(ancestry_sel);
            Controls.Add(button4);
            Controls.Add(label13);
            Controls.Add(background_sel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(speed);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelClass);
            Controls.Add(labelLevel);
            Controls.Add(labelHP);
            Controls.Add(labelName);
            Controls.Add(class_sel);
            Controls.Add(textBoxLevel);
            Controls.Add(HP);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditCharacter";
            Text = "Edit Character";
            Load += EditCharacter_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private TextBox CHARISMA;
        private TextBox WISDOM;
        private TextBox INTELLIGENCE;
        private TextBox CONSTITUTION;
        private TextBox DEXTERITY;
        private TextBox STRENGTH;
        private TextBox stre_mod;
        private TextBox char_mod;
        private TextBox wisd_mod;
        private TextBox intel_mod;
        private TextBox const_mod;
        private TextBox dex_mod;
        internal TextBox textBoxName;
        private Label label8;
        private TextBox speed;
        private Label label9;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox background_sel;
        private Label label13;
        private Button button4;
        private TextBox ancestry_sel;
        private Button button6;
        private Button button7;

        private Button button8;
        private Label label14;
        private Panel panel2;
        private Label label15;
        private ListView selectedFeatsListView = new System.Windows.Forms.ListView();
        private ColumnHeader columnHeaderNameFeats = new System.Windows.Forms.ColumnHeader();
        private ColumnHeader columnHeaderRarityFeats = new System.Windows.Forms.ColumnHeader();
        private ColumnHeader columnHeaderPrerequisiteFeats = new System.Windows.Forms.ColumnHeader();
        private ColumnHeader columnHeaderLevelFeats = new System.Windows.Forms.ColumnHeader();
        private ColumnHeader name;
        private ColumnHeader rarity;
        private ColumnHeader prerequisite;
        private ColumnHeader level;
        private ListView selectedSpellsListView;
        private ColumnHeader nameSpell;
        private ListView selectedTraitsListView;
        private ColumnHeader columnHeader2;
        private ListView selectedEquipmentsListView;
        private ColumnHeader equip_name;
        private ColumnHeader rankSpell;
        private ColumnHeader actionSpell;
        private ColumnHeader raritySpell;
        private ColumnHeader columnHeader1;
        private TextBox LanguagesList;
        private ColumnHeader item_category;
        private ColumnHeader equip_level;
        private ColumnHeader equip_price;
        private ColumnHeader equip_usage;
        private Label label16;
        private ListView listViewSkills;
        private ColumnHeader skillName;
        public ColumnHeader skill_value;
        private ColumnHeader skilDetails;
    }

}
