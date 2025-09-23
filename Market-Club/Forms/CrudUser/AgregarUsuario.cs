using Market_Club.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms.CrudUser
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();

            userModel.Name = txtNombre.Text;
            userModel.Surname = txtApellido.Text;
            userModel.Email = txtEmail.Text;
            userModel.Username = txtUsername.Text;
             userModel.RolId  = (int) int.Parse(cboRol);
            userModel.Password = txtPassword.Text;

            MessageBox.Show("✅ Usuario agregado correctamente.");
        }
    }
}
