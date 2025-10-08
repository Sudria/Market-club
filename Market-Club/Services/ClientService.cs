using Market_Club.Class;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Market_Club.Services
{
    internal class ClientService
    {
        private static readonly string connectionString1 = ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;
        private string connectionString = connectionString1;
        public void CreateTable()
        {
            string query = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Clients')
            BEGIN
            CREATE TABLE Clients (
            Cuit INT PRIMARY KEY,
            Name NVARCHAR(100),
            Surname NVARCHAR(100),
            Tel NVARCHAR(20),
            Birthdate DATE,
            Address NVARCHAR(200),
            Email NVARCHAR(100)
            )
            END";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void InsertClient(ClientModel client)
        {
            string query = "INSERT INTO Clients (Cuit, Name, Surname, Tel, Gender, Birthdate, Address, Email) VALUES (@Cuit, @Name, @Surname, @Tel, @Birthdate, @Address, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", client.Cuit);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Tel", client.Tel);
                cmd.Parameters.AddWithValue("@Birthdate", client.Birthdate);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Email", client.Email);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ClientModel> ShowClients()
        {
            var clients = new List<ClientModel>();
            string query = "SELECT * FROM Clients";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new ClientModel
                        {
                            Cuit = reader.GetInt32(reader.GetOrdinal("Cuit")),
                            Name = reader["Name"]?.ToString(),
                            Surname = reader["Surname"]?.ToString(),
                            Tel = reader["Tel"]?.ToString(),
                            Birthdate = reader["Birthdate"]?.ToString(),
                            Address = reader["Address"]?.ToString(),
                            Email = reader["Email"]?.ToString()
                        });
                    }
                }
            }

            return clients;
        }

        public bool DeleteClient(int cuit)
        {
            string query = "DELETE FROM Clients WHERE Cuit = @Cuit";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", cuit);
                conexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public ClientModel ShowClientByCuit(int cuit)
        {
            string query = "SELECT * FROM Clients WHERE Cuit = @Cuit";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", cuit);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read() ? new ClientModel
                {
                    Cuit = reader.GetInt32(reader.GetOrdinal("Cuit")),
                    Name = reader["Name"]?.ToString(),
                    Surname = reader["Surname"]?.ToString(),
                    Tel = reader["Tel"]?.ToString(),
                    Birthdate = reader["Birthdate"]?.ToString(),
                    Address = reader["Address"]?.ToString(),
                    Email = reader["Email"]?.ToString()
                } : null;
            }
        }


        public void UpdateClient(ClientModel client)
        {
            string query = @"UPDATE Clients
                     SET Name = @Name,
                         Surname = @Surname,
                         Tel = @Tel,
                         Birthdate = @Birthdate,
                         Address = @Address,
                         Email = @Email
                     WHERE Cuit = @Cuit"; 

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", client.Cuit);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Tel", client.Tel);
                cmd.Parameters.AddWithValue("@Birthdate", client.Birthdate);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Email", client.Email);

                conexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }
    }
}
