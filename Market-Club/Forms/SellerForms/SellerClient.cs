using Market_Club.Forms.CrudClient;
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
    public partial class SellerClient : UserControl
    {
        public SellerClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarClienteForm = new AgregarCliente();
            agregarClienteForm.ShowDialog();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ModificarCliente agregarClienteForm = new ModificarCliente();
            agregarClienteForm.ShowDialog();
        }
    }
}
