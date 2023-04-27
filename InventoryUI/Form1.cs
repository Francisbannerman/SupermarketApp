using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnections;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace InventoryUI
{
    public partial class inventoryDashBoard : Form
    {
        string connectionString = "Data Source=MACBOOKPROD6B7;Initial Catalog=Supermarket;Integrated Security=True";
        List<InventoryItem> inventoryItemsList = new List<InventoryItem>();


        public inventoryDashBoard()
        {
            InitializeComponent();
            LoadDataToSearchInventoryComboBox();
        }

        private void inventoryDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.supermarketDataSet.Inventory);
        }

        private void LoadDataToSearchInventoryComboBox()
        {
            string query = "SELECT Name FROM dbo.Inventory ORDER By Name ASC";
            //string query = "SELECT Name FROM dbo.Inventory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Inventory");

                searchInventoryComboBox.DataSource = dataSet.Tables["Inventory"];
                searchInventoryComboBox.DisplayMember = "Name";
            }
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess("Data Source=MACBOOKPROD6B7;Initial Catalog=Supermarket;Integrated Security=True");

            if (!string.IsNullOrEmpty(addNewItemNameTextBox.Text) && addNewItemPriceTextBox.Text != null && double.TryParse(addNewItemPriceTextBox.Text, out _))
            {
                InventoryItem newInventoryItem = new InventoryItem();
                newInventoryItem.Name = addNewItemNameTextBox.Text;
                newInventoryItem.Price = double.Parse(addNewItemPriceTextBox.Text);
                newInventoryItem.Specification = addNewItemSpecsTextBox.Text;
                newInventoryItem.ImageURL = addNewItemImageURLTextBox.Text;
                newInventoryItem.Description = addNewItemDescriptionTextBox.Text;

                inventoryItemsList.Add(newInventoryItem);

                dataAccess.AddText(newInventoryItem.Name, newInventoryItem.Price, 
                    newInventoryItem.Specification, newInventoryItem.ImageURL, newInventoryItem.Description);

                addNewItemNameTextBox.Clear();
                addNewItemPriceTextBox.Clear();
                addNewItemSpecsTextBox.Clear();
                addNewItemImageURLTextBox.Clear();
                addNewItemDescriptionTextBox.Clear();
            }
            else
            {
                MessageBox.Show(" There was an error in either the Item Name or the Item Price. Please kindly recheck that field");
            }
            searchInventoryComboBox.DataSource = null;
            LoadDataToSearchInventoryComboBox();
        }

        private void searchInventoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchInventoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchInventoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;            
        }

        private void deleteInventoryItemButton_Click(object sender, EventArgs e)
        {
            string itemToDelete = searchInventoryComboBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM dbo.Inventory WHERE Name = @ItemToDelete";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ItemToDelete", itemToDelete);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }
            searchInventoryComboBox.DataSource = null;
            LoadDataToSearchInventoryComboBox();
            searchInventoryComboBox.Text = "";
            MessageBox.Show($"{itemToDelete} has been deleted from the inventory.");
        }

        private void deleteItemToEdit()
        {
            string itemToDelete = searchInventoryComboBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM dbo.Inventory WHERE Name = @ItemToDelete";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ItemToDelete", itemToDelete);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }
            searchInventoryComboBox.DataSource = null;
            LoadDataToSearchInventoryComboBox();
            searchInventoryComboBox.Text = "";
        }

        private void openInventoryItemButton_Click(object sender, EventArgs e)
        {
            string searchItem = searchInventoryComboBox.Text;

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

        private void editInventoryItemButton_Click(object sender, EventArgs e)
        {
            string editItem = searchInventoryComboBox.Text;

            string query = "SELECT Name, Price, Specification, ImageURL, Description FROM dbo.Inventory where Name = @editItem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@editItem", editItem);

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

                            addNewItemNameTextBox.Text = name;
                            addNewItemPriceTextBox.Text = Convert.ToString(price);
                            addNewItemSpecsTextBox.Text = specification;
                            addNewItemImageURLTextBox.Text = imageUrl;
                            addNewItemDescriptionTextBox.Text = description;
                        }
                        else
                        {
                            MessageBox.Show("This item could not be found in the inventory");
                        }
                    }
                    connection.Close();
                }
            }
            deleteItemToEdit();
        }

        private void getAllInventoryButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Inventory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Inventory");

                worksheet.Cells[1, 1].Value = "id";
                worksheet.Cells[1, 2].Value = "name";
                worksheet.Cells[1, 3].Value = "price";
                worksheet.Cells[1, 4].Value = "specifications";
                worksheet.Cells[1, 5].Value = "imageURL";
                worksheet.Cells[1, 6].Value = "description";

                int row = 2; int col = 1;

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        worksheet.Cells[row, col].Value = reader[i].ToString();
                        col++;
                    }
                    row++;
                    col=1;
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
