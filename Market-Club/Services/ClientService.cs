using Market_Club.Class;
using System.Configuration;
using System.Data.SqlClient;

namespace Market_Club.Services
{
    internal class ClientService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;
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
            Gender NVARCHAR(10),
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
            string query = "INSERT INTO Clients (Cuit, Name, Surname, Tel, Gender, Birthdate, Address, Email) " +
                "VALUES (@Cuit, @Name, @Surname, @Tel, @Gender, @Birthdate, @Address, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", client.Cuit);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Tel", client.Tel);
                cmd.Parameters.AddWithValue("@Gender", client.Gender);
                cmd.Parameters.AddWithValue("@Birthdate", client.Birthdate);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Email", client.Email);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
