namespace ShopDashboardUI
{
    partial class shopsMainDashboard
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
            this.inventoryListComboBox = new System.Windows.Forms.ComboBox();
            this.searchItemNameLabel = new System.Windows.Forms.Label();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.inventoryFormButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteItemFromCartButton = new System.Windows.Forms.Button();
            this.clearItemFromCartButton = new System.Windows.Forms.Button();
            this.printReceiptForItemsInCartButton = new System.Windows.Forms.Button();
            this.daysSalesReportButton = new System.Windows.Forms.Button();
            this.currentDateAndTime = new System.Windows.Forms.Label();
            this.paidItemsInCartButton = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryListComboBox
            // 
            this.inventoryListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListComboBox.FormattingEnabled = true;
            this.inventoryListComboBox.Location = new System.Drawing.Point(24, 98);
            this.inventoryListComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.inventoryListComboBox.Name = "inventoryListComboBox";
            this.inventoryListComboBox.Size = new System.Drawing.Size(442, 38);
            this.inventoryListComboBox.TabIndex = 0;
            // 
            // searchItemNameLabel
            // 
            this.searchItemNameLabel.AutoSize = true;
            this.searchItemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemNameLabel.Location = new System.Drawing.Point(16, 56);
            this.searchItemNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchItemNameLabel.Name = "searchItemNameLabel";
            this.searchItemNameLabel.Size = new System.Drawing.Size(256, 36);
            this.searchItemNameLabel.TabIndex = 1;
            this.searchItemNameLabel.Text = "Search Item Name";
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityLabel.Location = new System.Drawing.Point(24, 235);
            this.itemQuantityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(106, 31);
            this.itemQuantityLabel.TabIndex = 2;
            this.itemQuantityLabel.Text = "Quantity";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityTextBox.Location = new System.Drawing.Point(138, 229);
            this.itemQuantityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(98, 37);
            this.itemQuantityTextBox.TabIndex = 3;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(252, 152);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(218, 119);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "ADD";
            this.addItemButton.UseVisualStyleBackColor = false;
            // 
            // inventoryFormButton
            // 
            this.inventoryFormButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryFormButton.Location = new System.Drawing.Point(24, 563);
            this.inventoryFormButton.Margin = new System.Windows.Forms.Padding(6);
            this.inventoryFormButton.Name = "inventoryFormButton";
            this.inventoryFormButton.Size = new System.Drawing.Size(216, 83);
            this.inventoryFormButton.TabIndex = 5;
            this.inventoryFormButton.Text = "INVENTORY";
            this.inventoryFormButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemPrice,
            this.itemQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(482, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(586, 625);
            this.dataGridView1.TabIndex = 6;
            // 
            // deleteItemFromCartButton
            // 
            this.deleteItemFromCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteItemFromCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemFromCartButton.Location = new System.Drawing.Point(1080, 67);
            this.deleteItemFromCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteItemFromCartButton.Name = "deleteItemFromCartButton";
            this.deleteItemFromCartButton.Size = new System.Drawing.Size(102, 71);
            this.deleteItemFromCartButton.TabIndex = 7;
            this.deleteItemFromCartButton.Text = "Delete";
            this.deleteItemFromCartButton.UseVisualStyleBackColor = false;
            // 
            // clearItemFromCartButton
            // 
            this.clearItemFromCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearItemFromCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearItemFromCartButton.Location = new System.Drawing.Point(1080, 152);
            this.clearItemFromCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearItemFromCartButton.Name = "clearItemFromCartButton";
            this.clearItemFromCartButton.Size = new System.Drawing.Size(102, 71);
            this.clearItemFromCartButton.TabIndex = 8;
            this.clearItemFromCartButton.Text = "Clear";
            this.clearItemFromCartButton.UseVisualStyleBackColor = false;
            // 
            // printReceiptForItemsInCartButton
            // 
            this.printReceiptForItemsInCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptForItemsInCartButton.Location = new System.Drawing.Point(1080, 481);
            this.printReceiptForItemsInCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.printReceiptForItemsInCartButton.Name = "printReceiptForItemsInCartButton";
            this.printReceiptForItemsInCartButton.Size = new System.Drawing.Size(102, 44);
            this.printReceiptForItemsInCartButton.TabIndex = 9;
            this.printReceiptForItemsInCartButton.Text = "Print";
            this.printReceiptForItemsInCartButton.UseVisualStyleBackColor = true;
            // 
            // daysSalesReportButton
            // 
            this.daysSalesReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.daysSalesReportButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysSalesReportButton.Location = new System.Drawing.Point(1080, 529);
            this.daysSalesReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.daysSalesReportButton.Name = "daysSalesReportButton";
            this.daysSalesReportButton.Size = new System.Drawing.Size(102, 117);
            this.daysSalesReportButton.TabIndex = 10;
            this.daysSalesReportButton.Text = "Days Sales Report";
            this.daysSalesReportButton.UseVisualStyleBackColor = false;
            // 
            // currentDateAndTime
            // 
            this.currentDateAndTime.AutoSize = true;
            this.currentDateAndTime.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateAndTime.Location = new System.Drawing.Point(-2, -2);
            this.currentDateAndTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentDateAndTime.Name = "currentDateAndTime";
            this.currentDateAndTime.Size = new System.Drawing.Size(175, 27);
            this.currentDateAndTime.TabIndex = 11;
            this.currentDateAndTime.Text = "dateAndTimeNow";
            // 
            // paidItemsInCartButton
            // 
            this.paidItemsInCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paidItemsInCartButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidItemsInCartButton.Location = new System.Drawing.Point(1080, 229);
            this.paidItemsInCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.paidItemsInCartButton.Name = "paidItemsInCartButton";
            this.paidItemsInCartButton.Size = new System.Drawing.Size(102, 240);
            this.paidItemsInCartButton.TabIndex = 12;
            this.paidItemsInCartButton.Text = "PAID";
            this.paidItemsInCartButton.UseVisualStyleBackColor = false;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MaxInputLength = 40000;
            this.itemName.MinimumWidth = 10;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 300;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.MinimumWidth = 10;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.MinimumWidth = 10;
            this.itemQuantity.Name = "itemQuantity";
            // 
            // openItemButton
            // 
            this.openItemButton.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openItemButton.Location = new System.Drawing.Point(22, 147);
            this.openItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.openItemButton.Name = "openItemButton";
            this.openItemButton.Size = new System.Drawing.Size(118, 70);
            this.openItemButton.TabIndex = 13;
            this.openItemButton.Text = "Open Item";
            this.openItemButton.UseVisualStyleBackColor = true;
            // 
            // shopsMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 681);
            this.Controls.Add(this.openItemButton);
            this.Controls.Add(this.paidItemsInCartButton);
            this.Controls.Add(this.currentDateAndTime);
            this.Controls.Add(this.daysSalesReportButton);
            this.Controls.Add(this.printReceiptForItemsInCartButton);
            this.Controls.Add(this.clearItemFromCartButton);
            this.Controls.Add(this.deleteItemFromCartButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inventoryFormButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemQuantityTextBox);
            this.Controls.Add(this.itemQuantityLabel);
            this.Controls.Add(this.searchItemNameLabel);
            this.Controls.Add(this.inventoryListComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "shopsMainDashboard";
            this.Text = "SuperMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inventoryListComboBox;
        private System.Windows.Forms.Label searchItemNameLabel;
        private System.Windows.Forms.Label itemQuantityLabel;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button inventoryFormButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteItemFromCartButton;
        private System.Windows.Forms.Button clearItemFromCartButton;
        private System.Windows.Forms.Button printReceiptForItemsInCartButton;
        private System.Windows.Forms.Button daysSalesReportButton;
        private System.Windows.Forms.Label currentDateAndTime;
        private System.Windows.Forms.Button paidItemsInCartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.Button openItemButton;
    }
}

