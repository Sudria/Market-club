using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms
{
    public partial class EliminarClientes : Form
    {
        public EliminarClientes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblCuit = new Label();
            this.txtCuit = new TextBox();
            this.btnBuscar = new Button();
            this.dgvCliente = new DataGridView();
            this.btnEliminar = new Button();
            this.btnSalir = new Button();

            ((System.ComponentModel.ISupportInitialize)this.dgvCliente).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Eliminar Cliente";
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(200, 10);
            this.lblTitulo.AutoSize = true;

            // 
            // lblCuit
            // 
            this.lblCuit.Text = "CUIT:";
            this.lblCuit.Location = new System.Drawing.Point(30, 60);
            this.txtCuit.Location = new System.Drawing.Point(120, 60);
            this.txtCuit.Width = 150;

            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(300, 60);

            // 
            // dgvCliente
            // 
            this.dgvCliente.Location = new System.Drawing.Point(30, 120);
            this.dgvCliente.Size = new System.Drawing.Size(500, 150);
            this.dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.Add("Cuit", "CUIT");
            this.dgvCliente.Columns.Add("Nombre", "Nombre");
            this.dgvCliente.Columns.Add("Apellido", "Apellido");
            this.dgvCliente.Columns.Add("Telefono", "Teléfono");
            this.dgvCliente.Columns.Add("Email", "Email");

            // 
            // Botones
            // 
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(150, 300);

            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(250, 300);

            // 
            // EliminarClienteForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Text = "Eliminar Cliente";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

   
    }
}

