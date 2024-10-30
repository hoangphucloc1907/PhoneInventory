using PhoneWarehouse.Models;
using PhoneWarehouse.Utils;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace PhoneWarehouse.Controllers
{
    internal class CustomerController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public CustomerController()
        {
            _connectDB = new ConnectDB();
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, Customer customer = null, object id = null, string keyword = null)
        {
            var command = new SqlCommand(query, connection);
            if (customer != null)
            {
                command.Parameters.AddWithValue("@Id", customer.Id);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("@Gender", customer.Gender);
                command.Parameters.AddWithValue("@Address", customer.Address);
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
            if (model is not Customer customer) return false;
            return ExecuteNonQuery(@"INSERT INTO CUSTOMER (LastName, FirstName, PhoneNumber, Gender, Address)
                                         VALUES (@LastName, @FirstName, @PhoneNumber, @Gender, @Address)", customer);
        }

        public bool Update(IModel model)
        {
            if (model is not Customer customer) return false;
            return ExecuteNonQuery(@"UPDATE CUSTOMER 
                                         SET LastName = @LastName, FirstName = @FirstName, PhoneNumber = @PhoneNumber, Gender = @Gender, Address = @Address
                                         WHERE Id = @Id", customer);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM CUSTOMER WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM CUSTOMER WHERE Id = @Id", id: id) > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Customer customer) return false;
            return IsExist(customer.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = CreateCommand(connection, @"SELECT Id, LastName, FirstName, PhoneNumber, Gender, Address FROM CUSTOMER");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToCustomer(reader));
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var customer = Read(id);
            if (customer != null)
            {
                Items.Clear();
                Items.Add(customer);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, LastName, FirstName, PhoneNumber, Gender, Address
                                                                FROM CUSTOMER 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToCustomer(reader) : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Customer customer) return false;
            return IsExist(customer.Id) ? Update(customer) : Create(customer);
        }

        public bool IsValidPhone(string phone)
        {
            const string phonePattern = @"^\d{10,11}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        public List<IModel> SearchFirstName(string keyword)
        {
            var searchResults = new List<IModel>();
            if (string.IsNullOrEmpty(keyword)) return searchResults;

            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, LastName, FirstName, PhoneNumber, Gender, Address
                                                                FROM CUSTOMER 
                                                                WHERE FirstName LIKE @Keyword", keyword: keyword);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(MapReaderToCustomer(reader));
            }
            return searchResults;
        }

        public int GetCusIdByFirstname(string firstname)
        {
            return ExecuteScalar<int>("SELECT Id FROM CUSTOMER WHERE FirstName = @FirstName", keyword: firstname);
        }

        public string GetFirstnameById(int id)
        {
            return ExecuteScalar<string>("SELECT FirstName FROM CUSTOMER WHERE Id = @Id", id: id);
        }

        public List<Customer> GetCustomerNames()
        {
            var customers = new List<Customer>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, "SELECT Id, FirstName FROM CUSTOMER");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                });
            }
            return customers;
        }

        private bool ExecuteNonQuery(string query, Customer customer = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, customer, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, Customer customer = null, object id = null, string keyword = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, customer, id, keyword);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private Customer MapReaderToCustomer(SqlDataReader reader)
        {
            return new Customer
            {
                Id = reader.GetInt32(0),
                LastName = reader.GetString(1),
                FirstName = reader.GetString(2),
                PhoneNumber = reader.GetString(3),
                Gender = reader.GetString(4),
                Address = reader.GetString(5),
            };
        }
    }
}
