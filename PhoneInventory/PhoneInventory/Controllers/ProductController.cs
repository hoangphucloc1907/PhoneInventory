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

        private SqlCommand CreateCommand(SqlConnection connection, string query, Product product = null, object id = null, string keyword = null)
        {
            var command = new SqlCommand(query, connection);
            if (product != null)
            {
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@StandardCost", product.StandardCost);
                command.Parameters.AddWithValue("@ListPrice", product.ListPrice);
                command.Parameters.AddWithValue("@Description", product.Description);
            }
            if (id != null)
            {
                command.Parameters.AddWithValue("@Id", id);
            }
            if (keyword != null)
            {
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
            }
            return command;
        }

        public bool Create(IModel model)
        {
            if (model is not Product product) return false;
            return ExecuteNonQuery(@"INSERT INTO PRODUCT (CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description)
                                         VALUES (@CategoryId, @ProductCode, @ProductName, @StandardCost, @ListPrice, @Description)", product);
        }

        public bool Update(IModel model)
        {
            if (model is not Product product) return false;
            return ExecuteNonQuery(@"UPDATE PRODUCT 
                                         SET CategoryId = @CategoryId, ProductCode = @ProductCode, ProductName = @ProductName, StandardCost = @StandardCost, ListPrice = @ListPrice, Description = @Description
                                         WHERE Id = @Id", product);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM PRODUCT WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM PRODUCT WHERE Id = @Id", id: id) > 0;
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
            using var command = CreateCommand(connection, @"SELECT * FROM PRODUCT");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToProduct(reader));
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

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description
                                                                FROM PRODUCT 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToProduct(reader) : null;
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
            using var command = CreateCommand(connection, @"SELECT Id, CategoryId, ProductCode, ProductName, StandardCost, ListPrice, Description
                                                                FROM PRODUCT 
                                                                WHERE ProductName LIKE @Keyword OR ProductCode LIKE @Keyword", keyword: keyword);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(MapReaderToProduct(reader));
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
            return ExecuteScalar<int>("SELECT Id FROM PRODUCT WHERE ProductName = @ProductName", keyword: productName);
        }

        public string GetProductNameById(int id)
        {
            return ExecuteScalar<string>("SELECT ProductName FROM PRODUCT WHERE Id = @Id", id: id);
        }

        public List<Product> GetProductNames()
        {
            var products = new List<Product>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, ProductName, ListPrice FROM PRODUCT");
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

        private bool ExecuteNonQuery(string query, Product product = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, product, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, Product product = null, object id = null, string keyword = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, product, id, keyword);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private Product MapReaderToProduct(SqlDataReader reader)
        {
            return new Product
            {
                Id = reader.GetInt32(0),
                CategoryId = reader.GetInt32(1),
                ProductCode = reader.GetString(2),
                ProductName = reader.GetString(3),
                StandardCost = reader.GetDecimal(4),
                ListPrice = reader.GetDecimal(5),
                Description = reader.GetString(6)
            };
        }
    }
}
