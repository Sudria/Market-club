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
    public partial class AltaProducto : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=TuBase;Integrated Security=True;";
        private object cboUnidadMedida;
        private object txtRutaImagen;
        private object picProducto;
        private object cboProveedor;
        private string conexion;

        public AltaProducto()
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
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO Productos (Nombre, Precio, Stock, UnidadMedida, Proveedor, Activo, Imagen) " +
                                   "VALUES (@nombre, @precio, @stock, @unidad, @proveedor, @activo, @imagen)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@unidad", cboUnidadMedida.Text);
                    cmd.Parameters.AddWithValue("@proveedor", cboProveedor.Text);
                    cmd.Parameters.AddWithValue("@activo", chkActivo.Checked ? 1 : 0);

                    // Imagen (guardar como arreglo de bytes en SQL)
                    byte[] imgData = null;
                    if (!string.IsNullOrEmpty(txtRutaImagen.Text))
                    {
                        imgData = System.IO.File.ReadAllBytes(txtRutaImagen.Text);
                    }
                    cmd.Parameters.AddWithValue("@imagen", (object)imgData ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Producto agregado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen.Text = ofd.FileName;  // guardo la ruta en un TextBox oculto
                picProducto.Image = Image.FromFile(ofd.FileName);  // muestro en un PictureBox
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

