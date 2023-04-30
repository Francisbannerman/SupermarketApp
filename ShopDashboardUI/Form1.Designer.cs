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
            this.components = new System.ComponentModel.Container();
            this.inventoryListComboBox = new System.Windows.Forms.ComboBox();
            this.searchItemNameLabel = new System.Windows.Forms.Label();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.inventoryFormButton = new System.Windows.Forms.Button();
            this.shopGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceByQuantityPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteItemFromCartButton = new System.Windows.Forms.Button();
            this.clearItemFromCartButton = new System.Windows.Forms.Button();
            this.printReceiptForItemsInCartButton = new System.Windows.Forms.Button();
            this.daysSalesReportButton = new System.Windows.Forms.Button();
            this.currentDateAndTime = new System.Windows.Forms.Label();
            this.paidItemsInCartButton = new System.Windows.Forms.Button();
            this.openItemButton = new System.Windows.Forms.Button();
            this.dateAndTime = new System.Windows.Forms.Timer(this.components);
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.totalAmountToPayTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryListComboBox
            // 
            this.inventoryListComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListComboBox.FormattingEnabled = true;
            this.inventoryListComboBox.Location = new System.Drawing.Point(24, 122);
            this.inventoryListComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.inventoryListComboBox.Name = "inventoryListComboBox";
            this.inventoryListComboBox.Size = new System.Drawing.Size(555, 53);
            this.inventoryListComboBox.TabIndex = 0;
            this.inventoryListComboBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListComboBox_SelectedIndexChanged);
            // 
            // searchItemNameLabel
            // 
            this.searchItemNameLabel.AutoSize = true;
            this.searchItemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemNameLabel.Location = new System.Drawing.Point(16, 80);
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
            this.itemQuantityLabel.Location = new System.Drawing.Point(20, 275);
            this.itemQuantityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(106, 31);
            this.itemQuantityLabel.TabIndex = 2;
            this.itemQuantityLabel.Text = "Quantity";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityTextBox.Location = new System.Drawing.Point(128, 269);
            this.itemQuantityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(98, 37);
            this.itemQuantityTextBox.TabIndex = 3;
            this.itemQuantityTextBox.Text = "1";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(361, 187);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(218, 119);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "ADD";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // inventoryFormButton
            // 
            this.inventoryFormButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryFormButton.Location = new System.Drawing.Point(15, 1031);
            this.inventoryFormButton.Margin = new System.Windows.Forms.Padding(6);
            this.inventoryFormButton.Name = "inventoryFormButton";
            this.inventoryFormButton.Size = new System.Drawing.Size(216, 83);
            this.inventoryFormButton.TabIndex = 5;
            this.inventoryFormButton.Text = "INVENTORY";
            this.inventoryFormButton.UseVisualStyleBackColor = true;
            this.inventoryFormButton.Click += new System.EventHandler(this.inventoryFormButton_Click);
            // 
            // shopGridView
            // 
            this.shopGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.itemName,
            this.itemPrice,
            this.itemQuantity,
            this.priceByQuantityPrice});
            this.shopGridView.Location = new System.Drawing.Point(591, 15);
            this.shopGridView.Margin = new System.Windows.Forms.Padding(6);
            this.shopGridView.Name = "shopGridView";
            this.shopGridView.RowHeadersWidth = 82;
            this.shopGridView.Size = new System.Drawing.Size(936, 1099);
            this.shopGridView.TabIndex = 6;
            this.shopGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shopGridView_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date & Time";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 120;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MaxInputLength = 40000;
            this.itemName.MinimumWidth = 10;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemName.Width = 255;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.MinimumWidth = 10;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            this.itemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemPrice.Width = 50;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Qnty";
            this.itemQuantity.MinimumWidth = 10;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            this.itemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemQuantity.Width = 40;
            // 
            // priceByQuantityPrice
            // 
            this.priceByQuantityPrice.HeaderText = "Items By Quantity";
            this.priceByQuantityPrice.MinimumWidth = 10;
            this.priceByQuantityPrice.Name = "priceByQuantityPrice";
            this.priceByQuantityPrice.ReadOnly = true;
            this.priceByQuantityPrice.Visible = false;
            this.priceByQuantityPrice.Width = 200;
            // 
            // deleteItemFromCartButton
            // 
            this.deleteItemFromCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteItemFromCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemFromCartButton.Location = new System.Drawing.Point(1539, 67);
            this.deleteItemFromCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteItemFromCartButton.Name = "deleteItemFromCartButton";
            this.deleteItemFromCartButton.Size = new System.Drawing.Size(122, 122);
            this.deleteItemFromCartButton.TabIndex = 7;
            this.deleteItemFromCartButton.Text = "Delete";
            this.deleteItemFromCartButton.UseVisualStyleBackColor = false;
            this.deleteItemFromCartButton.Click += new System.EventHandler(this.deleteItemFromCartButton_Click);
            // 
            // clearItemFromCartButton
            // 
            this.clearItemFromCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearItemFromCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearItemFromCartButton.Location = new System.Drawing.Point(1539, 215);
            this.clearItemFromCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearItemFromCartButton.Name = "clearItemFromCartButton";
            this.clearItemFromCartButton.Size = new System.Drawing.Size(122, 128);
            this.clearItemFromCartButton.TabIndex = 8;
            this.clearItemFromCartButton.Text = "Clear";
            this.clearItemFromCartButton.UseVisualStyleBackColor = false;
            this.clearItemFromCartButton.Click += new System.EventHandler(this.clearItemFromCartButton_Click);
            // 
            // printReceiptForItemsInCartButton
            // 
            this.printReceiptForItemsInCartButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptForItemsInCartButton.Location = new System.Drawing.Point(1539, 815);
            this.printReceiptForItemsInCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.printReceiptForItemsInCartButton.Name = "printReceiptForItemsInCartButton";
            this.printReceiptForItemsInCartButton.Size = new System.Drawing.Size(122, 115);
            this.printReceiptForItemsInCartButton.TabIndex = 9;
            this.printReceiptForItemsInCartButton.Text = "Print";
            this.printReceiptForItemsInCartButton.UseVisualStyleBackColor = true;
            // 
            // daysSalesReportButton
            // 
            this.daysSalesReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.daysSalesReportButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysSalesReportButton.Location = new System.Drawing.Point(1539, 961);
            this.daysSalesReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.daysSalesReportButton.Name = "daysSalesReportButton";
            this.daysSalesReportButton.Size = new System.Drawing.Size(122, 137);
            this.daysSalesReportButton.TabIndex = 10;
            this.daysSalesReportButton.Text = "Days Sales Report";
            this.daysSalesReportButton.UseVisualStyleBackColor = false;
            this.daysSalesReportButton.Click += new System.EventHandler(this.daysSalesReportButton_Click);
            // 
            // currentDateAndTime
            // 
            this.currentDateAndTime.AutoSize = true;
            this.currentDateAndTime.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateAndTime.Location = new System.Drawing.Point(-2, -2);
            this.currentDateAndTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentDateAndTime.Name = "currentDateAndTime";
            this.currentDateAndTime.Size = new System.Drawing.Size(0, 27);
            this.currentDateAndTime.TabIndex = 11;
            // 
            // paidItemsInCartButton
            // 
            this.paidItemsInCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paidItemsInCartButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidItemsInCartButton.Location = new System.Drawing.Point(1539, 367);
            this.paidItemsInCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.paidItemsInCartButton.Name = "paidItemsInCartButton";
            this.paidItemsInCartButton.Size = new System.Drawing.Size(122, 415);
            this.paidItemsInCartButton.TabIndex = 12;
            this.paidItemsInCartButton.Text = "PAID";
            this.paidItemsInCartButton.UseVisualStyleBackColor = false;
            this.paidItemsInCartButton.Click += new System.EventHandler(this.paidItemsInCartButton_Click);
            // 
            // openItemButton
            // 
            this.openItemButton.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openItemButton.Location = new System.Drawing.Point(24, 187);
            this.openItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.openItemButton.Name = "openItemButton";
            this.openItemButton.Size = new System.Drawing.Size(118, 70);
            this.openItemButton.TabIndex = 13;
            this.openItemButton.Text = "Open Item";
            this.openItemButton.UseVisualStyleBackColor = true;
            this.openItemButton.Click += new System.EventHandler(this.openItemButton_Click);
            // 
            // dateAndTime
            // 
            this.dateAndTime.Enabled = true;
            this.dateAndTime.Interval = 1000;
            this.dateAndTime.Tick += new System.EventHandler(this.dateAndTime_Tick);
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(13, 13);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(139, 25);
            this.dateAndTimeLabel.TabIndex = 14;
            this.dateAndTimeLabel.Text = "dateAndTime";
            // 
            // totalAmountToPayTextBoxDisplay
            // 
            this.totalAmountToPayTextBoxDisplay.Font = new System.Drawing.Font("Comic Sans MS", 40.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountToPayTextBoxDisplay.Location = new System.Drawing.Point(24, 851);
            this.totalAmountToPayTextBoxDisplay.Name = "totalAmountToPayTextBoxDisplay";
            this.totalAmountToPayTextBoxDisplay.Size = new System.Drawing.Size(555, 157);
            this.totalAmountToPayTextBoxDisplay.TabIndex = 15;
            this.totalAmountToPayTextBoxDisplay.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(25, 774);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(216, 74);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "TOTAL";
            // 
            // shopsMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 1129);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalAmountToPayTextBoxDisplay);
            this.Controls.Add(this.dateAndTimeLabel);
            this.Controls.Add(this.openItemButton);
            this.Controls.Add(this.paidItemsInCartButton);
            this.Controls.Add(this.currentDateAndTime);
            this.Controls.Add(this.daysSalesReportButton);
            this.Controls.Add(this.printReceiptForItemsInCartButton);
            this.Controls.Add(this.clearItemFromCartButton);
            this.Controls.Add(this.deleteItemFromCartButton);
            this.Controls.Add(this.shopGridView);
            this.Controls.Add(this.inventoryFormButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemQuantityTextBox);
            this.Controls.Add(this.itemQuantityLabel);
            this.Controls.Add(this.searchItemNameLabel);
            this.Controls.Add(this.inventoryListComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "shopsMainDashboard";
            this.Text = "SuperMarket";
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView shopGridView;
        private System.Windows.Forms.Button deleteItemFromCartButton;
        private System.Windows.Forms.Button clearItemFromCartButton;
        private System.Windows.Forms.Button printReceiptForItemsInCartButton;
        private System.Windows.Forms.Button daysSalesReportButton;
        private System.Windows.Forms.Label currentDateAndTime;
        private System.Windows.Forms.Button paidItemsInCartButton;
        private System.Windows.Forms.Button openItemButton;
        public System.Windows.Forms.Timer dateAndTime;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.TextBox totalAmountToPayTextBoxDisplay;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceByQuantityPrice;
    }
}

