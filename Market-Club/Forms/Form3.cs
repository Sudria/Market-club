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
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=TuBase;Integrated Security=True;";

        public Form3()
        {
            InitializeComponent();
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Categoria FROM Productos", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategoria.Items.Add(reader["Categoria"].ToString());
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Productos SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock, StockMinimo=@StockMinimo, Categoria=@Categoria WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtid.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@StockMinimo", int.Parse(txtStockMinimo.Text));
                    cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Producto actualizado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
