﻿namespace Interface
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
            // EquipmentSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}