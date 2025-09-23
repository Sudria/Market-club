using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms
{
    public partial class GestionUsuarioscs : Form
    {
        private string conexion;
        private object txtUsername;
        private object cboRol;

        public GestionUsuarioscs()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Username, Rol, Contraseña) " +
                                   "VALUES (@nombre, @apellido, @email, @username, @rol, @pass)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@rol", cboRol.Text);  // ComboBox con roles
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Usuario agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }
    }
