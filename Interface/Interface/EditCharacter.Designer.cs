namespace Interface
{
    partial class EditCharacter
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
            SuspendLayout();
            // 
            // EditCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "EditCharacter";
            Text = "EditCharacter";
            Load += EditCharacter_Load;
            ResumeLayout(false);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(100, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 23);
            this.textBoxName.TabIndex = 0;

            // textBoxHP
            this.textBoxHP.Location = new System.Drawing.Point(100, 60);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(150, 23);
            this.textBoxHP.TabIndex = 1;

            // textBoxLevel
            this.textBoxLevel.Location = new System.Drawing.Point(100, 100);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(150, 23);
            this.textBoxLevel.TabIndex = 2;

            // textBoxClass
            this.textBoxClass.Location = new System.Drawing.Point(100, 140);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(150, 23);
            this.textBoxClass.TabIndex = 3;

            // buttonSave
            this.buttonSave.Location = new System.Drawing.Point(100, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";

            // labelHP
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(20, 63);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(25, 15);
            this.labelHP.TabIndex = 6;
            this.labelHP.Text = "HP";

            // labelLevel
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(20, 103);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 15);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level";

            // labelClass
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(20, 143);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 15);
            this.labelClass.TabIndex = 8;
            this.labelClass.Text = "Class";

            // EditCharacterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxHP);
            this.Controls.Add(this.textBoxName);
            this.Name = "EditCharacterForm";
            this.Text = "Edit Character";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}