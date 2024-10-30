using System.Configuration;
using System.Data.SqlClient;

namespace PhoneWarehouse.Utils
{
    public class ConnectDB
    {
        private readonly string _connectionString;
        public ConnectDB()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PhoneConnect"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
