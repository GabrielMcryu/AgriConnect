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
    class SupplierProduct : MarshalByRefObject, ISupplierProduct
    {
        public static string connectionString = "Data Source=DESKTOP-UFTA8G9;Initial Catalog=AgriConnect;Integrated Security=True";

        public void AddSupplierProduct(SupplierProductDto supplierProductDto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SupplierProducts (Name, Price) VALUES (@Name, @Price)";
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Id", supplierProductDto.Id);
                command.Parameters.AddWithValue("@Name", supplierProductDto.Name);
                command.Parameters.AddWithValue("@Price", supplierProductDto.Price);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<SupplierProductDto> GetSupplierProducts()
        {
            List<SupplierProductDto> supplierProducts = new List<SupplierProductDto>();

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                string query = "SELECT * FROM SupplierProducts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SupplierProductDto supplierProductDto = new SupplierProductDto();
                            supplierProductDto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            supplierProductDto.Name = reader.GetString(reader.GetOrdinal("Name"));
                            supplierProductDto.Price = reader.GetInt32(reader.GetOrdinal("Price"));

                            supplierProducts.Add(supplierProductDto);
                        }
                    }
                }
                connection.Close();
            }
            

            return supplierProducts;
        }

        public void UpdateSupplierProduct(SupplierProductDto supplierProductDto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Update SupplierProducts SET Name = @Name, Price = @Price WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Name", supplierProductDto.Name);
                    command.Parameters.AddWithValue("@Price", supplierProductDto.Price);
                    command.Parameters.AddWithValue("@Id", supplierProductDto.Id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
