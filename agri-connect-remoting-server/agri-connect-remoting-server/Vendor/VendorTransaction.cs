using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shared_interfaces;
using shared_interfaces.DTO;
using System.Data.SqlClient;

namespace agri_connect_remoting_server.Vendor
{
    class VendorTransaction : MarshalByRefObject, IVendorTransaction
    {
        public static string connectionString = "Data Source=DESKTOP-UFTA8G9;Initial Catalog=AgriConnect;Integrated Security=True";

        public List<VendorTransactionDto> GetVendorTransactions()
        {
            List<VendorTransactionDto> vendorTransactions = new List<VendorTransactionDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM VendorTransactions";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VendorTransactionDto vendorTransactionDto = new VendorTransactionDto();
                            vendorTransactionDto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            vendorTransactionDto.VendorName = reader.GetString(reader.GetOrdinal("VendorName"));
                            vendorTransactionDto.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                            vendorTransactionDto.ProductQuantity = reader.GetInt32(reader.GetOrdinal("ProductQuantity"));
                            vendorTransactionDto.Cost = reader.GetInt32(reader.GetOrdinal("Cost"));
                            vendorTransactionDto.TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));

                            vendorTransactions.Add(vendorTransactionDto);
                        }
                    }
                    connection.Close();
                }
            }

            return vendorTransactions;
        }
    }
}
