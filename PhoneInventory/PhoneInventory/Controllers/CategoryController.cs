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

        private SqlCommand CreateCommand(SqlConnection connection, string query, Category category = null, object id = null, string keyword = null)
        {
            var command = new SqlCommand(query, connection);
            if (category != null)
            {
                command.Parameters.AddWithValue("@CategoryCode", category.CategoryCode);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                command.Parameters.AddWithValue("@Id", category.Id);
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
            if (model is not Category category) return false;
            return ExecuteNonQuery(@"INSERT INTO CATEGORY (CategoryCode, CategoryName)
                                             VALUES (@CategoryCode, @CategoryName)", category);
        }

        public bool Update(IModel model)
        {
            if (model is not Category category) return false;
            return ExecuteNonQuery(@"UPDATE CATEGORY 
                                             SET CategoryCode = @CategoryCode, CategoryName = @CategoryName
                                             WHERE Id = @Id", category);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM CATEGORY WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM CATEGORY WHERE Id = @Id", id: id) > 0;
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
            using var command = CreateCommand(connection, @"SELECT Id, CategoryCode, CategoryName FROM CATEGORY");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToCategory(reader));
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

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, CategoryCode, CategoryName
                                                                    FROM CATEGORY 
                                                                    WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToCategory(reader) : null;
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
            using var command = CreateCommand(connection, @"SELECT Id, CategoryCode, CategoryName
                                                                    FROM CATEGORY 
                                                                    WHERE CategoryCode LIKE @Keyword OR CategoryName LIKE @Keyword", keyword: keyword);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(MapReaderToCategory(reader));
            }
            return searchResults;
        }

        public int GetIdByCode(string code)
        {
            return ExecuteScalar<int>("SELECT Id FROM CATEGORY WHERE CategoryCode = @CategoryCode", keyword: code);
        }

        public List<Category> GetCategoryNames()
        {
            var categories = new List<Category>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, "SELECT Id, CategoryName FROM CATEGORY");
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

        private bool ExecuteNonQuery(string query, Category category = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, category, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, Category category = null, object id = null, string keyword = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, category, id, keyword);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private Category MapReaderToCategory(SqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetInt32(0),
                CategoryCode = reader.GetString(1),
                CategoryName = reader.GetString(2),
            };
        }
    }
}
