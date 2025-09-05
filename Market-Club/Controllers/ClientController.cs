using Market_Club.Class;
using Market_Club.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void InsertClient(ClientModel client)
        {
            _clientService.InsertClient(client);
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
