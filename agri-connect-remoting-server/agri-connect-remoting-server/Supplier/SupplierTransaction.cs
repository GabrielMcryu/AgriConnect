using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shared_interfaces;
using System.Data.SqlClient;
using shared_interfaces.DTO;

namespace agri_connect_remoting_server.Supplier
{
    class SupplierTransaction : MarshalByRefObject, ISupplierTransaction
    {
        public static string connectionString = "Data Source=DESKTOP-UFTA8G9;Initial Catalog=AgriConnect;Integrated Security=True";

        public SupplierTransactionDto GetSupplierTransaction(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM SupplierTransactions WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            SupplierTransactionDto supplierTransaction = new SupplierTransactionDto
                            {
                                Id = (int)reader["Id"],
                                SupplierName = (string)reader["SupplierName"],
                                ProductName = (string)reader["ProductName"],
                                ProductQuantity = (int)reader["ProductQuantity"],
                                Cost = (int)reader["Cost"],
                                TransactionDate = (DateTime)reader["TransactionDate"]
                            };

                            return supplierTransaction;
                        }    
                    }
                }

                connection.Close();
            }
            return null;
        }

        public List<SupplierTransactionDto> GetSupplierTransactions()
        {
            List<SupplierTransactionDto> supplierTransactions = new List<SupplierTransactionDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SupplierTransactions";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SupplierTransactionDto supplierTransactionDto = new SupplierTransactionDto();
                            supplierTransactionDto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            supplierTransactionDto.SupplierName = reader.GetString(reader.GetOrdinal("SupplierName"));
                            supplierTransactionDto.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                            supplierTransactionDto.ProductQuantity = reader.GetInt32(reader.GetOrdinal("ProductQuantity"));
                            supplierTransactionDto.Cost = reader.GetInt32(reader.GetOrdinal("Cost"));
                            supplierTransactionDto.TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));

                            supplierTransactions.Add(supplierTransactionDto);

                        }
                    }
                    connection.Close();
                }
            }

            return supplierTransactions;
        }
    }
}
