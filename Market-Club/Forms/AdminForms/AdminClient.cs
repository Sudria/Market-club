using Market_Club.Class;
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
            ClientModel clientModel = new ClientModel();


            if (dgvClients.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvClients.SelectedRows[0];

                clientModel.Cuit = Convert.ToInt32(fila.Cells["Cuit"].Value);
                clientModel.Name = fila.Cells["Name"].Value.ToString();
                clientModel.Surname = fila.Cells["Surname"].Value.ToString();
                clientModel.Tel = fila.Cells["Tel"].Value.ToString();
                clientModel.Birthdate = fila.Cells["Birthdate"].Value.ToString();
                clientModel.Address = fila.Cells["Address"].Value.ToString();
                clientModel.Email = fila.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
                return;
            }

            ModificarCliente modificarClienteForm = new ModificarCliente(clientModel);
            modificarClienteForm.ShowDialog();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            dgvClients.DataSource = clientController.ShowClients();

        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            ClientModel clientModel = new ClientModel();

            if (dgvClients.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvClients.SelectedRows[0];
                clientModel.Cuit = Convert.ToInt32(fila.Cells["Cuit"].Value);
                clientController.DeleteClient(clientModel.Cuit);
                MessageBox.Show("Cliente eliminado con exito");
                dgvClients.DataSource = clientController.ShowClients();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                return;
            }
        }
    }
}
