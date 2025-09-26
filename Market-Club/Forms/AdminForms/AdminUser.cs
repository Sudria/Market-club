using Market_Club.Class;
using Market_Club.Controllers;
using Market_Club.Forms.CrudUser;
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

namespace Market_Club.Forms.CrudClient
{
    public partial class AdminUser : UserControl
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            userController.LoadUsers(dgvUsers);
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                UserController userController = new UserController();
                string user = Convert.ToString(dgvUsers.CurrentRow.Cells["Username"].Value);

                bool respuesta = MessageBox.Show("¿Está seguro que desea eliminar el usuario: " + user, "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                if (respuesta)
                {
                    int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["Id"].Value);
                    userController.DeleteUser(id);
                    userController.LoadUsers(dgvUsers);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "No se ha seleccionado ningún usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();


            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsers.SelectedRows[0];

                userModel.Id = Convert.ToInt32(fila.Cells["Id"].Value);
                userModel.RolId = Convert.ToInt32(fila.Cells["RolId"].Value);
                userModel.Name = fila.Cells["Name"].Value.ToString();
                userModel.Surname = fila.Cells["Surname"].Value.ToString();
                userModel.Username = fila.Cells["Username"].Value.ToString();
                userModel.Password = fila.Cells["Password"].Value.ToString();
                userModel.Email = fila.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
                return;
            }
            ModificarUsuario modificarUsuarioForm = new ModificarUsuario(userModel);
            modificarUsuarioForm.ShowDialog();
        }
    }
}
