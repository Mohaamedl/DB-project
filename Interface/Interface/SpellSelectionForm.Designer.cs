namespace Interface
{
    partial class SpellSelectionForm
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
            loadAll = new Button();
            select = new Button();
            listViewSpells = new ListView();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // loadAll
            // 
            loadAll.Location = new Point(59, 405);
            loadAll.Name = "loadAll";
            loadAll.Size = new Size(75, 23);
            loadAll.TabIndex = 0;
            loadAll.Text = "Load All";
            loadAll.UseVisualStyleBackColor = true;
            loadAll.Click += loadAll_Click;
            // 
            // select
            // 
            select.Location = new Point(671, 405);
            select.Name = "select";
            select.Size = new Size(75, 23);
            select.TabIndex = 1;
            select.Text = "Select";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click_1;
            // 
            // listViewSpells
            // 
            listViewSpells.CheckBoxes = true;
            listViewSpells.GridLines = true;
            listViewSpells.Location = new Point(24, 12);
            listViewSpells.Name = "listViewSpells";
            listViewSpells.Size = new Size(722, 365);
            listViewSpells.TabIndex = 2;
            listViewSpells.UseCompatibleStateImageBehavior = false;
            listViewSpells.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(300, 405);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(176, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // SpellSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewSpells);
            Controls.Add(select);
            Controls.Add(loadAll);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SpellSelectionForm";
            Text = "SpellSelectionForm";
            Load += SpellSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button loadAll;
        private Button select;
        private ListView listViewSpells;
        private Button button2;
        private Button button1;
    }
}