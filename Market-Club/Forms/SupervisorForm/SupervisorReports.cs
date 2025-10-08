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

namespace Market_Club.Forms.SupervisorForm
{
    public partial class SupervisorReports : UserControl
    {
        public SupervisorReports()
        {
            InitializeComponent();
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            if (cbConsult.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una consulta.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpHasta.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Hasta: " + dtpHasta.Value.ToString() + "datatime: " + DateTime.Today);
                MessageBox.Show("La fecha 'Hasta' no puede ser mayor a la fecha actual.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpDesde.Value.Date > dtpHasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reporte generado exitosamente.",
                    "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleecionar un reporte para eliminarlo.", "Eliminar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
