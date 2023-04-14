namespace InventoryUI
{
    partial class inventoryDashBoard
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
            this.searchInventoryComboBox = new System.Windows.Forms.ComboBox();
            this.editInventoryItemButton = new System.Windows.Forms.Button();
            this.deleteInventoryItemButton = new System.Windows.Forms.Button();
            this.addNewItemGroupBox = new System.Windows.Forms.GroupBox();
            this.searchItemNameLabel = new System.Windows.Forms.Label();
            this.newItemName = new System.Windows.Forms.Label();
            this.newItemPrice = new System.Windows.Forms.Label();
            this.newItemSpecification = new System.Windows.Forms.Label();
            this.newItemImage = new System.Windows.Forms.Label();
            this.newImageDescription = new System.Windows.Forms.Label();
            this.addNewItemNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemSpecsTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemImageURLTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.getAllInventoryButton = new System.Windows.Forms.Button();
            this.addNewItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchInventoryComboBox
            // 
            this.searchInventoryComboBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryComboBox.FormattingEnabled = true;
            this.searchInventoryComboBox.Location = new System.Drawing.Point(13, 42);
            this.searchInventoryComboBox.Name = "searchInventoryComboBox";
            this.searchInventoryComboBox.Size = new System.Drawing.Size(196, 23);
            this.searchInventoryComboBox.TabIndex = 0;
            // 
            // editInventoryItemButton
            // 
            this.editInventoryItemButton.BackColor = System.Drawing.Color.White;
            this.editInventoryItemButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInventoryItemButton.Location = new System.Drawing.Point(12, 71);
            this.editInventoryItemButton.Name = "editInventoryItemButton";
            this.editInventoryItemButton.Size = new System.Drawing.Size(65, 30);
            this.editInventoryItemButton.TabIndex = 1;
            this.editInventoryItemButton.Text = "Edit Item";
            this.editInventoryItemButton.UseVisualStyleBackColor = false;
            // 
            // deleteInventoryItemButton
            // 
            this.deleteInventoryItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteInventoryItemButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInventoryItemButton.Location = new System.Drawing.Point(132, 71);
            this.deleteInventoryItemButton.Name = "deleteInventoryItemButton";
            this.deleteInventoryItemButton.Size = new System.Drawing.Size(77, 30);
            this.deleteInventoryItemButton.TabIndex = 2;
            this.deleteInventoryItemButton.Text = "Delete Item";
            this.deleteInventoryItemButton.UseVisualStyleBackColor = false;
            // 
            // addNewItemGroupBox
            // 
            this.addNewItemGroupBox.Controls.Add(this.addNewItemDescriptionTextBox);
            this.addNewItemGroupBox.Controls.Add(this.addNewItemImageURLTextBox);
            this.addNewItemGroupBox.Controls.Add(this.addNewItemSpecsTextBox);
            this.addNewItemGroupBox.Controls.Add(this.addNewItemPriceTextBox);
            this.addNewItemGroupBox.Controls.Add(this.addNewItemNameTextBox);
            this.addNewItemGroupBox.Controls.Add(this.newImageDescription);
            this.addNewItemGroupBox.Controls.Add(this.newItemImage);
            this.addNewItemGroupBox.Controls.Add(this.newItemSpecification);
            this.addNewItemGroupBox.Controls.Add(this.newItemPrice);
            this.addNewItemGroupBox.Controls.Add(this.newItemName);
            this.addNewItemGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemGroupBox.Location = new System.Drawing.Point(13, 128);
            this.addNewItemGroupBox.Name = "addNewItemGroupBox";
            this.addNewItemGroupBox.Size = new System.Drawing.Size(266, 166);
            this.addNewItemGroupBox.TabIndex = 3;
            this.addNewItemGroupBox.TabStop = false;
            this.addNewItemGroupBox.Text = "Add New Item";
            // 
            // searchItemNameLabel
            // 
            this.searchItemNameLabel.AutoSize = true;
            this.searchItemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemNameLabel.Location = new System.Drawing.Point(12, 20);
            this.searchItemNameLabel.Name = "searchItemNameLabel";
            this.searchItemNameLabel.Size = new System.Drawing.Size(130, 19);
            this.searchItemNameLabel.TabIndex = 4;
            this.searchItemNameLabel.Text = "Search Item Name";
            // 
            // newItemName
            // 
            this.newItemName.AutoSize = true;
            this.newItemName.Location = new System.Drawing.Point(7, 20);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(47, 16);
            this.newItemName.TabIndex = 0;
            this.newItemName.Text = "Name-";
            // 
            // newItemPrice
            // 
            this.newItemPrice.AutoSize = true;
            this.newItemPrice.Location = new System.Drawing.Point(7, 46);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(42, 16);
            this.newItemPrice.TabIndex = 1;
            this.newItemPrice.Text = "Price-";
            // 
            // newItemSpecification
            // 
            this.newItemSpecification.AutoSize = true;
            this.newItemSpecification.Location = new System.Drawing.Point(7, 75);
            this.newItemSpecification.Name = "newItemSpecification";
            this.newItemSpecification.Size = new System.Drawing.Size(87, 16);
            this.newItemSpecification.TabIndex = 2;
            this.newItemSpecification.Text = "Specification-";
            // 
            // newItemImage
            // 
            this.newItemImage.AutoSize = true;
            this.newItemImage.Location = new System.Drawing.Point(6, 102);
            this.newItemImage.Name = "newItemImage";
            this.newItemImage.Size = new System.Drawing.Size(70, 16);
            this.newItemImage.TabIndex = 3;
            this.newItemImage.Text = "Image url-";
            // 
            // newImageDescription
            // 
            this.newImageDescription.AutoSize = true;
            this.newImageDescription.Location = new System.Drawing.Point(6, 128);
            this.newImageDescription.Name = "newImageDescription";
            this.newImageDescription.Size = new System.Drawing.Size(78, 16);
            this.newImageDescription.TabIndex = 4;
            this.newImageDescription.Text = "Description-";
            // 
            // addNewItemNameTextBox
            // 
            this.addNewItemNameTextBox.Location = new System.Drawing.Point(54, 17);
            this.addNewItemNameTextBox.Name = "addNewItemNameTextBox";
            this.addNewItemNameTextBox.Size = new System.Drawing.Size(196, 24);
            this.addNewItemNameTextBox.TabIndex = 5;
            // 
            // addNewItemPriceTextBox
            // 
            this.addNewItemPriceTextBox.Location = new System.Drawing.Point(54, 43);
            this.addNewItemPriceTextBox.Name = "addNewItemPriceTextBox";
            this.addNewItemPriceTextBox.Size = new System.Drawing.Size(75, 24);
            this.addNewItemPriceTextBox.TabIndex = 6;
            // 
            // addNewItemSpecsTextBox
            // 
            this.addNewItemSpecsTextBox.Location = new System.Drawing.Point(100, 72);
            this.addNewItemSpecsTextBox.Name = "addNewItemSpecsTextBox";
            this.addNewItemSpecsTextBox.Size = new System.Drawing.Size(150, 24);
            this.addNewItemSpecsTextBox.TabIndex = 7;
            // 
            // addNewItemImageURLTextBox
            // 
            this.addNewItemImageURLTextBox.Location = new System.Drawing.Point(82, 99);
            this.addNewItemImageURLTextBox.Name = "addNewItemImageURLTextBox";
            this.addNewItemImageURLTextBox.Size = new System.Drawing.Size(168, 24);
            this.addNewItemImageURLTextBox.TabIndex = 8;
            // 
            // addNewItemDescriptionTextBox
            // 
            this.addNewItemDescriptionTextBox.Location = new System.Drawing.Point(82, 125);
            this.addNewItemDescriptionTextBox.Multiline = true;
            this.addNewItemDescriptionTextBox.Name = "addNewItemDescriptionTextBox";
            this.addNewItemDescriptionTextBox.Size = new System.Drawing.Size(168, 35);
            this.addNewItemDescriptionTextBox.TabIndex = 9;
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewItemButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(285, 222);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(75, 72);
            this.addNewItemButton.TabIndex = 5;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = false;
            // 
            // getAllInventoryButton
            // 
            this.getAllInventoryButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllInventoryButton.Location = new System.Drawing.Point(285, 12);
            this.getAllInventoryButton.Name = "getAllInventoryButton";
            this.getAllInventoryButton.Size = new System.Drawing.Size(75, 43);
            this.getAllInventoryButton.TabIndex = 6;
            this.getAllInventoryButton.Text = "Get All Inventory";
            this.getAllInventoryButton.UseVisualStyleBackColor = true;
            // 
            // inventoryDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 317);
            this.Controls.Add(this.getAllInventoryButton);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.searchItemNameLabel);
            this.Controls.Add(this.addNewItemGroupBox);
            this.Controls.Add(this.deleteInventoryItemButton);
            this.Controls.Add(this.editInventoryItemButton);
            this.Controls.Add(this.searchInventoryComboBox);
            this.Name = "inventoryDashBoard";
            this.Text = "Inventory";
            this.addNewItemGroupBox.ResumeLayout(false);
            this.addNewItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchInventoryComboBox;
        private System.Windows.Forms.Button editInventoryItemButton;
        private System.Windows.Forms.Button deleteInventoryItemButton;
        private System.Windows.Forms.GroupBox addNewItemGroupBox;
        private System.Windows.Forms.TextBox addNewItemDescriptionTextBox;
        private System.Windows.Forms.TextBox addNewItemImageURLTextBox;
        private System.Windows.Forms.TextBox addNewItemSpecsTextBox;
        private System.Windows.Forms.TextBox addNewItemPriceTextBox;
        private System.Windows.Forms.TextBox addNewItemNameTextBox;
        private System.Windows.Forms.Label newImageDescription;
        private System.Windows.Forms.Label newItemImage;
        private System.Windows.Forms.Label newItemSpecification;
        private System.Windows.Forms.Label newItemPrice;
        private System.Windows.Forms.Label newItemName;
        private System.Windows.Forms.Label searchItemNameLabel;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button getAllInventoryButton;
    }
}

