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
    internal class ExportController : IController
    {
        private readonly ConnectDB _connectDB;
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public ExportController()
        {
            _connectDB = new ConnectDB();
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, ExportDetail exportDetail = null, object id = null, Export exportModel = null)
        {
            var command = new SqlCommand(query, connection);
            if (exportDetail != null)
            {
                command.Parameters.AddWithValue("@ExportId", exportDetail.ExportId);
                command.Parameters.AddWithValue("@ProductId", exportDetail.ProductId);
                command.Parameters.AddWithValue("@Quantity", exportDetail.Quantity);
                command.Parameters.AddWithValue("@UnitPrice", exportDetail.UnitPrice);
                command.Parameters.AddWithValue("@Id", exportDetail.Id);
            }
            if (id != null)
            {
                command.Parameters.AddWithValue("@Id", id);
            }
            if (exportModel != null)
            {
                command.Parameters.AddWithValue("@CustomerId", exportModel.CustomerId);
                command.Parameters.AddWithValue("@EmployeeId", exportModel.EmployeeId);
                command.Parameters.AddWithValue("@ExportDate", exportModel.ExportDate.Date);
            }
            return command;
        }

        public bool Create(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            return ExecuteNonQuery(@"INSERT INTO EXPORTDETAIL (ExportId, ProductId, Quantity, UnitPrice)
                                         VALUES (@ExportId, @ProductId, @Quantity, @UnitPrice)", exportDetail);
        }

        public bool Update(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            return ExecuteNonQuery(@"UPDATE EXPORTDETAIL 
                                         SET ProductId = @ProductId, Quantity = @Quantity, UnitPrice = @UnitPrice
                                         WHERE Id = @Id", exportDetail);
        }

        public bool Delete(object id)
        {
            return ExecuteNonQuery(@"DELETE FROM EXPORTDETAIL WHERE Id = @Id", id: id);
        }

        public bool IsExist(object id)
        {
            return ExecuteScalar<int>(@"SELECT COUNT(*) FROM EXPORTDETAIL WHERE Id = @Id", id: id) > 0;
        }

        public bool IsExist(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            return IsExist(exportDetail.Id);
        }

        public bool Load()
        {
            Items.Clear();
            using var connection = _connectDB.GetConnection();
            using var command = CreateCommand(connection, @"SELECT E.Id, E.ExportId, U.FirstName AS Employee, C.FirstName AS Customer, 
                                                                E2.ExportDate AS Date, P.ProductName AS Product, E.Quantity, E.ProductId, 
                                                                E.UnitPrice, P.ListPrice, E.Quantity * E.UnitPrice AS TotalPrice 
                                                                FROM ExportDetail E
                                                                LEFT JOIN Export E2 ON E.ExportId = E2.Id
                                                                LEFT JOIN [User] U ON E2.EmployeeId = U.Id
                                                                LEFT JOIN Customer C ON E2.CustomerId = C.Id
                                                                LEFT JOIN Product P ON E.ProductId = P.Id");
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(MapReaderToExportDetail(reader));
            }
            return Items.Count > 0;
        }

        public bool Load(object id)
        {
            var exportDetail = Read(id);
            if (exportDetail != null)
            {
                Items.Clear();
                Items.Add(exportDetail);
                return true;
            }
            return false;
        }

        public IModel Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, @"SELECT Id, ExportId, ProductId, Quantity, UnitPrice
                                                                FROM EXPORTDETAIL 
                                                                WHERE Id = @Id", id: id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? MapReaderToExportDetail(reader) : null;
        }

        public bool Upsert(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            return IsExist(exportDetail.Id) ? Update(exportDetail) : Create(exportDetail);
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

        public int CheckExport(Export exportModel)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var checkCommand = CreateCommand(connection, @"SELECT Id FROM EXPORT WHERE CustomerId = @CustomerId AND CAST(ExportDate AS DATE) = @ExportDate", exportModel: exportModel);
            var existingId = checkCommand.ExecuteScalar();
            if (existingId != null)
            {
                return Convert.ToInt32(existingId);
            }
            using var insertCommand = CreateCommand(connection, @"INSERT INTO EXPORT (CustomerId, EmployeeId, ExportDate) 
                                                                      VALUES (@CustomerId, @EmployeeId, @ExportDate);
                                                                      SELECT SCOPE_IDENTITY();", exportModel: exportModel);
            var insertedId = insertCommand.ExecuteScalar();
            return insertedId != null ? Convert.ToInt32(insertedId) : 0;
        }

        public int SelectCustomerIdByExportId(int exportId)
        {
            return ExecuteScalar<int>("SELECT CustomerId FROM EXPORT WHERE Id = @Id", id: exportId);
        }

        public int SelectEmployeeIdByExportId(int exportId)
        {
            return ExecuteScalar<int>("SELECT EmployeeId FROM EXPORT WHERE Id = @Id", id: exportId);
        }

        public DateTime SelectDateByExportId(int exportId)
        {
            return ExecuteScalar<DateTime>("SELECT ExportDate FROM EXPORT WHERE Id = @Id", id: exportId);
        }

        private bool ExecuteNonQuery(string query, ExportDetail exportDetail = null, object id = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, exportDetail, id);
            return command.ExecuteNonQuery() > 0;
        }

        private T ExecuteScalar<T>(string query, ExportDetail exportDetail = null, object id = null, Export exportModel = null)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = CreateCommand(connection, query, exportDetail, id, exportModel);
            var result = command.ExecuteScalar();
            return result != null ? (T)result : default;
        }

        private ExportDetail MapReaderToExportDetail(SqlDataReader reader)
        {
            return new ExportDetail
            {
                Id = reader.GetInt32(0),
                ExportId = reader.GetInt32(1),
                ProductId = reader.GetInt32(2),
                Quantity = reader.GetInt32(3),
                UnitPrice = reader.GetDecimal(4),
            };
        }
    }
}
