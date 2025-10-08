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

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
        }

        private void btnAgregarSubCategoria_Click(object sender, EventArgs e)
        {
            AgregarSubCategoria agregarSubCategoria = new AgregarSubCategoria();
            agregarSubCategoria.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar imagen";
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.InitialDirectory = @"C:\Users\Alejandrina\Desktop\Market-Club\Market-Club\icon"; // 📌 Carpeta inicial sugerida (podés cambiarla)

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
            if (Validator.isValidText(txtDescription.Text, "Descripcion") && Validator.isValidText(txtProductName.Text, "Nombre del producto") 
                && string.IsNullOrEmpty(cbCategory.Text)
                && Validator.isValidNum(txtStock.Text, "Cantidad") && Validator.isValidNum(txtStockMin.Text,"Cantidad minima") && Validator.isValidImage(pbImage.Image,"Imagen"))
            {
                return;
            }
            return;

        }

       
    }
}
