using Market_Club.Controllers;
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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario(UserModel user)
        {
            InitializeComponent();
            txtUsername.Text = user.Username;
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            cmbRol.SelectedIndex  = user.RolId - 1;
            txtPassword.Text = user.Password;
            txtRepeatPass.Text = user.Password;

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool respuesta = MessageBox.Show("¿Está seguro que desea cancelar la modificacion?", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (respuesta)
            {
                this.Close();
            }
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();

            userModel.Name = txtName.Text;
            userModel.Surname = txtSurname.Text;
            userModel.Email = txtEmail.Text;
            userModel.Username = txtUsername.Text;

            if (cmbRol.Text.Contains("Admin"))
            {
                userModel.RolId = 1;
            }
            else if (cmbRol.Text.Contains("Supervisor"))
            {
                userModel.RolId = 2;
            }
            else if (cmbRol.Text.Contains("Vendedor"))
            {
                userModel.RolId = 3;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol válido.");
                return;
            }

            userModel.Password = txtPassword.Text;

            if (userModel.Password != txtRepeatPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                return;
            }

            UserController userController = new UserController();

            if (userController.AddUser(userModel))
            {
                this.Close();
            }
        }
    }
}
