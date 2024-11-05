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

        public bool Create(IModel model)
        {
            if (model is not Import import) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO IMPORT (SupplierId, EmployeeId, ImportDate)
                                                     VALUES (@SupplierId, @EmployeeId, @ImportDate)", connection);
            command.Parameters.AddWithValue("@SupplierId", import.SupplierId);
            command.Parameters.AddWithValue("@EmployeeId", import.EmployeeId);
            command.Parameters.AddWithValue("@ImportDate", import.ImportDate);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Update(IModel model)
        {
            if (model is not Import import) return false;
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE IMPORT 
                                                     SET SupplierId = @SupplierId, EmployeeId = @EmployeeId, ImportDate = @ImportDate
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@SupplierId", import.SupplierId);
            command.Parameters.AddWithValue("@EmployeeId", import.EmployeeId);
            command.Parameters.AddWithValue("@ImportDate", import.ImportDate);
            command.Parameters.AddWithValue("@Id", import.Id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"DELETE FROM IMPORT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public bool IsExist(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM IMPORT WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = command.ExecuteScalar();
            return result != null && (int)result > 0;
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
            connection.Open();
            using var command = new SqlCommand(@"SELECT ip.Id, u.FirstName, sl.SupplierName, i.ImportDate, p.ProductName, ip.Quantity, ip.UnitPrice, ip.ImportId
                                                 FROM IMPORTDETAIL ip
                                                 JOIN IMPORT i ON i.Id = ip.ImportId
                                                 JOIN [USER] u ON u.Id = i.EmployeeId
                                                 JOIN SUPPLIER sl ON sl.Id = i.SupplierId
                                                 JOIN PRODUCT p ON p.Id = ip.ProductId", connection);
            using var reader = command.ExecuteReader();
            var importDetails = new List<ImportDetail>();
            while (reader.Read())
            {
                importDetails.Add(new ImportDetail
                {
                    Id = reader.GetInt32(0),                           
                    Employee = new User
                    {
                        FirstName = reader.GetString(1)               
                    },
                    Supplier = new Supplier
                    {
                        SupplierName = reader.GetString(2)             
                    },
                    Import = new Import
                    {
                        ImportDate = reader.GetDateTime(3),                  
                    },
                    Product = new Product
                    {
                        ProductName = reader.GetString(4)              
                    },
                    Quantity = reader.GetInt32(5),                   
                    UnitPrice = reader.GetDecimal(6),
                    ImportId = reader.GetInt32(7)

                });
            }
            Items.AddRange(importDetails);
            return importDetails.Count > 0;
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

        public IModel? Read(object id)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"SELECT Id, SupplierId, EmployeeId, ImportDate
                                                     FROM IMPORT 
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            return reader.Read() ? new Import
            {
                Id = reader.GetInt32(0),
                SupplierId = reader.GetInt32(1),
                EmployeeId = reader.GetInt32(2),
                ImportDate = reader.GetDateTime(3)
            } : null;
        }

        public int SaveImport(int supplierId, int employeeId, DateTime importDate)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO IMPORT (SupplierId, EmployeeId, ImportDate)
                                                     OUTPUT INSERTED.Id
                                                     VALUES (@SupplierId, @EmployeeId, @ImportDate)", connection);
            command.Parameters.AddWithValue("@SupplierId", supplierId);
            command.Parameters.AddWithValue("@EmployeeId", employeeId);
            command.Parameters.AddWithValue("@ImportDate", importDate);
            return (int)command.ExecuteScalar();
        }

        public void SaveImportDetail(int importId, int productId, int quantity, decimal unitPrice)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"INSERT INTO IMPORTDETAIL (ImportId, ProductId, Quantity, UnitPrice)
                                                     VALUES (@ImportId, @ProductId, @Quantity, @UnitPrice)", connection);
            command.Parameters.AddWithValue("@ImportId", importId);
            command.Parameters.AddWithValue("@ProductId", productId);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@UnitPrice", unitPrice);
            command.ExecuteNonQuery();
        }

        public bool UpdateImportDetail(int id, int quantity, decimal unitprice)
        {
            using var connection = _connectDB.GetConnection();
            connection.Open();
            using var command = new SqlCommand(@"UPDATE IMPORTDETAIL 
                                                     SET Quantity = @Quantity, UnitPrice = @UnitPrice
                                                     WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@UnitPrice", unitprice);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
