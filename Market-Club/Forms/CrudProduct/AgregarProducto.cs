using Market_Club.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms.CrudProduct
{
   

    public partial class AgregarProducto : Form
    {
        private object txtRutaImagen;
        private List<Producto> ListaProductos = new List<Producto>();
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool respuesta = MessageBox.Show("¿Está seguro que desea cancelar", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (respuesta)
            {
                this.Close();
            }
            return;
        }

      

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar imagen";
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.InitialDirectory = ""; // 📌 Carpeta inicial sugerida (podés cambiarla)

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(ofd.FileName);
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del PictureBox
                    string fileName = ofd.FileName;
                   // txtRutaImagen.Text = ofd.FileName;
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!Validator.isValidText(txtDescription.Text, "Descripción")) return;
            if (!Validator.isValidText(txtProductName.Text, "Nombre del producto")) return;
            if (string.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validator.isValidNum(txtStock.Text, "Cantidad")) return;
            if (!Validator.isValidNum(txtStockMin.Text, "Cantidad mínima")) return;
            if (!Validator.isValidImage(pbImage.Image, "Imagen")) return;

            // Crear objeto producto
            Producto nuevoProducto = new Producto
            {
                Nombre = txtProductName.Text,
                Descripcion = txtDescription.Text,
                Categoria = cbCategory.Text,
                Stock = int.Parse(txtStock.Text),
                StockMinimo = int.Parse(txtStockMin.Text),
                Imagen = pbImage.Image
            };

            // 🔹 Guardar producto en la lista o base de datos
            // Ejemplo temporal: simular guardado en memoria
            ListaProductos.Add(nuevoProducto);

            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtProductName.Clear();
            txtDescription.Clear();
            txtStock.Clear();
            txtStockMin.Clear();
            cbCategory.SelectedIndex = -1;
            pbImage.Image = null;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
