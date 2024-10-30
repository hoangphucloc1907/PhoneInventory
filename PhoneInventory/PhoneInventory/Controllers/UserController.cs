using PhoneWarehouse.Models;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using PhoneWarehouse.Utils;
using System.Text.RegularExpressions;


namespace PhoneWarehouse.Controllers
{
    internal class UserController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public UserController()
        {
            _connectDB = new ConnectDB();
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, User user = null, object id = null, string keyword = null)
        {
            var command = new SqlCommand(query, connection);
            if (user != null)
            {
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                command.Parameters.AddWithValue("@Gender", user.Gender);
                command.Parameters.AddWithValue("@Address", user.Address);
                command.Parameters.AddWithValue("@Role", user.Role);
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
            if (model is not User user) return false;
            user.Password = HashPassword(user.Password);
            return ExecuteNonQuery(@"INSERT INTO [USER] (UserName, Password, LastName, FirstName, PhoneNumber, Gender, Address, Role)
                                         VALUES (@UserName, @Password, @LastName, @FirstName, @PhoneNumber, @Gender, @Address, @Role)", user);
        }

        public bool Update(IModel model)
        {
            if (model is not User user) return false;
            return ExecuteNonQuery(@"UPDATE [USER] 
                                         SET UserName = @UserName, Password = @Password, LastName = @LastName, FirstName = @FirstName, PhoneNumber = @PhoneNumber, Gender = @Gender, Address = @Address, Role = @Role
                                         WHERE Id = @Id", user);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM [USER] WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM [USER] WHERE Id = @Id", id: id) > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not User user) return false;
            return IsExist(user.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = CreateCommand(connection, @"SELECT * FROM [USER]");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToUser(reader));
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var user = Read(id);
            if (user != null)
            {
                Items.Clear();
                Items.Add(user);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, UserName, Password, LastName, FirstName, PhoneNumber, Gender, Address, Role 
                                                                FROM [USER] 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToUser(reader) : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not User user) return false;
            return IsExist(user.Id) ? Update(user) : Create(user);
        }

        public List<IModel> SearchByAccountOrFirstName(string keyword)
        {
            var searchResults = new List<IModel>();
            if (string.IsNullOrEmpty(keyword)) return searchResults;

            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, UserName, LastName, FirstName, PhoneNumber, Gender, Password, Address, Role 
                                                                FROM [USER] 
                                                                WHERE UserName LIKE @Keyword OR FirstName LIKE @Keyword", keyword: keyword);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(MapReaderToUser(reader));
            }
            return searchResults;
        }

        public bool IsValidPhone(string phone)
        {
            string phonePattern = @"^\d{10,11}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA512.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var builder = new StringBuilder();
            foreach (var b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }

        public string Login(string username, string password)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();

            if (!UserExists(username, connection))
            {
                return "Tài khoản không có";
            }

            string hashedPassword = HashPassword(password);

            if (!PasswordMatches(username, hashedPassword, connection))
            {
                return "Mật khẩu không đúng";
            }

            return GetRole(username, hashedPassword, connection) ?? "Đăng nhập thất bại";
        }

        private bool UserExists(string username, SqlConnection connection)
        {
            using var command = CreateCommand(connection, "SELECT COUNT(1) FROM [USER] WHERE UserName = @UserName");
            command.Parameters.AddWithValue("@UserName", username);
            return (int)command.ExecuteScalar() > 0;
        }

        private bool PasswordMatches(string username, string hashedPassword, SqlConnection connection)
        {
            using var command = CreateCommand(connection, "SELECT COUNT(1) FROM [USER] WHERE UserName = @UserName AND Password = @Password");
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", hashedPassword);
            return (int)command.ExecuteScalar() > 0;
        }

        private string GetRole(string username, string hashedPassword, SqlConnection connection)
        {
            using var command = CreateCommand(connection, "SELECT Role FROM [USER] WHERE UserName = @UserName AND Password = @Password");
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", hashedPassword);
            return command.ExecuteScalar() as string;
        }

        public int GetUserIdByUsername(string username)
        {
            return ExecuteScalar<int>("SELECT Id FROM [USER] WHERE UserName = @UserName", keyword: username);
        }

        public int GetUserIdByFirstname(string firstname)
        {
            return ExecuteScalar<int>("SELECT Id FROM [USER] WHERE FirstName = @FirstName", keyword: firstname);
        }

        public string GetFirstnameById(int id)
        {
            return ExecuteScalar<string>("SELECT FirstName FROM [USER] WHERE Id = @Id", id: id);
        }

        public List<User> GetUserNames()
        {
            var users = new List<User>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, "SELECT Id, FirstName FROM [USER]");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                });
            }
            return users;
        }

        private bool ExecuteNonQuery(string query, User user = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, user, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, User user = null, object id = null, string keyword = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, user, id, keyword);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private User MapReaderToUser(SqlDataReader reader)
        {
            return new User
            {
                Id = reader.GetInt32(0),
                UserName = reader.GetString(1),
                Password = reader.GetString(2),
                LastName = reader.GetString(3),
                FirstName = reader.GetString(4),
                PhoneNumber = reader.GetString(5),
                Gender = reader.GetString(6),
                Address = reader.GetString(7),
                Role = reader.GetString(8)
            };
        }
    }
}
