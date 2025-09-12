using Market_Club.Controllers;
using Market_Club.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
    
                
                
        }

        private void Pruebas2_Click(object sender, EventArgs e)
        {
            ClientService clientService = new ClientService();
            
            DataGrid.DataSource = clientService.ShowClients();

        }

  
    }
}
