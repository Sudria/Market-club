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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblCuit = new Label();
            this.txtCuit = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblTelefono = new Label();
            this.txtTelefono = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblDireccion = new Label();
            this.txtDireccion = new TextBox();
            this.lblFechaNac = new Label();
            this.dtpFechaNac = new DateTimePicker();
            this.btnAgregar = new Button();
            this.dgvClientes = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Gestión de Clientes";
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(250, 10);
            this.lblTitulo.AutoSize = true;

            // 
            // lblCuit
            // 
            this.lblCuit.Text = "CUIT:";
            this.lblCuit.Location = new System.Drawing.Point(30, 60);
            this.txtCuit.Location = new System.Drawing.Point(120, 60);
            this.txtCuit.Width = 150;

            // 
            // lblNombre
            // 
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(30, 100);
            this.txtNombre.Location = new System.Drawing.Point(120, 100);
            this.txtNombre.Width = 150;

            // 
            // lblApellido
            // 
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new System.Drawing.Point(30, 140);
            this.txtApellido.Location = new System.Drawing.Point(120, 140);
            this.txtApellido.Width = 150;

            // 
            // lblTelefono
            // 
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Location = new System.Drawing.Point(30, 180);
            this.txtTelefono.Location = new System.Drawing.Point(120, 180);
            this.txtTelefono.Width = 150;

            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 220);
            this.txtEmail.Location = new System.Drawing.Point(120, 220);
            this.txtEmail.Width = 200;

            // 
            // lblDireccion
            // 
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Location = new System.Drawing.Point(30, 260);
            this.txtDireccion.Location = new System.Drawing.Point(120, 260);
            this.txtDireccion.Width = 250;

            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            this.lblFechaNac.Location = new System.Drawing.Point(30, 300);
            this.dtpFechaNac.Location = new System.Drawing.Point(160, 300);
            this.dtpFechaNac.Width = 150;

            // 
            // Botones
            // 
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(30, 350);

            // 
            // dgvClientes
            // 
            this.dgvClientes.Location = new System.Drawing.Point(30, 400);
            this.dgvClientes.Size = new System.Drawing.Size(600, 200);
            this.dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.Add("Cuit", "CUIT");
            this.dgvClientes.Columns.Add("Nombre", "Nombre");
            this.dgvClientes.Columns.Add("Apellido", "Apellido");
            this.dgvClientes.Columns.Add("Telefono", "Teléfono");
            this.dgvClientes.Columns.Add("Email", "Email");
            this.dgvClientes.Columns.Add("Direccion", "Dirección");
            this.dgvClientes.Columns.Add("FechaNac", "Fecha de Nacimiento");

            // 
            // ClientesForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnAgregar);

            this.Controls.Add(this.dgvClientes);
            this.Text = "Clientes";

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
