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
    public partial class EliminarSubCat : Form
    {
        public EliminarSubCat()
        {
            InitializeComponent();
        }

        private void btnEliminarSubCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "DELETE FROM SubCategorias WHERE IdSubCategoria=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtIdSubCat.Text));

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("🗑 Subcategoría eliminada.");
                    else
                        MessageBox.Show("⚠️ No existe la subcategoría.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar subcategoría: " + ex.Message);
            }
        }

