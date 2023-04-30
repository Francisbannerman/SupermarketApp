using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnections;
using DocumentFormat.OpenXml.Drawing;
using InventoryUI;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace ShopDashboardUI
{
    public partial class shopsMainDashboard : Form
    {
        string connectionString = "Data Source=MACBOOKPROD6B7;Initial Catalog=Supermarket;Integrated Security=True";
        public shopsMainDashboard()
        {
            InitializeComponent();
            dateAndTime.Start();
            shopGridView.RowHeadersVisible = false;
            LoadDataToShopAddItemComboBox();
        }

        private void inventoryFormButton_Click(object sender, EventArgs e)
        {
            inventoryDashBoard inventoryDashboard = new inventoryDashBoard();
            inventoryDashboard.Show();

        }

        private void clearItemFromCartButton_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in shopGridView.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        cell.Value = null;
            //    }
            //}
            //shopGridView.Rows.Clear();
            //amountToPay();
            clearItemsFromGrid();
        }

        private void clearItemsFromGrid()
        {
            foreach (DataGridViewRow row in shopGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            shopGridView.Rows.Clear();
            amountToPay();
        }

        private void inventoryListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventoryListComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            inventoryListComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToShopAddItemComboBox()
        {
            string query = "SELECT Name FROM dbo.Inventory ORDER By Name ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Inventory");

                inventoryListComboBox.DataSource = dataSet.Tables["Inventory"];
                inventoryListComboBox.DisplayMember = "Name";
            }
        }

        private void openItemButton_Click(object sender, EventArgs e)
        {
            string searchItem = inventoryListComboBox.Text;

            string query = "SELECT Name, Price, Specification, ImageURL, Description FROM dbo.Inventory where Name = @searchItem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchItem", searchItem);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            double price = Convert.ToDouble(reader["Price"]);
                            string specification = reader["Specification"].ToString();
                            string imageUrl = reader["ImageURL"].ToString();
                            string description = reader["Description"].ToString();

                            MessageBox.Show($"Name: {name}.   Price: {price}.   Specifications: {specification}.   " +
                                $"Image URL: {imageUrl}.   Description: {description}.");
                        }
                        else
                        {
                            MessageBox.Show("This item could not be found in the inventory");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void dateAndTime_Tick(object sender, EventArgs e)
        {
            dateAndTimeLabel.Text = DateTime.Now.ToString();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string itemToAdd = inventoryListComboBox.Text;

            string query = "SELECT Name, Price FROM dbo.Inventory where Name = @itemToAdd";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@itemToAdd", itemToAdd);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string addDateAndTime = DateTime.Now.ToString();
                            string name = reader["Name"].ToString();
                            double price = Convert.ToDouble(reader["Price"]);
                            int quantity = Convert.ToInt32(itemQuantityTextBox.Text);
                            double itemByQuantityPrice = price * Convert.ToDouble(quantity);

                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(shopGridView);

                            newRow.Cells[0].Value = addDateAndTime;
                            newRow.Cells[1].Value = name;
                            newRow.Cells[2].Value = price;
                            newRow.Cells[3].Value = quantity;
                            newRow.Cells[4].Value = itemByQuantityPrice;

                            shopGridView.Rows.Add(newRow);
                        }
                        else
                        {
                            MessageBox.Show("This item could not be found in the inventory");
                        }
                    }
                    connection.Close();
                }
            }
            amountToPay();
        }

        private void shopGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void deleteItemFromCartButton_Click(object sender, EventArgs e)
        {
            int rowIndex = shopGridView.SelectedCells[0].RowIndex;
            shopGridView.Rows.RemoveAt(rowIndex);
            amountToPay();
        }

        private void amountToPay()
        {
            double sum = 0;

            for (int i = 0; i < shopGridView.Rows.Count; i++)
            {
                sum += Convert.ToDouble(shopGridView.Rows[i].Cells[4].Value);
                totalAmountToPayTextBoxDisplay.Text = ($"{sum.ToString()}gh");
            }
        }

        private void paidItemsInCartButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess("Data Source=MACBOOKPROD6B7;Initial Catalog=Supermarket;Integrated Security=True");

            for (int i = 0; i < shopGridView.Rows.Count; i++)
            {
                if (shopGridView.Rows.Count > 0)
                {
                    string dateAndTime = Convert.ToString(shopGridView.Rows[i].Cells[0].Value);
                    string itemName = Convert.ToString(shopGridView.Rows[i].Cells[1].Value);
                    double price = Convert.ToDouble(shopGridView.Rows[i].Cells[2].Value);
                    int quantity = Convert.ToInt32(shopGridView.Rows[i].Cells[3].Value);
                    double priceByQuantiy = Convert.ToDouble(shopGridView.Rows[i].Cells[4].Value);
                    string amountToPay = Convert.ToString(totalAmountToPayTextBoxDisplay.Text);

                    dataAccess.AddSales(dateAndTime, itemName, price, quantity, priceByQuantiy, amountToPay);
                }
                else
                {
                    MessageBox.Show("There's nothing to be paid for. Kindly add something before you try to pay for them.");
                }
            }
            clearItemsFromGrid();
        }

        private DateTime PickADate()
        {
            using (var pickerForm = new Form())
            {
                var dateTimePicker = new DateTimePicker();
                dateTimePicker.Format = DateTimePickerFormat.Short;
                dateTimePicker.Value = DateTime.Today;
                pickerForm.Controls.Add(dateTimePicker);

                var okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Dock = DockStyle.Bottom;
                pickerForm.Controls.Add(okButton);

                pickerForm.ClientSize = new Size(200, 100);
                pickerForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                pickerForm.StartPosition = FormStartPosition.CenterScreen;
                pickerForm.ShowDialog();

                if (pickerForm.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("No date was picked. Kindly pick a date before you try to download a days sales");                   
                }
                DateTime selectedDate = dateTimePicker.Value;
                return selectedDate;
            }
        }

        private void daysSalesReportButton_Click(object sender, EventArgs e)
        {
            DateTime pickedDate = PickADate();
            string pickedDateString = pickedDate.ToString("MM-dd-yyyy");
            string query = "SELECT * FROM dbo.Sales WHERE DateAndTime LIKE '"+pickedDateString+"%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("SalesFor" + pickedDateString);

                worksheet.Cells[1, 1].Value = "dateAndTime";
                worksheet.Cells[1, 2].Value = "name";
                worksheet.Cells[1, 3].Value = "price";
                worksheet.Cells[1, 4].Value = "quantity";
                worksheet.Cells[1, 5].Value = "priceByQuantityOfItem";
                worksheet.Cells[1, 6].Value = "totalCartedItemsAmount";

                int row = 2; int col = 1;

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            worksheet.Cells[row, col].Value = reader[i].ToString();
                            col++;
                        }
                        row++;
                        col = 1;
                    }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "*.xlsx|";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);
                        excel.SaveAs(fileInfo);
                    }
                }
                connection.Close();
                reader.Close();
                excel.Dispose();
            }
        }
    }
}
