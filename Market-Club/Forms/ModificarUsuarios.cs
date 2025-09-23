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
    public partial class ModificarUsuarios : Form
    {
        private string conexion;
        private object txtApellido;
        private object txtEmail;
        private object txtUsername;
        private object cboRol;
        private object txtPassword;

        public ModificarUsuarios()
        {
            InitializeComponent();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "UPDATE Usuarios SET Nombre=@nombre, Apellido=@apellido, Email=@email, Username=@username, Rol=@rol, Contraseña=@pass WHERE Username=@username";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@rol", cboRol.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("✅ Usuario modificado.");
                    else
                        MessageBox.Show("⚠️ No se encontró el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }
    }
}

