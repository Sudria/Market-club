using Market_Club.Forms.CrudProduct;
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
    public partial class AdminProduct : UserControl
    {
        public AdminProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
        }
    }
}
