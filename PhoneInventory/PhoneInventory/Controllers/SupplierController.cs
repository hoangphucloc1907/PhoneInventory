using PhoneWarehouse.Models;
using PhoneWarehouse.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneWarehouse.Controllers
{
    internal class SupplierController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public SupplierController()
        {
            _connectDB = new ConnectDB();
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, Supplier supplier = null, object id = null, string keyword = null)
        {
            var command = new SqlCommand(query, connection);
            if (supplier != null)
            {
                command.Parameters.AddWithValue("@Id", supplier.Id);
                command.Parameters.AddWithValue("@SupplierCode", supplier.SupplierCode);
                command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                command.Parameters.AddWithValue("@Address", supplier.Address);
                command.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);
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
            if (model is not Supplier supplier) return false;
            return ExecuteNonQuery(@"INSERT INTO SUPPLIER (SupplierCode, SupplierName, Address, PhoneNumber)
                                         VALUES (@SupplierCode, @SupplierName, @Address, @PhoneNumber)", supplier);
        }

        public bool Update(IModel model)
        {
            if (model is not Supplier supplier) return false;
            return ExecuteNonQuery(@"UPDATE SUPPLIER 
                                         SET SupplierCode = @SupplierCode, SupplierName = @SupplierName, Address = @Address, PhoneNumber = @PhoneNumber
                                         WHERE Id = @Id", supplier);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM SUPPLIER WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM SUPPLIER WHERE Id = @Id", id: id) > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Supplier supplier) return false;
            return IsExist(supplier.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = CreateCommand(connection, @"SELECT * FROM SUPPLIER");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToSupplier(reader));
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var supplier = Read(id);
            if (supplier != null)
            {
                Items.Clear();
                Items.Add(supplier);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, SupplierCode, SupplierName, Address, PhoneNumber
                                                                FROM SUPPLIER 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToSupplier(reader) : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not Supplier supplier) return false;
            return IsExist(supplier.Id) ? Update(supplier) : Create(supplier);
        }

        public bool IsValidPhone(string phone)
        {
            string phonePattern = @"^\d{10,11}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        public List<IModel> SearchByCodeOrName(string keyword)
        {
            var searchResults = new List<IModel>();
            if (string.IsNullOrEmpty(keyword)) return searchResults;

            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, SupplierCode, SupplierName, Address, PhoneNumber
                                                                FROM SUPPLIER 
                                                                WHERE SupplierCode LIKE @Keyword OR SupplierName LIKE @Keyword", keyword: keyword);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(MapReaderToSupplier(reader));
            }
            return searchResults;
        }

        private bool ExecuteNonQuery(string query, Supplier supplier = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, supplier, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, Supplier supplier = null, object id = null, string keyword = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, supplier, id, keyword);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private Supplier MapReaderToSupplier(SqlDataReader reader)
        {
            return new Supplier
            {
                Id = reader.GetInt32(0),
                SupplierCode = reader.GetString(1),
                SupplierName = reader.GetString(2),
                Address = reader.GetString(3),
                PhoneNumber = reader.GetString(4)
            };
        }
    }
}
