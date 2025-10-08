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
    public partial class gestionSubCat : Form
    {
        private string conexion;
        private object cboCategoria;

        public gestionSubCat()
        {
            InitializeComponent();
        }

        private void btnAgregarSubCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO SubCategorias (NombreSubCategoria, Categoria) VALUES (@nombre, @categoria)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreSubCat.Text);
                    cmd.Parameters.AddWithValue("@categoria", cboCategoria.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Subcategoría agregada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar subcategoría: " + ex.Message);
            }
        }
    }

