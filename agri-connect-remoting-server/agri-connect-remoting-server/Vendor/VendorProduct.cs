using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shared_interfaces;
using System.Data.SqlClient;
using shared_interfaces.DTO;

namespace agri_connect_remoting_server.Vendor
{
    class VendorProduct : MarshalByRefObject, IVendorProduct
    {
        public static string connectionString = "Data Source=DESKTOP-UFTA8G9;Initial Catalog=AgriConnect;Integrated Security=True";

        public void AddVendorProduct(VendorProductDto vendorProductDto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO VendorProducts (Name, Price) VALUES (@Name, @Price)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", vendorProductDto.Name);
                command.Parameters.AddWithValue("@Price", vendorProductDto.Price);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public VendorProductDto GetVendorProduct(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM VendorProducts WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            VendorProductDto vendorProduct = new VendorProductDto()
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            };

                            return vendorProduct;
                        }
                    }
                }

                connection.Close();
            }
            return null;
        }

        public List<VendorProductDto> GetVendorProducts()
        {
            List<VendorProductDto> vendorProducts = new List<VendorProductDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM VendorProducts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VendorProductDto vendorProductDto = new VendorProductDto();
                            vendorProductDto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            vendorProductDto.Name = reader.GetString(reader.GetOrdinal("Name"));
                            vendorProductDto.Price = reader.GetInt32(reader.GetOrdinal("Price"));

                            vendorProducts.Add(vendorProductDto);
                        }
                    }
                    connection.Close();
                }

                return vendorProducts;
            }
        }
    }
}
