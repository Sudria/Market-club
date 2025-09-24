using Market_Club.Class;
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
    internal class ClientController
    {
        private readonly ClientService _clientService;

        public ClientController()
        {
            _clientService = new ClientService();
        }

        public void CreateTable()
        {
            _clientService.CreateTable();
        }

        public bool InsertClient(ClientModel client)
        {
        
            if (!Validator.isValidText(client.Cuit.ToString(), "Cuit"))
            {
                return false;
            } if(client.Cuit.ToString().Length != 11)
            {
                MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Nombre
            if (!Validator.isValidText(client.Name, "Nombre"))
                return false;

            // Apellido
            if (!Validator.isValidText(client.Surname, "Apellido"))
                return false;

            // Teléfono
            if (!Validator.isValidText(client.Tel, "Telefono"))
                return false;

            // Fecha de nacimiento
            if (!Validator.isValidText(client.Birthdate, "Fecha de Nacimiento"))
                return false;

            // Dirección
            if (!Validator.isValidText(client.Address, "Dirección"))
                return false;

            // Email
            if (!Validator.isValidEmail(client.Email))
                return false;

            _clientService.InsertClient(client);

            return true;
        }

        public bool UpdateClient(ClientModel client)
        {
            if (!Validator.isValidNum(client.Cuit.ToString(), "Cuit"))
            {
                return false;
            }
            if (client.Cuit.ToString().Length != 11)
            {
                MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Nombre
            if (!Validator.isValidText(client.Name, "Nombre"))
                return false;

            // Apellido
            if (!Validator.isValidText(client.Surname, "Apellido"))
                return false;

            // Teléfono
            if (!Validator.isValidText(client.Tel, "Telefono"))
                return false;

            // Fecha de nacimiento
            if (!Validator.isValidText(client.Birthdate, "Fecha de Nacimiento"))
                return false;

            // Dirección
            if (!Validator.isValidText(client.Address, "Dirección"))
                return false;

            // Email
            if (!Validator.isValidEmail(client.Email))
                return false;

            _clientService.InsertClient(client);

            return true;
        }

        public ClientModel ShowClientByCuit(int cuit)
        {
             return _clientService.ShowClientByCuit(cuit);
        }

        public List<ClientModel> ShowClients()
        {
            return _clientService.ShowClients();
        }
    }
}
