namespace Interface
{
    partial class EditSpellForm
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
            textBoxRank = new TextBox();
            textBoxActions = new TextBox();
            textBoxRarity = new TextBox();
            textBoxRange = new TextBox();
            Save = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(133, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxRank
            // 
            textBoxRank.Location = new Point(133, 112);
            textBoxRank.Name = "textBoxRank";
            textBoxRank.Size = new Size(100, 23);
            textBoxRank.TabIndex = 1;
            // 
            // textBoxActions
            // 
            textBoxActions.Location = new Point(133, 172);
            textBoxActions.Name = "textBoxActions";
            textBoxActions.Size = new Size(100, 23);
            textBoxActions.TabIndex = 2;
            // 
            // textBoxRarity
            // 
            textBoxRarity.Location = new Point(133, 218);
            textBoxRarity.Name = "textBoxRarity";
            textBoxRarity.Size = new Size(100, 23);
            textBoxRarity.TabIndex = 3;
            // 
            // textBoxRange
            // 
            textBoxRange.Location = new Point(353, 50);
            textBoxRange.Name = "textBoxRange";
            textBoxRange.Size = new Size(100, 23);
            textBoxRange.TabIndex = 4;
            // 
            // Save
            // 
            Save.Location = new Point(428, 219);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // EditSpellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(textBoxRange);
            Controls.Add(textBoxRarity);
            Controls.Add(textBoxActions);
            Controls.Add(textBoxRank);
            Controls.Add(textBoxName);
            Name = "EditSpellForm";
            Text = "EditSpellForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxRank;
        private TextBox textBoxActions;
        private TextBox textBoxRarity;
        private TextBox textBoxRange;
        private Button Save;
    }
}