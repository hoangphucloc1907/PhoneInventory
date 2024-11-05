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

        public bool Create(IModel model)
        {
            if (model is not User user) return false;
            user.Password = HashPassword(user.Password);
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO [USER] (UserName, Password, LastName, FirstName, PhoneNumber, Gender, Address, Role)
                                                     VALUES (@UserName, @Password, @LastName, @FirstName, @PhoneNumber, @Gender, @Address, @Role)", connection);
            AddUserParameters(command, user);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not User user) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE [USER] 
                                                     SET UserName = @UserName, Password = @Password, LastName = @LastName, FirstName = @FirstName, PhoneNumber = @PhoneNumber, Gender = @Gender, Address = @Address, Role = @Role
                                                     WHERE Id = @Id", connection);
            AddUserParameters(command, user);
            command.Parameters.AddWithValue("@Id", user.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM [USER] WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM [USER] WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return (int)command.ExecuteScalar() > 0;
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
            connection.Open();
            using var command = new SqlCommand(@"SELECT * FROM [USER]", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new User
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
                });
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

        public IModel? Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, UserName, Password, LastName, FirstName, PhoneNumber, Gender, Address, Role 
                                                     FROM [USER] 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new User
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
            } : null;
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
            using var command = new SqlCommand(@"SELECT Id, UserName, LastName, FirstName, PhoneNumber, Gender, Password, Address, Role 
                                                     FROM [USER] 
                                                     WHERE UserName LIKE @Keyword OR FirstName LIKE @Keyword", connection);
            command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(new User
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
                });
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
            using var command = new SqlCommand("SELECT COUNT(1) FROM [USER] WHERE UserName = @UserName", connection);
            command.Parameters.AddWithValue("@UserName", username);
            return (int)command.ExecuteScalar() > 0;
        }

        private bool PasswordMatches(string username, string hashedPassword, SqlConnection connection)
        {
            using var command = new SqlCommand("SELECT COUNT(1) FROM [USER] WHERE UserName = @UserName AND Password = @Password", connection);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", hashedPassword);
            return (int)command.ExecuteScalar() > 0;
        }

        private string GetRole(string username, string hashedPassword, SqlConnection connection)
        {
            using var command = new SqlCommand("SELECT Role FROM [USER] WHERE UserName = @UserName AND Password = @Password", connection);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", hashedPassword);
            return command.ExecuteScalar() as string;
        }

        public int GetUserIdByUsername(string username)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id FROM [USER] WHERE UserName = @UserName", connection);
            command.Parameters.AddWithValue("@UserName", username);
            return (int)command.ExecuteScalar();
        }

        public int GetUserIdByFirstname(string firstname)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id FROM [USER] WHERE FirstName = @FirstName", connection);
            command.Parameters.AddWithValue("@FirstName", firstname);
            return (int)command.ExecuteScalar();
        }

        public string GetFirstnameById(int id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT FirstName FROM [USER] WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return (string)command.ExecuteScalar();
        }

        public List<User> GetUserNames()
        {
            var users = new List<User>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT Id, FirstName FROM [USER]", connection);
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

        private void AddUserParameters(SqlCommand command, User user)
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
    }
}
