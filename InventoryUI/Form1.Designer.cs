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
            this.components = new System.ComponentModel.Container();
            this.searchInventoryComboBox = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSet = new InventoryUI.SupermarketDataSet();
            this.editInventoryItemButton = new System.Windows.Forms.Button();
            this.deleteInventoryItemButton = new System.Windows.Forms.Button();
            this.addNewItemGroupBox = new System.Windows.Forms.GroupBox();
            this.asterixLabel1 = new System.Windows.Forms.Label();
            this.asterixLabel2 = new System.Windows.Forms.Label();
            this.ghanaCedisLabel = new System.Windows.Forms.Label();
            this.addNewItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemImageURLTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemSpecsTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemNameTextBox = new System.Windows.Forms.TextBox();
            this.newImageDescription = new System.Windows.Forms.Label();
            this.newItemImage = new System.Windows.Forms.Label();
            this.newItemSpecification = new System.Windows.Forms.Label();
            this.newItemPrice = new System.Windows.Forms.Label();
            this.newItemName = new System.Windows.Forms.Label();
            this.searchItemNameLabel = new System.Windows.Forms.Label();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.getAllInventoryButton = new System.Windows.Forms.Button();
            this.openInventoryItemButton = new System.Windows.Forms.Button();
            this.inventoryTableAdapter = new InventoryUI.SupermarketDataSetTableAdapters.InventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            this.addNewItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchInventoryComboBox
            // 
            this.searchInventoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventoryBindingSource, "Name", true));
            this.searchInventoryComboBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryComboBox.FormattingEnabled = true;
            this.searchInventoryComboBox.Location = new System.Drawing.Point(26, 81);
            this.searchInventoryComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchInventoryComboBox.Name = "searchInventoryComboBox";
            this.searchInventoryComboBox.Size = new System.Drawing.Size(532, 40);
            this.searchInventoryComboBox.TabIndex = 0;
            this.searchInventoryComboBox.SelectedIndexChanged += new System.EventHandler(this.searchInventoryComboBox_SelectedIndexChanged);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.supermarketDataSet;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "SupermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editInventoryItemButton
            // 
            this.editInventoryItemButton.BackColor = System.Drawing.Color.White;
            this.editInventoryItemButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInventoryItemButton.Location = new System.Drawing.Point(24, 137);
            this.editInventoryItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.editInventoryItemButton.Name = "editInventoryItemButton";
            this.editInventoryItemButton.Size = new System.Drawing.Size(130, 58);
            this.editInventoryItemButton.TabIndex = 1;
            this.editInventoryItemButton.Text = "Edit Item";
            this.editInventoryItemButton.UseVisualStyleBackColor = false;
            // 
            // deleteInventoryItemButton
            // 
            this.deleteInventoryItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteInventoryItemButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInventoryItemButton.Location = new System.Drawing.Point(404, 133);
            this.deleteInventoryItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteInventoryItemButton.Name = "deleteInventoryItemButton";
            this.deleteInventoryItemButton.Size = new System.Drawing.Size(154, 58);
            this.deleteInventoryItemButton.TabIndex = 2;
            this.deleteInventoryItemButton.Text = "Delete Item";
            this.deleteInventoryItemButton.UseVisualStyleBackColor = false;
            this.deleteInventoryItemButton.Click += new System.EventHandler(this.deleteInventoryItemButton_Click);
            // 
            // addNewItemGroupBox
            // 
            this.addNewItemGroupBox.Controls.Add(this.asterixLabel1);
            this.addNewItemGroupBox.Controls.Add(this.asterixLabel2);
            this.addNewItemGroupBox.Controls.Add(this.ghanaCedisLabel);
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
            this.addNewItemGroupBox.Location = new System.Drawing.Point(26, 246);
            this.addNewItemGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemGroupBox.Name = "addNewItemGroupBox";
            this.addNewItemGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.addNewItemGroupBox.Size = new System.Drawing.Size(532, 319);
            this.addNewItemGroupBox.TabIndex = 3;
            this.addNewItemGroupBox.TabStop = false;
            this.addNewItemGroupBox.Text = "Add New Item";
            // 
            // asterixLabel1
            // 
            this.asterixLabel1.AutoSize = true;
            this.asterixLabel1.Font = new System.Drawing.Font("Comic Sans MS", 4.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterixLabel1.ForeColor = System.Drawing.Color.Red;
            this.asterixLabel1.Location = new System.Drawing.Point(504, 48);
            this.asterixLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.asterixLabel1.Name = "asterixLabel1";
            this.asterixLabel1.Size = new System.Drawing.Size(16, 19);
            this.asterixLabel1.TabIndex = 11;
            this.asterixLabel1.Text = "*";
            // 
            // asterixLabel2
            // 
            this.asterixLabel2.AutoSize = true;
            this.asterixLabel2.Font = new System.Drawing.Font("Comic Sans MS", 4.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterixLabel2.ForeColor = System.Drawing.Color.Red;
            this.asterixLabel2.Location = new System.Drawing.Point(292, 98);
            this.asterixLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.asterixLabel2.Name = "asterixLabel2";
            this.asterixLabel2.Size = new System.Drawing.Size(16, 19);
            this.asterixLabel2.TabIndex = 12;
            this.asterixLabel2.Text = "*";
            // 
            // ghanaCedisLabel
            // 
            this.ghanaCedisLabel.AutoSize = true;
            this.ghanaCedisLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghanaCedisLabel.Location = new System.Drawing.Point(254, 90);
            this.ghanaCedisLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ghanaCedisLabel.Name = "ghanaCedisLabel";
            this.ghanaCedisLabel.Size = new System.Drawing.Size(36, 29);
            this.ghanaCedisLabel.TabIndex = 10;
            this.ghanaCedisLabel.Text = "gh";
            // 
            // addNewItemDescriptionTextBox
            // 
            this.addNewItemDescriptionTextBox.Location = new System.Drawing.Point(164, 240);
            this.addNewItemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemDescriptionTextBox.Multiline = true;
            this.addNewItemDescriptionTextBox.Name = "addNewItemDescriptionTextBox";
            this.addNewItemDescriptionTextBox.Size = new System.Drawing.Size(332, 64);
            this.addNewItemDescriptionTextBox.TabIndex = 9;
            // 
            // addNewItemImageURLTextBox
            // 
            this.addNewItemImageURLTextBox.Location = new System.Drawing.Point(164, 190);
            this.addNewItemImageURLTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemImageURLTextBox.Name = "addNewItemImageURLTextBox";
            this.addNewItemImageURLTextBox.Size = new System.Drawing.Size(332, 41);
            this.addNewItemImageURLTextBox.TabIndex = 8;
            // 
            // addNewItemSpecsTextBox
            // 
            this.addNewItemSpecsTextBox.Location = new System.Drawing.Point(200, 138);
            this.addNewItemSpecsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemSpecsTextBox.Name = "addNewItemSpecsTextBox";
            this.addNewItemSpecsTextBox.Size = new System.Drawing.Size(296, 41);
            this.addNewItemSpecsTextBox.TabIndex = 7;
            // 
            // addNewItemPriceTextBox
            // 
            this.addNewItemPriceTextBox.Location = new System.Drawing.Point(108, 83);
            this.addNewItemPriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemPriceTextBox.Name = "addNewItemPriceTextBox";
            this.addNewItemPriceTextBox.Size = new System.Drawing.Size(146, 41);
            this.addNewItemPriceTextBox.TabIndex = 6;
            // 
            // addNewItemNameTextBox
            // 
            this.addNewItemNameTextBox.Location = new System.Drawing.Point(108, 33);
            this.addNewItemNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemNameTextBox.Name = "addNewItemNameTextBox";
            this.addNewItemNameTextBox.Size = new System.Drawing.Size(388, 41);
            this.addNewItemNameTextBox.TabIndex = 5;
            // 
            // newImageDescription
            // 
            this.newImageDescription.AutoSize = true;
            this.newImageDescription.Location = new System.Drawing.Point(12, 246);
            this.newImageDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newImageDescription.Name = "newImageDescription";
            this.newImageDescription.Size = new System.Drawing.Size(160, 35);
            this.newImageDescription.TabIndex = 4;
            this.newImageDescription.Text = "Description-";
            // 
            // newItemImage
            // 
            this.newItemImage.AutoSize = true;
            this.newItemImage.Location = new System.Drawing.Point(12, 196);
            this.newItemImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newItemImage.Name = "newItemImage";
            this.newItemImage.Size = new System.Drawing.Size(142, 35);
            this.newItemImage.TabIndex = 3;
            this.newItemImage.Text = "Image url-";
            // 
            // newItemSpecification
            // 
            this.newItemSpecification.AutoSize = true;
            this.newItemSpecification.Location = new System.Drawing.Point(14, 144);
            this.newItemSpecification.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newItemSpecification.Name = "newItemSpecification";
            this.newItemSpecification.Size = new System.Drawing.Size(180, 35);
            this.newItemSpecification.TabIndex = 2;
            this.newItemSpecification.Text = "Specification-";
            // 
            // newItemPrice
            // 
            this.newItemPrice.AutoSize = true;
            this.newItemPrice.Location = new System.Drawing.Point(14, 88);
            this.newItemPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(87, 35);
            this.newItemPrice.TabIndex = 1;
            this.newItemPrice.Text = "Price-";
            // 
            // newItemName
            // 
            this.newItemName.AutoSize = true;
            this.newItemName.Location = new System.Drawing.Point(14, 38);
            this.newItemName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(95, 35);
            this.newItemName.TabIndex = 0;
            this.newItemName.Text = "Name-";
            // 
            // searchItemNameLabel
            // 
            this.searchItemNameLabel.AutoSize = true;
            this.searchItemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemNameLabel.Location = new System.Drawing.Point(24, 38);
            this.searchItemNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchItemNameLabel.Name = "searchItemNameLabel";
            this.searchItemNameLabel.Size = new System.Drawing.Size(256, 36);
            this.searchItemNameLabel.TabIndex = 4;
            this.searchItemNameLabel.Text = "Search Item Name";
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewItemButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(543, 427);
            this.addNewItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(177, 138);
            this.addNewItemButton.TabIndex = 5;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = false;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // getAllInventoryButton
            // 
            this.getAllInventoryButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllInventoryButton.Location = new System.Drawing.Point(570, 23);
            this.getAllInventoryButton.Margin = new System.Windows.Forms.Padding(6);
            this.getAllInventoryButton.Name = "getAllInventoryButton";
            this.getAllInventoryButton.Size = new System.Drawing.Size(150, 83);
            this.getAllInventoryButton.TabIndex = 6;
            this.getAllInventoryButton.Text = "Get All Inventory";
            this.getAllInventoryButton.UseVisualStyleBackColor = true;
            // 
            // openInventoryItemButton
            // 
            this.openInventoryItemButton.BackColor = System.Drawing.Color.White;
            this.openInventoryItemButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openInventoryItemButton.Location = new System.Drawing.Point(211, 137);
            this.openInventoryItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.openInventoryItemButton.Name = "openInventoryItemButton";
            this.openInventoryItemButton.Size = new System.Drawing.Size(139, 58);
            this.openInventoryItemButton.TabIndex = 7;
            this.openInventoryItemButton.Text = "Open Item";
            this.openInventoryItemButton.UseVisualStyleBackColor = false;
            this.openInventoryItemButton.Click += new System.EventHandler(this.openInventoryItemButton_Click);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 610);
            this.Controls.Add(this.openInventoryItemButton);
            this.Controls.Add(this.getAllInventoryButton);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.searchItemNameLabel);
            this.Controls.Add(this.addNewItemGroupBox);
            this.Controls.Add(this.deleteInventoryItemButton);
            this.Controls.Add(this.editInventoryItemButton);
            this.Controls.Add(this.searchInventoryComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "inventoryDashBoard";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventoryDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
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
        private System.Windows.Forms.Label asterixLabel1;
        private System.Windows.Forms.Label asterixLabel2;
        private System.Windows.Forms.Label ghanaCedisLabel;
        private System.Windows.Forms.Button openInventoryItemButton;
        private SupermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private SupermarketDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
    }
}

