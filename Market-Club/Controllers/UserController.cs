using Market_Club.Models;
using Market_Club.Services;
using Market_Club.Utils;
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
            public bool AddUser(UserModel user)
            {
            // Username
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (user.Username.Length > 20)
            {
                MessageBox.Show("El nombre de usuario no puede tener más de 20 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Name
            if (!Validator.isValidText(user.Name, "Nombre"))
                return false;

            // Surname
            if (!Validator.isValidText(user.Surname, "Apellido"))
                return false;

            // Email
            if (!Validator.isValidEmail(user.Email))
                return false;

             // RolId
            if (user.RolId <= 0)
            {
                MessageBox.Show("Debe seleccionar un rol válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            else if (user.Password.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si llega aquí, todos los campos son válidos
            _userService.InsertUser(user);
            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
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
