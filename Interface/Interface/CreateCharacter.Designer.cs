namespace Interface
{
    partial class CreateCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
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
            textBoxName = new TextBox();
            textBoxHP = new TextBox();
            textBoxLevel = new TextBox();
            textBoxClass = new TextBox();
            buttonSave = new Button();
            labelName = new Label();
            labelHP = new Label();
            labelLevel = new Label();
            labelClass = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 23);
            textBoxName.TabIndex = 0;
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
            textBoxClass.Location = new Point(100, 140);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(150, 23);
            textBoxClass.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(100, 180);
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
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 389);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}