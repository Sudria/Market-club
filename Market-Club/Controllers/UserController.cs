using Market_Club.Models;
using Market_Club.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Controllers
{
        internal class UserController
        {
            private readonly UserService _userService;

            public UserController()
            {
                _userService = new UserService();
            }

            // Mostrar todos los usuarios en un DataGridView
            public void LoadUsers(DataGridView dgv)
            {
                dgv.DataSource = null;
                dgv.DataSource = _userService.ShowUsers();
            }

            // Insertar usuario nuevo
            public void AddUser(UserModel user)
            {
                _userService.InsertUser(user);
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Eliminar usuario por id
            public void DeleteUser(int id)
            {
                _userService.DeleteUser(id);
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Buscar usuario por id y llenar TextBox
            public UserModel GetUserById(int id)
            {
                return _userService.ShowUserById(id);
            }

            // Validar login
            public UserModel Login(string username, string password)
            {
                var user = _userService.PassWordCheck(username, password);
                if (user == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return user;
            }
        }
    }
