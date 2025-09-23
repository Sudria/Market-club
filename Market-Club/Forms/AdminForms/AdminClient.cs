using Market_Club.Controllers;
using System;
using System.Windows.Forms;

namespace Market_Club.Forms.CrudClient
{
    public partial class AdminClient : UserControl
    {
        public AdminClient()
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
            ModificarCliente modificarClienteForm = new ModificarCliente();
            modificarClienteForm.ShowDialog();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            dgvClients.DataSource = clientController.ShowClients();

        }
    }
}
