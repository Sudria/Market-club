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

        public void AddClient(ClientModel Client)
        {
            _clientService.InsertClient(Client);
        }
    }
}
