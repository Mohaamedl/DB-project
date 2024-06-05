namespace Interface
{
    partial class EditAncestryForm
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
            textBoxAbilityFlaw = new TextBox();
            textBoxAbilityBoost = new TextBox();
            textBoxSpeed = new TextBox();
            textBoxSize = new TextBox();
            textBoxHP = new TextBox();
            textBoxRarity = new TextBox();
            Save = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAbilityFlaw
            // 
            textBoxAbilityFlaw.Location = new Point(341, 163);
            textBoxAbilityFlaw.Name = "textBoxAbilityFlaw";
            textBoxAbilityFlaw.Size = new Size(100, 23);
            textBoxAbilityFlaw.TabIndex = 1;
            // 
            // textBoxAbilityBoost
            // 
            textBoxAbilityBoost.Location = new Point(341, 55);
            textBoxAbilityBoost.Multiline = true;
            textBoxAbilityBoost.Name = "textBoxAbilityBoost";
            textBoxAbilityBoost.Size = new Size(209, 82);
            textBoxAbilityBoost.TabIndex = 2;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(101, 255);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(100, 23);
            textBoxSpeed.TabIndex = 3;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(101, 177);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(100, 23);
            textBoxSize.TabIndex = 4;
            // 
            // textBoxHP
            // 
            textBoxHP.Location = new Point(101, 114);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(100, 23);
            textBoxHP.TabIndex = 5;
            // 
            // textBoxRarity
            // 
            textBoxRarity.Location = new Point(341, 255);
            textBoxRarity.Name = "textBoxRarity";
            textBoxRarity.Size = new Size(100, 23);
            textBoxRarity.TabIndex = 6;
            // 
            // Save
            // 
            Save.Location = new Point(192, 376);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 7;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // EditAncestryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(textBoxRarity);
            Controls.Add(textBoxHP);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxSpeed);
            Controls.Add(textBoxAbilityBoost);
            Controls.Add(textBoxAbilityFlaw);
            Controls.Add(textBoxName);
            Name = "EditAncestryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAncestryForm";
            Load += EditAncestryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxAbilityFlaw;
        private TextBox textBoxAbilityBoost;
        private TextBox textBoxSpeed;
        private TextBox textBoxSize;
        private TextBox textBoxHP;
        private TextBox textBoxRarity;
        private Button Save;
    }
}