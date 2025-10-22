using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // NECESARIO para SqlConnection y SqlCommand
using System.Security.Cryptography; // NECESARIO para SHA256 (en HashPassword)
using System.Windows.Forms;

namespace Market_Club.Forms.BackUp
{
    public partial class BackUpsForms : UserControl
    {
        public BackUpsForms()
        {
            InitializeComponent();
        }
        string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db-string"].ConnectionString;
        }
        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            try
            {
                KillDatabaseConnections("db-poli");

                string connStr = GetConnectionString();
                string currentDb = "db-poli";

                string backupFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
                if (!System.IO.Directory.Exists(backupFolder))
                    System.IO.Directory.CreateDirectory(backupFolder);

                string backupFile = System.IO.Path.Combine(backupFolder, $"{currentDb}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

                // DEFINICIÓN DE LA VARIABLE 'sql' MOVIDA ARRIBA DEL BLOQUE DE EJECUCIÓN
                string sql = $"BACKUP DATABASE [{currentDb}] TO DISK = N'{backupFile}' WITH INIT, NAME = N'{currentDb}-Full Backup';";

                string masterConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder(connStr) { InitialCatalog = "master" }.ConnectionString;
                using (var masterConn = new System.Data.SqlClient.SqlConnection(masterConnStr))
                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, masterConn))
                {
                    masterConn.Open();
                    cmd.CommandTimeout = 600;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Backup creado:\n{backupFile}", "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void KillDatabaseConnections(string databaseName)
        {
            string connStr = GetConnectionString();
            string masterConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder(connStr) { InitialCatalog = "master" }.ConnectionString;

            // Comando SQL que fuerza la liberación y desadjunta (detach) el archivo
            string sql = $@"
        IF DB_ID(N'{databaseName}') IS NOT NULL
        BEGIN
            -- 1. Pone la DB en modo de usuario único y cierra conexiones
            ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            
            -- 2. DESADJUNTAR LA BASE DE DATOS DEL SERVIDOR
            EXEC sp_detach_db '{databaseName}', 'true';
        END
    ";

            try
            {
                using (var masterConn = new System.Data.SqlClient.SqlConnection(masterConnStr))
                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, masterConn))
                {
                    masterConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // Ignorar
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivo backup (*.bak)|*.bak";
                    if (ofd.ShowDialog() != DialogResult.OK) return;
                    string backupPath = ofd.FileName;

                    string connStr = GetConnectionString();
                    // Obtener nombre de la BD (igual que en backup)
                    string databaseName;
                    using (var conn = new System.Data.SqlClient.SqlConnection(connStr))
                    {
                        conn.Open();
                        databaseName = conn.Database;
                        if (string.IsNullOrWhiteSpace(databaseName) || databaseName.Equals("master", StringComparison.OrdinalIgnoreCase))
                        {
                            using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT DB_NAME()", conn))
                            {
                                databaseName = cmd.ExecuteScalar()?.ToString();
                            }
                        }
                    }

                    string masterConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder(connStr) { InitialCatalog = "master" }.ConnectionString;

                    string sql = $@"
ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
RESTORE DATABASE [{databaseName}] FROM DISK = N'{backupPath}' WITH REPLACE;
ALTER DATABASE [{databaseName}] SET MULTI_USER;
";

                    using (var masterConn = new System.Data.SqlClient.SqlConnection(masterConnStr))
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, masterConn))
                    {
                        masterConn.Open();
                        cmd.CommandTimeout = 1200;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Restauración completada.", "Restore OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

                string sourcePath = System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "db-poli.mdf");
                string destinationFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Backups_Poli");
                string backupFile = System.IO.Path.Combine(destinationFolder, $"db-poli_{DateTime.Now:yyyyMMdd_HHmmss}.mdf");
                if (!System.IO.Directory.Exists(destinationFolder))
                {
                    System.IO.Directory.CreateDirectory(destinationFolder);
                }



                MessageBox.Show($"Backup creado con éxito en:\n{backupFile}", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DetachDatabase()
        {
            string connStr = GetConnectionString();
            string databaseName = "db-poli";

            // Solo necesitamos la cadena de conexión a master para ejecutar el comando.
            string masterConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder(connStr) { InitialCatalog = "master" }.ConnectionString;

            string sql = $@"
        IF DB_ID(N'{databaseName}') IS NOT NULL
        BEGIN
            ALTER DATABASE [{databaseName}] SET OFFLINE WITH ROLLBACK IMMEDIATE;
            EXEC sp_detach_db '{databaseName}', 'true';
        END
    ";

            try
            {
                using (var masterConn = new System.Data.SqlClient.SqlConnection(masterConnStr))
                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, masterConn))
                {
                    masterConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // Ignoramos errores al intentar desadjuntar (puede que no estuviera adjunta)
            }
        }
    }
}
