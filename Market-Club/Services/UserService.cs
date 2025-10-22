using Market_Club.Class;
using Market_Club.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace Market_Club.Services
{
    internal class UserService : UserServiceBase, IEquatable<UserService>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;
        private object connection;

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

        private string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;
        }

        public UserService(string connectionString, object connection)
        {
            this.connectionString = connectionString;
            this.connection = connection;
        }

        public UserService()
        {
        }

        internal new UserModel PassWordCheck(string username, string password)
        {
            // Usamos el parámetro 'password' que entra al método.
            string connectionString = GetConnectionString();
            // Temporalmente, usamos la contraseña de texto plano para que coincida con la DB.
            string inputHash = password;
            string query = @"SELECT Id, Username, RolId, Name, Email, Password, Surname 
                     FROM Users 
                     WHERE Username = @Username AND Password = @PasswordHash;";

            UserModel userModel = null;

            try
            {
                KillDatabaseConnections("db-poli");

                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", inputHash);

                        connection.Open();

                      
                            using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userModel = new UserModel
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                   Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    RolId = reader.IsDBNull(reader.GetOrdinal("RolId")) ? 0 : reader.GetInt32(reader.GetOrdinal("RolId")),
                                    Surname = reader.GetString(reader.GetOrdinal("Surname"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Usamos el MessageBox estándar de Windows Forms para evitar problemas
                // con los tipos de objetos (MessageBoxButton, MessageBoxImage).
                System.Windows.Forms.MessageBox.Show("Error de conexión o durante la autenticación: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return userModel;
        }

        void KillDatabaseConnections(string databaseName)
        {
            // Asegúrate de que 'GetConnectionString()' esté accesible y funcione.
            string connStr = GetConnectionString();

            // Necesitamos una cadena de conexión que apunte a la base de datos maestra
            // para poder ejecutar comandos de administración.
            string masterConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder(connStr) { InitialCatalog = "master" }.ConnectionString;

            // Comando SQL que fuerza la liberación de conexiones:
            string sql = $@"
        -- 1. Pone la DB en modo de usuario único (SINGLE_USER) y
        --    fuerza el cierre de todas las demás conexiones (ROLLBACK IMMEDIATE).
        ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        
        -- 2. Devuelve la DB a modo multiusuario (MULTI_USER) para que tu aplicación pueda usarla.
        ALTER DATABASE [{databaseName}] SET MULTI_USER;
    ";

            try
            {
                // Se conecta a la base de datos 'master' y ejecuta el comando de liberación.
                using (var masterConn = new System.Data.SqlClient.SqlConnection(masterConnStr))
                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, masterConn))
                {
                    masterConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // Ignoramos errores al intentar liberar (por ejemplo, si la DB no está adjunta)
            }
        }




        // Asegúrate de tener: using System.Security.Cryptography; y using System.Text;
        private static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return string.Empty;
            }

            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as UserService);
        }

        public bool Equals(UserService other)
        {
            return !(other is null) &&
                   connectionString == other.connectionString &&
                   EqualityComparer<object>.Default.Equals(connection, other.connection);
        }

        public override int GetHashCode()
        {
            int hashCode = -1713393427;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(connectionString);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(connection);
            return hashCode;
        }

        public static bool operator ==(UserService left, UserService right)
        {
            return EqualityComparer<UserService>.Default.Equals(left, right);
        }

        public static bool operator !=(UserService left, UserService right)
        {
            return !(left == right);
        }
    }
}
