namespace Interface
{
    partial class CreateCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TextBox textBoxClass;
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
            textBoxStr = new TextBox();
            textBoxName = new TextBox();
            textBoxHP = new TextBox();
            textBoxLevel = new TextBox();
            textBoxClass = new TextBox();
            buttonSave = new Button();
            labelName = new Label();
            labelHP = new Label();
            labelLevel = new Label();
            labelClass = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            char_mod = new TextBox();
            wisd_mod = new TextBox();
            intel_mod = new TextBox();
            const_mod = new TextBox();
            dex_mod = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
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
            textBox1 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            feats_sel = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label13 = new Label();
            button4 = new Button();
            textBox9 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label14 = new Label();
            textBox10 = new TextBox();
            panel2 = new Panel();
            label15 = new Label();
            listBox5 = new ListBox();
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
            selectedEquipmentListView = new ListView();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStr
            // 
            textBoxStr.Location = new Point(98, 17);
            textBoxStr.Name = "textBoxStr";
            textBoxStr.Size = new Size(54, 23);
            textBoxStr.TabIndex = 18;
            textBoxStr.Text = "10";
            textBoxStr.TextChanged += textBoxStr_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxHP
            // 
            textBoxHP.Location = new Point(100, 60);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(150, 23);
            textBoxHP.TabIndex = 1;
            // 
            // textBoxLevel
            // 
            textBoxLevel.Location = new Point(100, 100);
            textBoxLevel.Name = "textBoxLevel";
            textBoxLevel.Size = new Size(150, 23);
            textBoxLevel.TabIndex = 2;
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new Point(100, 143);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(150, 23);
            textBoxClass.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(98, 384);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 57);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Create";
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
            label1.Click += label1_Click;
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
            panel1.Controls.Add(char_mod);
            panel1.Controls.Add(wisd_mod);
            panel1.Controls.Add(intel_mod);
            panel1.Controls.Add(const_mod);
            panel1.Controls.Add(dex_mod);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(stre_mod);
            panel1.Controls.Add(CONSTITUTION);
            panel1.Controls.Add(DEXTERITY);
            panel1.Controls.Add(textBoxStr);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(992, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 493);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // char_mod
            // 
            char_mod.Location = new Point(183, 197);
            char_mod.Name = "char_mod";
            char_mod.Size = new Size(54, 23);
            char_mod.TabIndex = 29;
            char_mod.Text = "0";
            // 
            // wisd_mod
            // 
            wisd_mod.Location = new Point(183, 155);
            wisd_mod.Name = "wisd_mod";
            wisd_mod.Size = new Size(54, 23);
            wisd_mod.TabIndex = 28;
            wisd_mod.Text = "0";
            // 
            // intel_mod
            // 
            intel_mod.Location = new Point(183, 120);
            intel_mod.Name = "intel_mod";
            intel_mod.Size = new Size(54, 23);
            intel_mod.TabIndex = 27;
            intel_mod.Text = "0";
            // 
            // const_mod
            // 
            const_mod.Location = new Point(183, 88);
            const_mod.Name = "const_mod";
            const_mod.Size = new Size(54, 23);
            const_mod.TabIndex = 26;
            const_mod.Text = "0";
            // 
            // dex_mod
            // 
            dex_mod.Location = new Point(183, 56);
            dex_mod.Name = "dex_mod";
            dex_mod.Size = new Size(54, 23);
            dex_mod.TabIndex = 25;
            dex_mod.Text = "0";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(98, 197);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(54, 23);
            textBox7.TabIndex = 24;
            textBox7.Text = "10";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(98, 155);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(54, 23);
            textBox6.TabIndex = 23;
            textBox6.Text = "10";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 118);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(54, 23);
            textBox5.TabIndex = 22;
            textBox5.Text = "10";
            // 
            // stre_mod
            // 
            stre_mod.Location = new Point(183, 17);
            stre_mod.Name = "stre_mod";
            stre_mod.Size = new Size(54, 23);
            stre_mod.TabIndex = 21;
            stre_mod.Text = "0";
            // 
            // CONSTITUTION
            // 
            CONSTITUTION.Location = new Point(98, 83);
            CONSTITUTION.Name = "CONSTITUTION";
            CONSTITUTION.Size = new Size(54, 23);
            CONSTITUTION.TabIndex = 20;
            CONSTITUTION.Text = "10";
            CONSTITUTION.TextChanged += CONSTITUTION_TextChanged;
            // 
            // DEXTERITY
            // 
            DEXTERITY.Location = new Point(98, 51);
            DEXTERITY.Name = "DEXTERITY";
            DEXTERITY.Size = new Size(54, 23);
            DEXTERITY.TabIndex = 19;
            DEXTERITY.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 200);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 4;
            label7.Text = "CHARISMA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 163);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 17;
            label10.Text = "WISDOM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 25);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 3;
            label6.Text = "STRENGTH";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 126);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 2;
            label5.Text = "INTELLIGENCE";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 91);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 1;
            label4.Text = "CONSTITUTION";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 59);
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(350, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 44);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 19;
            label9.Text = "Feats";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(710, 290);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 21;
            label11.Text = "Equipment";
            label11.Click += label11_Click_1;
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
            button1.Location = new Point(579, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // feats_sel
            // 
            feats_sel.Location = new Point(473, 41);
            feats_sel.Name = "feats_sel";
            feats_sel.Size = new Size(100, 23);
            feats_sel.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(256, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(896, 286);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(790, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 300);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 31;
            label13.Text = "Spells";
            // 
            // button4
            // 
            button4.Location = new Point(235, 298);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 32;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(100, 173);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(152, 23);
            textBox9.TabIndex = 34;
            // 
            // button6
            // 
            button6.Location = new Point(256, 140);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 36;
            button6.Text = "Select";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(258, 168);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 37;
            button7.Text = "Select";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(604, 288);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 42;
            button8.Text = "Select";
            button8.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(370, 291);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 41;
            label14.Text = "Traits";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(431, 287);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(155, 23);
            textBox10.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Location = new Point(710, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 233);
            panel2.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(119, 16);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 0;
            label15.Text = "Skills";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(97, 231);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(157, 64);
            listBox5.TabIndex = 45;
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
            selectedSpellsListView.Location = new Point(37, 327);
            selectedSpellsListView.Name = "selectedSpellsListView";
            selectedSpellsListView.Size = new Size(248, 149);
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
            selectedTraitsListView.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            selectedTraitsListView.Location = new Point(370, 344);
            selectedTraitsListView.Name = "selectedTraitsListView";
            selectedTraitsListView.Size = new Size(284, 132);
            selectedTraitsListView.TabIndex = 48;
            selectedTraitsListView.UseCompatibleStateImageBehavior = false;
            selectedTraitsListView.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "name";
            // 
            // selectedEquipmentListView
            // 
            selectedEquipmentListView.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            selectedEquipmentListView.Location = new Point(710, 344);
            selectedEquipmentListView.Name = "selectedEquipmentListView";
            selectedEquipmentListView.Size = new Size(244, 132);
            selectedEquipmentListView.TabIndex = 49;
            selectedEquipmentListView.UseCompatibleStateImageBehavior = false;
            selectedEquipmentListView.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "name";
            // 
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1289, 493);
            Controls.Add(selectedEquipmentListView);
            Controls.Add(selectedTraitsListView);
            Controls.Add(selectedSpellsListView);
            Controls.Add(selectedFeatsListView);
            Controls.Add(listBox5);
            Controls.Add(panel2);
            Controls.Add(button8);
            Controls.Add(label14);
            Controls.Add(textBox10);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox9);
            Controls.Add(button4);
            Controls.Add(label13);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(feats_sel);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelClass);
            Controls.Add(labelLevel);
            Controls.Add(labelHP);
            Controls.Add(labelName);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxLevel);
            Controls.Add(textBoxHP);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CreateCharacter";
            Text = "Create Character";
            Load += CreateCharacter_Load;
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
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox CONSTITUTION;
        private TextBox DEXTERITY;
        private TextBox textBoxStr;
        private TextBox stre_mod;
        private TextBox char_mod;
        private TextBox wisd_mod;
        private TextBox intel_mod;
        private TextBox const_mod;
        private TextBox dex_mod;
        internal TextBox textBoxName;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private Label label11;
        private Label label12;
        private Button button1;
        private TextBox feats_sel;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label13;
        private Button button4;
        private TextBox textBox9;
        private Button button6;
        private Button button7;

        private Button button8;
        private Label label14;
        private TextBox textBox10;
        private Panel panel2;
        private Label label15;
        private ListBox listBox5;
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
        private ListView selectedEquipmentListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader rankSpell;
        private ColumnHeader actionSpell;
        private ColumnHeader raritySpell;
    }
    
}
