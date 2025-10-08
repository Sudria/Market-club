using Market_Club.Class;
using Market_Club.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms.CrudClient
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente(ClientModel client)
        {
            InitializeComponent();

            txtCuit.Text = client.Cuit.ToString();
            txtApellido.Text = client.Surname;
            txtNombre.Text = client.Name;
            txtTel.Text = client.Tel;
            dtpFechaNac.Text = client.Birthdate;
            txtDireccion.Text = client.Address;
            txtEmail.Text = client.Email;
            txtTel.Text = client.Tel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool respuesta = MessageBox.Show("¿Está seguro que desea cancelar la modificacion?", "Cancelar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (respuesta)
            {
                this.Close();
            }
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            ClientModel client = new ClientModel();

            client.Cuit = int.Parse(txtCuit.Text);
            client.Address = txtDireccion.Text;
            client.Email = txtEmail.Text;
            client.Name = txtNombre.Text;
            client.Tel = txtTel.Text;
            client.Surname = txtApellido.Text;
            client.Birthdate = dtpFechaNac.Text;

            if (clientController.UpdateClient(client))
            {
                MessageBox.Show("Cliente modificado con exito");
            }
            else
            {
                return;
            }
        }
    }
}
