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

        public bool Create(IModel model)
        {
            if (model is not Supplier supplier) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO SUPPLIER (SupplierCode, SupplierName, Address, PhoneNumber)
                                                     VALUES (@SupplierCode, @SupplierName, @Address, @PhoneNumber)", connection);
            command.Parameters.AddWithValue("@SupplierCode", supplier.SupplierCode);
            command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
            command.Parameters.AddWithValue("@Address", supplier.Address);
            command.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not Supplier supplier) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE SUPPLIER 
                                                     SET SupplierCode = @SupplierCode, SupplierName = @SupplierName, Address = @Address, PhoneNumber = @PhoneNumber
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@SupplierCode", supplier.SupplierCode);
            command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
            command.Parameters.AddWithValue("@Address", supplier.Address);
            command.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);
            command.Parameters.AddWithValue("@Id", supplier.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM SUPPLIER WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM SUPPLIER WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null && (int)result > 0;
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
            using var command = new SqlCommand(@"SELECT * FROM SUPPLIER", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new Supplier
                {
                    Id = reader.GetInt32(0),
                    SupplierCode = reader.GetString(1),
                    SupplierName = reader.GetString(2),
                    Address = reader.GetString(3),
                    PhoneNumber = reader.GetString(4)
                });
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

        public IModel? Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, SupplierCode, SupplierName, Address, PhoneNumber
                                                     FROM SUPPLIER 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new Supplier
            {
                Id = reader.GetInt32(0),
                SupplierCode = reader.GetString(1),
                SupplierName = reader.GetString(2),
                Address = reader.GetString(3),
                PhoneNumber = reader.GetString(4)
            } : null;
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
            using var command = new SqlCommand(@"SELECT Id, SupplierCode, SupplierName, Address, PhoneNumber
                                                     FROM SUPPLIER 
                                                     WHERE SupplierCode LIKE @Keyword OR SupplierName LIKE @Keyword", connection);
            command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                searchResults.Add(new Supplier
                {
                    Id = reader.GetInt32(0),
                    SupplierCode = reader.GetString(1),
                    SupplierName = reader.GetString(2),
                    Address = reader.GetString(3),
                    PhoneNumber = reader.GetString(4)
                });
            }
            return searchResults;
        }

        public List<Supplier> GetSuplliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, SupplierName FROM SUPPLIER", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                suppliers.Add(new Supplier
                {
                    Id = reader.GetInt32(0),
                    SupplierName = reader.GetString(1)
                });
            }
            return suppliers;
        }
    }
}
