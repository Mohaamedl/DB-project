namespace Interface
{
    partial class EquipmentSelectionForm
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
            Load_all = new Button();
            Select = new Button();
            listViewEquipments = new ListView();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Load_all
            // 
            Load_all.Location = new Point(60, 404);
            Load_all.Name = "Load_all";
            Load_all.Size = new Size(75, 23);
            Load_all.TabIndex = 0;
            Load_all.Text = "Load All";
            Load_all.UseVisualStyleBackColor = true;
            Load_all.Click += Load_all_Click_1;
            // 
            // Select
            // 
            Select.Location = new Point(661, 404);
            Select.Name = "Select";
            Select.Size = new Size(75, 23);
            Select.TabIndex = 1;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // listViewEquipments
            // 
            listViewEquipments.CheckBoxes = true;
            listViewEquipments.GridLines = true;
            listViewEquipments.Location = new Point(60, 29);
            listViewEquipments.Name = "listViewEquipments";
            listViewEquipments.Size = new Size(676, 356);
            listViewEquipments.TabIndex = 2;
            listViewEquipments.UseCompatibleStateImageBehavior = false;
            listViewEquipments.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(265, 408);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(406, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // EquipmentSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewEquipments);
            Controls.Add(Select);
            Controls.Add(Load_all);
            Name = "EquipmentSelectionForm";
            Text = "EquipmentSelectionForm";
            Load += EquipmentSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Load_all;
        private Button Select;
        private ListView listViewEquipments;
        private Button button1;
        private Button button2;
    }
}