using PhoneWarehouse.Models;
using PhoneWarehouse.Utils;
using System.Data.SqlClient;

namespace PhoneWarehouse.Controllers
{
    internal class CategoryController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public CategoryController()
        {
            _connectDB = new ConnectDB();
        }

        public bool Create(IModel model)
        {
            if (model is not Category category) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO CATEGORY (CategoryCode, CategoryName)
                                                     VALUES (@CategoryCode, @CategoryName)", connection);
            command.Parameters.AddWithValue("@CategoryCode", category.CategoryCode);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not Category category) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE CATEGORY 
                                                     SET CategoryCode = @CategoryCode, CategoryName = @CategoryName
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@CategoryCode", category.CategoryCode);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            command.Parameters.AddWithValue("@Id", category.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM CATEGORY WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM CATEGORY WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null && (int)result > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Category category) return false;
            return IsExist(category.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = new SqlCommand(@"SELECT Id, CategoryCode, CategoryName FROM CATEGORY", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    CategoryCode = reader.GetString(1),
                    CategoryName = reader.GetString(2),
                });
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var category = Read(id);
            if (category != null)
            {
                Items.Clear();
                Items.Add(category);
                return true;
            }
            return false;
        }

        public IModel? Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, CategoryCode, CategoryName
                                                     FROM CATEGORY 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new Category
            {
                Id = reader.GetInt32(0),
                CategoryCode = reader.GetString(1),
                CategoryName = reader.GetString(2),
            } : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Category category) return false;
            return IsExist(category.Id) ? Update(category) : Create(category);
        }

        public List<IModel> SearchByCodeOrName(string keyword)
        {
            var searchResults = new List<IModel>();
            if (string.IsNullOrEmpty(keyword)) return searchResults;

            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, CategoryCode, CategoryName
                                                     FROM CATEGORY 
                                                     WHERE CategoryCode LIKE @Keyword OR CategoryName LIKE @Keyword", connection);
            command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    CategoryCode = reader.GetString(1),
                    CategoryName = reader.GetString(2),
                });
            }
            return searchResults;
        }

        public int GetIdByCode(string code)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id FROM CATEGORY WHERE CategoryCode = @CategoryCode", connection);
            command.Parameters.AddWithValue("@CategoryCode", code);
            var result = command.ExecuteScalar();
            return result != null ? (int)result : 0;
        }

        public List<Category> GetCategoryNames()
        {
            var categories = new List<Category>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id, CategoryName FROM CATEGORY", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    CategoryName = reader.GetString(1),
                });
            }
            return categories;
        }
    }
}
