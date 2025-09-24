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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

            if (clientController.InsertClient(client))
            {
                MessageBox.Show("Cliente agregado con exito");
            }
            else
            {
                return;
            }


            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool respuesta = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (respuesta)
            {
                this.Close();
            }
            return;
        }
    }
}
