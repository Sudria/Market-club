using Market_Club.Class;
using Market_Club.Controllers;
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
        ClientController clientController = new ClientController();

        public SellerClient()
        {
            InitializeComponent();
            dgvClients.DataSource = clientController.ShowClients();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarClienteForm = new AgregarCliente();
            agregarClienteForm.ShowDialog();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ClientModel clientModel = new ClientModel();

            foreach (DataGridViewRow row in dgvClients.SelectedRows)
            {
                clientModel.Cuit = Convert.ToInt32(row.Cells["Cuit"].Value);
                clientModel.Name = row.Cells["Name"].Value.ToString();
                clientModel.Surname = row.Cells["Surname"].Value.ToString();
                clientModel.Tel = row.Cells["Tel"].Value.ToString();
                clientModel.Birthdate = row.Cells["Birthdate"].Value.ToString();
                clientModel.Address = row.Cells["Address"].Value.ToString();
                clientModel.Email = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            dgvClients.DataSource = clientController.ShowClients();
        }
    }
}
