using Market_Club.Models;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace Market_Club.Services
{
    internal class UserServiceBase
    {
        private readonly string connectionString;

        public UserModel PassWordCheck(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username";

            UserModel user = null;

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            using (SqlConnection conexion = sqlConnection)
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@username", username);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                user = reader.Read() ? new UserModel
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader["Name"]?.ToString(),
                    Surname = reader["Surname"]?.ToString(),
                    Password = reader["Password"]?.ToString(),
                    Email = reader["Email"]?.ToString(),
                    RolId = reader.GetInt32(reader.GetOrdinal("RolId")),
                    Username = reader["Username"]?.ToString(),
                } : null;
            }
            if (user == null)
            {
                return user;
            }

            if (user.Password == password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        internal UserModel PassWordCheck(string username)
        {
            string connectionString = GetConnectionString();
            UserModel userModel = null;

            string query = "SELECT ID, Username, PasswordHash, IsActive FROM Users WHERE Username = @username;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@username", username);


                        connection.Open();


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de acceso a la base de datos: " + ex.Message);
            }

            return userModel;
        }

        private string GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}