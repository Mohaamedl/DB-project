namespace Interface
{
    partial class ClassSelectionForm
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
            Select = new Button();
            listViewClasses = new ListView();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Select
            // 
            Select.Location = new Point(1091, 451);
            Select.Name = "Select";
            Select.Size = new Size(125, 35);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // listViewClasses
            // 
            listViewClasses.CheckBoxes = true;
            listViewClasses.GridLines = true;
            listViewClasses.Location = new Point(40, 28);
            listViewClasses.MultiSelect = false;
            listViewClasses.Name = "listViewClasses";
            listViewClasses.Size = new Size(1202, 417);
            listViewClasses.TabIndex = 2;
            listViewClasses.UseCompatibleStateImageBehavior = false;
            listViewClasses.View = View.Details;
            listViewClasses.ItemCheck += ListViewClass_ItemCheck;
            // 
            // button2
            // 
            button2.Location = new Point(204, 459);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(63, 463);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // ClassSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 509);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewClasses);
            Controls.Add(Select);
            Name = "ClassSelectionForm";
            Text = "Class Selection";
            Load += ClassSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Select;
        private ListView listViewClasses;
        private Button button2;
        private Button button1;
    }
}