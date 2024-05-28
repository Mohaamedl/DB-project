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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
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
            label9 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStr
            // 
            textBoxStr.Location = new Point(98, 17);
            textBoxStr.Name = "textBoxStr";
            textBoxStr.Size = new Size(54, 23);
            textBoxStr.TabIndex = 18;
            textBoxStr.Text = "100";
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
            textBoxClass.Location = new Point(225, 154);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(54, 23);
            textBoxClass.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(20, 354);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 175);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Language(s)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 202);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 12;
            label2.Text = "Ancestry";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(98, 175);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(100, 202);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 14;
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
            panel1.Location = new Point(997, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 234);
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
            label8.Location = new Point(1009, 354);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 5;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(866, 192);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "label9";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(860, 154);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 18;
            label11.Text = "label11";
            label11.Click += label11_Click;
            // 
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 519);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(labelClass);
            Controls.Add(labelLevel);
            Controls.Add(labelHP);
            Controls.Add(labelName);
            Controls.Add(buttonSave);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxLevel);
            Controls.Add(textBoxHP);
            Controls.Add(textBoxName);
            Name = "CreateCharacter";
            Text = "Create Character";
            Load += CreateCharacter_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
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
    }
}