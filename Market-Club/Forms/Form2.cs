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
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=TuBase;Integrated Security=True;";

        public Form2()
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

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            string nuevaCat = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nueva categoría:", "Añadir Categoría", "");
            if (!string.IsNullOrWhiteSpace(nuevaCat))
            {
                cmbCategoria.Items.Add(nuevaCat);
                cmbCategoria.SelectedItem = nuevaCat;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Productos (Nombre, Precio, Stock, StockMinimo, Categoria) VALUES (@Nombre, @Precio, @Stock, @StockMinimo, @Categoria)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@StockMinimo", int.Parse(txtStockMinimo.Text));
                    cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Producto agregado con éxito");
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

