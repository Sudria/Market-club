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
    public partial class EliminarUsuarios : Form
    {
        private object txtUsername;
        private string conexion;

        public EliminarUsuarios()
        {
            InitializeComponent();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "DELETE FROM Usuarios WHERE Username=@username";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("🗑 Usuario eliminado.");
                    else
                        MessageBox.Show("⚠️ No existe un usuario con ese Username.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
