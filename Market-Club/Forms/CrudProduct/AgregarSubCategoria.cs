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
using System.Xml.Linq;

namespace Market_Club.Forms.CrudProduct
{
    public partial class AgregarSubCategoria : Form
    {
        public AgregarSubCategoria()
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoria.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (Validator.isValidText(txtSubCategory.Text, "Nombre de la sub-categoria"))
            {
                return;
            }
            return;
        }


    }
}
