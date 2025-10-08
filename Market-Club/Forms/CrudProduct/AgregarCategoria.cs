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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
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
           if(Validator.isValidText(txtName.Text,"Nombre de la categoria")){
                return;
            }
            return;
        }
    }
}
