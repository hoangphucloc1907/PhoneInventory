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

        public bool Create(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO EXPORTDETAIL (ExportId, ProductId, Quantity, UnitPrice)
                                                     VALUES (@ExportId, @ProductId, @Quantity, @UnitPrice)", connection);
            command.Parameters.AddWithValue("@ExportId", exportDetail.ExportId);
            command.Parameters.AddWithValue("@ProductId", exportDetail.ProductId);
            command.Parameters.AddWithValue("@Quantity", exportDetail.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", exportDetail.UnitPrice);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not ExportDetail exportDetail) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE EXPORTDETAIL 
                                                     SET ProductId = @ProductId, Quantity = @Quantity, UnitPrice = @UnitPrice
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@ProductId", exportDetail.ProductId);
            command.Parameters.AddWithValue("@Quantity", exportDetail.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", exportDetail.UnitPrice);
            command.Parameters.AddWithValue("@Id", exportDetail.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM EXPORTDETAIL WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM EXPORTDETAIL WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null && (int)result > 0;
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
            using var command = new SqlCommand(@"SELECT E.Id, E.ExportId, U.FirstName, C.FirstName, 
                                                     E2.ExportDate, P.ProductName, E.Quantity, E.UnitPrice
                                                     FROM ExportDetail E
                                                     JOIN Export E2 ON E.ExportId = E2.Id
                                                     JOIN [User] U ON E2.EmployeeId = U.Id
                                                     JOIN Customer C ON E2.CustomerId = C.Id
                                                     JOIN Product P ON E.ProductId = P.Id", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Items.Add(new ExportDetail
                {
                    Id = reader.GetInt32(0),
                    ExportId = reader.GetInt32(1),
                    Employee = new User { FirstName = reader.GetString(2) },
                    Customer = new Customer { FirstName = reader.GetString(3) },
                    Export = new Export { ExportDate = reader.GetDateTime(4) },
                    Product = new Product { ProductName = reader.GetString(5) },
                    Quantity = reader.GetInt32(6),
                    UnitPrice = reader.GetDecimal(7),

                });
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
            using var command = new SqlCommand(@"SELECT Id, ExportId, ProductId, Quantity, UnitPrice
                                                     FROM EXPORTDETAIL 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new ExportDetail
            {
                Id = reader.GetInt32(0),
                ExportId = reader.GetInt32(1),
                ProductId = reader.GetInt32(2),
                Quantity = reader.GetInt32(3),
                UnitPrice = reader.GetDecimal(4),
            } : null;
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
            using var checkCommand = new SqlCommand(@"SELECT Id FROM EXPORT WHERE CustomerId = @CustomerId AND CAST(ExportDate AS DATE) = @ExportDate", connection);
            checkCommand.Parameters.AddWithValue("@CustomerId", exportModel.CustomerId);
            checkCommand.Parameters.AddWithValue("@ExportDate", exportModel.ExportDate.Date);
            var existingId = checkCommand.ExecuteScalar();
            if (existingId != null)
            {
                return Convert.ToInt32(existingId);
            }
            using var insertCommand = new SqlCommand(@"INSERT INTO EXPORT (CustomerId, EmployeeId, ExportDate) 
                                                           VALUES (@CustomerId, @EmployeeId, @ExportDate);
                                                           SELECT SCOPE_IDENTITY();", connection);
            insertCommand.Parameters.AddWithValue("@CustomerId", exportModel.CustomerId);
            insertCommand.Parameters.AddWithValue("@EmployeeId", exportModel.EmployeeId);
            insertCommand.Parameters.AddWithValue("@ExportDate", exportModel.ExportDate.Date);
            var insertedId = insertCommand.ExecuteScalar();
            return insertedId != null ? Convert.ToInt32(insertedId) : 0;
        }

        public int SelectCustomerIdByExportId(int exportId)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT CustomerId FROM EXPORT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", exportId);
            var result = command.ExecuteScalar();
            return result != null ? (int)result : 0;
        }

        public int SelectEmployeeIdByExportId(int exportId)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT EmployeeId FROM EXPORT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", exportId);
            var result = command.ExecuteScalar();
            return result != null ? (int)result : 0;
        }

        public DateTime SelectDateByExportId(int exportId)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand("SELECT ExportDate FROM EXPORT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", exportId);
            var result = command.ExecuteScalar();
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public int SaveExport(int customerId, int employeeId, DateTime exportDate)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO EXPORT (CustomerId, EmployeeId, ExportDate)
                                                     OUTPUT INSERTED.Id
                                                     VALUES (@CustomerId, @EmployeeId, @ExportDate)", connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);
            command.Parameters.AddWithValue("@EmployeeId", employeeId);
            command.Parameters.AddWithValue("@ExportDate", exportDate);
            return (int)command.ExecuteScalar();
        }

        public void SaveExportDetail(int exportId, int productId, int quantity, decimal unitPrice)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();

            // Kiểm tra số lượng tồn kho
            using (var checkCommand = new SqlCommand(@"SELECT StockBalance FROM CurrentStock WHERE ProductId = @ProductId", connection))
            {
                checkCommand.Parameters.AddWithValue("@ProductId", productId);
                var stockBalance = (int)checkCommand.ExecuteScalar();

                if (stockBalance < quantity)
                {
                    throw new InvalidOperationException("Số lượng tồn kho không đủ để xuất.");
                }
            }

            // Lưu thông tin vào ExportDetail nếu đủ tồn kho
            using (var command = new SqlCommand(@"INSERT INTO EXPORTDETAIL (ExportId, ProductId, Quantity, UnitPrice)
                                             VALUES (@ExportId, @ProductId, @Quantity, @UnitPrice)", connection))
            {
                command.Parameters.AddWithValue("@ExportId", exportId);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.ExecuteNonQuery();
            }
        }
    }
}
