﻿using System;
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
