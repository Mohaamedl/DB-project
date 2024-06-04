namespace Interface
{
    partial class CreateEquipmentForm
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
            name = new TextBox();
            usage = new TextBox();
            item_category = new TextBox();
            weapon_category = new TextBox();
            bulk = new TextBox();
            level = new TextBox();
            item_sub_category = new TextBox();
            rarity = new TextBox();
            price = new TextBox();
            create = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(72, 27);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // usage
            // 
            usage.Location = new Point(72, 69);
            usage.Name = "usage";
            usage.Size = new Size(100, 23);
            usage.TabIndex = 0;
            usage.Text = "Usage";
            // 
            // item_category
            // 
            item_category.Location = new Point(219, 27);
            item_category.Name = "item_category";
            item_category.Size = new Size(100, 23);
            item_category.TabIndex = 1;
            item_category.Text = "Item Category";
            // 
            // weapon_category
            // 
            weapon_category.Location = new Point(72, 124);
            weapon_category.Name = "weapon_category";
            weapon_category.Size = new Size(100, 23);
            weapon_category.TabIndex = 2;
            weapon_category.Text = "Weapon Category";
            // 
            // bulk
            // 
            bulk.Location = new Point(219, 69);
            bulk.Name = "bulk";
            bulk.Size = new Size(100, 23);
            bulk.TabIndex = 3;
            bulk.Text = "Bulk";
            // 
            // level
            // 
            level.Location = new Point(219, 124);
            level.Name = "level";
            level.Size = new Size(100, 23);
            level.TabIndex = 4;
            level.Text = "Level";
            // 
            // item_sub_category
            // 
            item_sub_category.Location = new Point(404, 27);
            item_sub_category.Name = "item_sub_category";
            item_sub_category.Size = new Size(100, 23);
            item_sub_category.TabIndex = 5;
            item_sub_category.Text = "Item Sub-Category";
            // 
            // rarity
            // 
            rarity.Location = new Point(404, 69);
            rarity.Name = "rarity";
            rarity.Size = new Size(100, 23);
            rarity.TabIndex = 6;
            rarity.Text = "Rarity";
            // 
            // price
            // 
            price.Location = new Point(404, 124);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 7;
            price.Text = "Price";
            // 
            // create
            // 
            create.Location = new Point(602, 375);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 8;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // CreateEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(create);
            Controls.Add(price);
            Controls.Add(rarity);
            Controls.Add(item_sub_category);
            Controls.Add(level);
            Controls.Add(bulk);
            Controls.Add(weapon_category);
            Controls.Add(item_category);
            Controls.Add(usage);
            Controls.Add(name);
            Name = "CreateEquipmentForm";
            Text = "CreateEquipmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox usage;
        private TextBox item_category;
        private TextBox weapon_category;
        private TextBox bulk;
        private TextBox level;
        private TextBox item_sub_category;
        private TextBox rarity;
        private TextBox price;
        private Button create;
    }
}