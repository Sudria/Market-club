using Market_Club.Forms.CrudSell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms.SellerForms
{
    public partial class SellerSale : UserControl
    {
        public SellerSale()
        {
            InitializeComponent();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (dtpHasta.MaxDate <= DateTime.Today)
            {
                if (dtpDesde.Value <= dtpHasta.Value)
                {
                    // En caso de que pase las validaciones
                    MessageBox.Show("Reporte generado exitosamente.", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("La fecha 'Hasta' no puede ser mayor a la fecha actual.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNewSell_Click(object sender, EventArgs e)
        {
            AgregarVenta agregarVenta = new AgregarVenta();
            agregarVenta.ShowDialog();
        }
    }
}
