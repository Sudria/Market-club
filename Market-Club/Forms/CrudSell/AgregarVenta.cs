using Market_Club.Forms.CrudClient;
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

namespace Market_Club.Forms.CrudSell
{
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool respuesta = MessageBox.Show("¿Está seguro que desea cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (respuesta)
            {
                this.Close();
            }
            return;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(Validator.isValidText(cbProducto.Text, "Producto"))
            {
                if(numCantidad.Value > 0)
                {
                    // Lógica para agregar el producto a la venta
                    MessageBox.Show("Producto agregado a la venta.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              MessageBox.Show("La cantidad debe ser mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.isValidNum(cbCuits.Text,"CUIT"))
            {
                if(dgvProductos.Rows.Count > 0)
                {
                    // Lógica para guardar la venta
                MessageBox.Show("Venta registrada con exito.", "Venta Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();
        }
    }
}
