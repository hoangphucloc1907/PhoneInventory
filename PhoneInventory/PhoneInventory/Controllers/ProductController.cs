using PhoneInventory.Models;
using PhoneWarehouse.Models;
using PhoneWarehouse.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWarehouse.Controllers
{
    internal class ProductController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public ProductController()
        {
            _connectDB = new ConnectDB();
        }

        public bool Create(IModel model)
        {
            if (model is not Product product) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO PRODUCT (CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description)
                                                     VALUES (@CategoryId, @ProductCode, @ProductName, @StandardCost, @ListPrice, @Description)", connection);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@StandardCost", product.StandardCost);
            command.Parameters.AddWithValue("@ListPrice", product.ListPrice);
            command.Parameters.AddWithValue("@Description", product.Description);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not Product product) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE PRODUCT 
                                                     SET CategoryId = @CategoryId, ProductCode = @ProductCode, ProductName = @ProductName, StandardCost = @StandardCost, ListPrice = @ListPrice, Description = @Description
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@StandardCost", product.StandardCost);
            command.Parameters.AddWithValue("@ListPrice", product.ListPrice);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@Id", product.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM PRODUCT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM PRODUCT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null && (int)result > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Product product) return false;
            return IsExist(product.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = new SqlCommand(@"SELECT * FROM PRODUCT", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    CategoryId = reader.GetInt32(1),
                    ProductCode = reader.GetString(2),
                    ProductName = reader.GetString(3),
                    StandardCost = reader.GetDecimal(4),
                    ListPrice = reader.GetDecimal(5),
                    Description = reader.GetString(6)
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var product = Read(id);
            if (product != null)
            {
                Items.Clear();
                Items.Add(product);
                return true;
            }
            return false;
        }

        public IModel? Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description
                                                     FROM PRODUCT 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new Product
            {
                Id = reader.GetInt32(0),
                CategoryId = reader.GetInt32(1),
                ProductCode = reader.GetString(2),
                ProductName = reader.GetString(3),
                StandardCost = reader.GetDecimal(4),
                ListPrice = reader.GetDecimal(5),
                Description = reader.GetString(6)
            } : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Product product) return false;
            return IsExist(product.Id) ? Update(product) : Create(product);
        }

        public List<IModel> SearchByCodeOrName(string keyword)
        {
            var searchResults = new List<IModel>();
            if (string.IsNullOrEmpty(keyword)) return searchResults;

            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description
                                                     FROM PRODUCT 
                                                     WHERE ProductName LIKE @Keyword OR ProductCode LIKE @Keyword", connection);
            command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    CategoryId = reader.GetInt32(1),
                    ProductCode = reader.GetString(2),
                    ProductName = reader.GetString(3),
                    StandardCost = reader.GetDecimal(4),
                    ListPrice = reader.GetDecimal(5),
                    Description = reader.GetString(6)
                });
            }
            return searchResults;
        }

        public bool ValidateAmount(string input, out decimal amount, out string errorMessage)
        {
            errorMessage = "";
            var cleanedInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.' || c == ',' || c == '-')
                {
                    cleanedInput.Append(c);
                }
            }
            string finalInput = cleanedInput.ToString().Replace(" VNĐ", "").Replace(",", ".");
            if (!decimal.TryParse(finalInput, NumberStyles.Number, CultureInfo.InvariantCulture, out amount))
            {
                errorMessage = "Số tiền phải là một số hợp lệ!";
                return false;
            }
            if (amount <= 0)
            {
                errorMessage = "Số tiền phải lớn hơn không!";
                return false;
            }
            return true;
        }

        public int GetProductIdByName(string productName)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id FROM PRODUCT WHERE ProductName = @ProductName", connection);
            command.Parameters.AddWithValue("@ProductName", productName);
            var result = command.ExecuteScalar();
            return result != null ? (int)result : 0;
        }

        public string GetProductNameById(int id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT ProductName FROM PRODUCT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null ? (string)result : string.Empty;
        }

        public List<Product> GetProductPrice()
        {
            var products = new List<Product>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, ListPrice FROM PRODUCT", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    ProductName = reader.GetString(1),
                    ListPrice = reader.GetDecimal(2),
                });
            }
            return products;
        }

        public List<CurrentStock> GetProductCode()
        {
            var currentStocks = new List<CurrentStock>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT ct.ProductId, ct.ProductCode, ct.ProductName, ct.StockBalance, p.ListPrice 
                                                    FROM CurrentStock ct
                                                    JOIN Product p ON p.Id = ct.ProductId", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                currentStocks.Add(new CurrentStock
                {
                    ProductId = reader.GetInt32(0),
                    ProductCode = reader.GetString(1),
                    ProductName = reader.GetString(2),
                    StockBalance = reader.GetInt32(3),
                    Product = new Product
                    {
                        ListPrice = reader.GetDecimal(4)
                    }
                });
            }
            return currentStocks;
        }


        public bool LoadCurrentStock()
        {
            Items.Clear(); // Assuming Items is a list to store the stock data
            using var connection = _connectDB.GetConnection();
            using var command = new SqlCommand(@"SELECT ProductId, ProductCode, ProductName, TotalImported, TotalExported, StockBalance FROM CurrentStock", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new CurrentStock
                {
                    ProductId = reader.GetInt32(0),
                    ProductCode = reader.GetString(1),
                    ProductName = reader.GetString(2),
                    TotalImported = reader.GetInt32(3),
                    TotalExported = reader.GetInt32(4),
                    StockBalance = reader.GetInt32(5)
                });
            }
            return Items.Count > 0;
        }
    }
}
