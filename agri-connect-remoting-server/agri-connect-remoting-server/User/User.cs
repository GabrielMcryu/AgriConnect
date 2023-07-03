using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shared_interfaces;
using System.Data.SqlClient;
using shared_interfaces.DTO;

namespace agri_connect_remoting_server.User
{
    class User : MarshalByRefObject, IUser
    {
        public static string connectionString = "Data Source=DESKTOP-UFTA8G9;Initial Catalog=AgriConnect;Integrated Security=True";

        public void DeleteUser(int Id)
        {
            UserDto user = GetUserById(Id);

            if(user != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string deleteQuery;
                    string userQuery = "DELETE FROM Users WHERE Id = @Id";

                    if (user.Role == "Supplier")
                    {
                        deleteQuery = "DELETE FROM SupplierTransactions WHERE SupplierName = @Username";
                    }
                    else if (user.Role == "Vendor")
                    {
                        deleteQuery = "DELETE FROM VendorTransactions WHERE VendorName = @Username";
                    }
                    else
                    {
                        deleteQuery = "";
                    }

                    if(!string.IsNullOrEmpty(deleteQuery))
                    {
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@Username", user.Username);

                            connection.Open();
                            deleteCommand.ExecuteNonQuery();                       
                        }
                        connection.Close();

                        using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                        {
                            userCommand.Parameters.AddWithValue("@Id", Id);

                            connection.Open();
                            userCommand.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }
        }

        public UserDto GetUserById(int Id)
        {
           using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            UserDto user = new UserDto()
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Username = (string)reader["Username"],
                                Role = (string)reader["Role"],
                                Email = (string)reader["Email"]
                            };

                            return user;
                        }
                    }
                }

                connection.Close();
            }
            return null;
        }

        public UserDto GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserDto user = new UserDto()
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Username = (string)reader["Username"],
                                Role = (string)reader["Role"],
                                Email = (string)reader["Email"]
                            };

                            return user;
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        public List<UserDto> GetUsers()
        {
            List<UserDto> users = new List<UserDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDto userDto = new UserDto();
                            userDto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            userDto.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                            userDto.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                            userDto.Username = reader.GetString(reader.GetOrdinal("Username"));
                            userDto.Role = reader.GetString(reader.GetOrdinal("Role"));
                            userDto.Email = reader.GetString(reader.GetOrdinal("Email"));

                            users.Add(userDto);
                        }
                    }
                }
                connection.Close();
            }

            return users;
        }

        public void UpdateUser(UserDto userDto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Update Users SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Role = @Role, Email = @Email WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@FirstName", userDto.FirstName);
                    command.Parameters.AddWithValue("@LastName", userDto.LastName);
                    command.Parameters.AddWithValue("@Username", userDto.Username);
                    command.Parameters.AddWithValue("@Role", userDto.Role);
                    command.Parameters.AddWithValue("@Email", userDto.Email);
                    command.Parameters.AddWithValue("@Id", userDto.Id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
