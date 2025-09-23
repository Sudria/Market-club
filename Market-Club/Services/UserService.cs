using Market_Club.Class;
using Market_Club.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace Market_Club.Services
{
    internal class UserService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;

        public void InsertUser(UserModel user)
        {
            string query = "INSERT INTO Users (Username, Name, Surname, Password, RolId, Email) VALUES (@Username, @Name, @Surname, @Password, @RolId, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Surname", user.Surname);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@RolId", user.RolId);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Username", user.Username);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateUser(UserModel user)
        {
            string query = @"UPDATE Users
                     SET Name = @Name,
                         Surname = @Surname,
                         Password = @Password,
                         RolId = @RolId,
                         Username = @Username,
                         Email = @Email
                     WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Surname", user.Surname);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@RolId", user.RolId);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                conexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }




        public List<UserModel> ShowUsers()
        {
            var user = new List<UserModel>();
            string query = "SELECT * FROM Users";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Add(new UserModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader["Name"]?.ToString(),
                            Surname = reader["Surname"]?.ToString(),
                            Password = reader["Password"]?.ToString(),
                            Email = reader["Email"]?.ToString(),
                            RolId = reader.GetInt32(reader.GetOrdinal("RolId")),
                            Username = reader["Username"]?.ToString(),

                        });
                    }
                }
            }

            return user;
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM Users WHERE id = @Id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public UserModel ShowUserById(int id)
        {
            string query = "SELECT * FROM Users WHERE id = @Id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", id);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read() ? new UserModel
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
        }

        public UserModel PassWordCheck(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username";

            UserModel user = null;

            using (SqlConnection conexion = new SqlConnection(connectionString))
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
    }
}
