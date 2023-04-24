using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBConnections
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class InventoryItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public string ImageURL { get; set; }
    }
    public class DataAccess //class that handles anything related to access to database
    {
        private string ConnectionString;
        public DataAccess(string connectionString) //constructor that can take a field parameter and instantiate the connection at object isntantiation
        {
            this.ConnectionString = connectionString;
        }

        public void AddText(string itemName, double itemPrice, string itemSpecs, string itemURLImage, string itemDescription) //Method that handles the sql connection
        {
            string sql = "INSERT INTO dbo.Inventory (Name, Price, Specification, ImageURL, Description) VALUES (@itemName, @itemPrice, @itemSpecs, @itemURLImage, @itemDescription)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@itemPrice", itemPrice);
                    command.Parameters.AddWithValue("@itemSpecs", itemSpecs);
                    command.Parameters.AddWithValue("@itemURLImage", itemURLImage);
                    command.Parameters.AddWithValue("@itemDescription", itemDescription);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
