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
    public partial class ModificarSubCat : Form
    {
        private string conexion;

        public ModificarSubCat()
        {
            InitializeComponent();
        }

        private void btnModificarSubCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "UPDATE SubCategorias SET NombreSubCategoria=@nombre, Categoria=@categoria WHERE IdSubCategoria=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreSubCat.Text);
                    cmd.Parameters.AddWithValue("@categoria", cboCategoria.Text);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtIdSubCat.Text));

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("✅ Subcategoría modificada.");
                    else
                        MessageBox.Show("⚠️ No se encontró la subcategoría.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar subcategoría: " + ex.Message);
            }
        }
    }

