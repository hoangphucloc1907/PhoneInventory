using PhoneWarehouse.Models;
using PhoneWarehouse.Utils;
using System.Data.SqlClient;

namespace PhoneWarehouse.Controllers
{
    internal class ImportController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public ImportController()
        {
            _connectDB = new ConnectDB();
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, Import import = null, object id = null)
        {
            var command = new SqlCommand(query, connection);
            if (import != null)
            {
                command.Parameters.AddWithValue("@Id", import.Id);
                command.Parameters.AddWithValue("@SupplierId", import.SupplierId);
                command.Parameters.AddWithValue("@EmployeeId", import.EmployeeId);
                command.Parameters.AddWithValue("@ImportDate", import.ImportDate);
            }
            if (id != null)
            {
                command.Parameters.AddWithValue("@Id", id);
            }
            return command;
        }

        public bool Create(IModel model)
        {
            if (model is not Import import) return false;
            return ExecuteNonQuery(@"INSERT INTO IMPORT (SupplierId, EmployeeId, ImportDate)
                                         VALUES (@SupplierId, @EmployeeId, @ImportDate)", import);
        }

        public bool Update(IModel model)
        {
            if (model is not Import import) return false;
            return ExecuteNonQuery(@"UPDATE IMPORT 
                                         SET SupplierId = @SupplierId, EmployeeId = @EmployeeId, ImportDate = @ImportDate
                                         WHERE Id = @Id", import);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM IMPORT WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM IMPORT WHERE Id = @Id", id: id) > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not Import import) return false;
            return IsExist(import.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = CreateCommand(connection, @"SELECT * FROM IMPORT");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToImport(reader));
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var import = Read(id);
            if (import != null)
            {
                Items.Clear();
                Items.Add(import);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, SupplierId, EmployeeId, ImportDate
                                                                FROM IMPORT 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToImport(reader) : null;
        }

        private bool ExecuteNonQuery(string query, Import import = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, import, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, Import import = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, import, id);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private Import MapReaderToImport(SqlDataReader reader)
        {
            return new Import
            {
                Id = reader.GetInt32(0),
                SupplierId = reader.GetInt32(1),
                EmployeeId = reader.GetInt32(2),
                ImportDate = reader.GetDateTime(3)
            };
        }
    }
}
