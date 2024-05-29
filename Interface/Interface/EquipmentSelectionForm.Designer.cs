namespace Interface
{
    partial class EquipmentSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListView listViewEquipment;
        private Button btnSelect;
        private Button load_all;
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
            listViewEquipment = new ListView();
            btnSelect = new Button();
            load_all = new Button();
            SuspendLayout();
            // 
            // listViewEquipment
            // 
            listViewEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEquipment.BorderStyle = BorderStyle.FixedSingle;
            listViewEquipment.CheckBoxes = true;
            listViewEquipment.FullRowSelect = true;
            listViewEquipment.GridLines = true;
            listViewEquipment.Location = new Point(12, 12);
            listViewEquipment.Name = "listViewEquipment";
            listViewEquipment.Size = new Size(758, 380);
            listViewEquipment.TabIndex = 0;
            listViewEquipment.UseCompatibleStateImageBehavior = false;
            listViewEquipment.View = View.Details;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.Location = new Point(614, 408);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(156, 43);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // load_all
            // 
            load_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            load_all.Location = new Point(12, 408);
            load_all.Name = "load_all";
            load_all.Size = new Size(156, 43);
            load_all.TabIndex = 2;
            load_all.Text = "Load All";
            load_all.UseVisualStyleBackColor = true;
            // 
            // EquipmentSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 463);
            Controls.Add(load_all);
            Controls.Add(btnSelect);
            Controls.Add(listViewEquipment);
            Name = "EquipmentSelectionForm";
            Text = "Select Feats";
            Load += EquipmentSelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}