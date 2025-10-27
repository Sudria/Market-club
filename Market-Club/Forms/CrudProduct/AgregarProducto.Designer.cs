using System;

namespace Market_Club.Forms.CrudProduct
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblUsern = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTalle = new System.Windows.Forms.Label();
            this.cbTalle = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(460, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 39);
            this.label3.TabIndex = 50;
            this.label3.Text = "NUEVO PRODUCTO";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(112, 638);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 32);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(689, 638);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(136, 32);
            this.btnAgregarProducto.TabIndex = 42;
            this.btnAgregarProducto.Text = "Guardar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(356, 193);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(179, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // lblUsern
            // 
            this.lblUsern.AutoSize = true;
            this.lblUsern.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsern.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsern.Location = new System.Drawing.Point(107, 194);
            this.lblUsern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsern.Name = "lblUsern";
            this.lblUsern.Size = new System.Drawing.Size(221, 23);
            this.lblUsern.TabIndex = 47;
            this.lblUsern.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(107, 304);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(109, 23);
            this.lblApellido.TabIndex = 45;
            this.lblApellido.Text = "CATEGORIA:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(356, 261);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(179, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(107, 262);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 23);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "DESCRIPCION: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "CANTIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(107, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "CANTIDAD MIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(108, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "PRECIO: ";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Otros",
            "Indumentaria",
            "Tecnologia",
            "Libreria",
            "Bazar"});
            this.cbCategory.Location = new System.Drawing.Point(356, 304);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(179, 24);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Text = "Otros";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(356, 345);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(179, 22);
            this.txtStock.TabIndex = 6;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(356, 382);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(179, 22);
            this.txtStockMin.TabIndex = 7;
            // 
            // pbImage
            // 
            this.pbImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbImage.InitialImage")));
            this.pbImage.Location = new System.Drawing.Point(900, 139);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(528, 446);
            this.pbImage.TabIndex = 61;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(689, 558);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(136, 27);
            this.btnImage.TabIndex = 62;
            this.btnImage.Text = "Imagen";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(108, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "ACTIVO:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(356, 460);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(107, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "MARCA:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 158);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(108, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "COD. DEL PRODUCTO:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(356, 422);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 22);
            this.textBox3.TabIndex = 8;
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTalle.Location = new System.Drawing.Point(8, 20);
            this.lblTalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(58, 23);
            this.lblTalle.TabIndex = 70;
            this.lblTalle.Text = "TALLE";
            this.lblTalle.Visible = false;
            // 
            // cbTalle
            // 
            this.cbTalle.FormattingEnabled = true;
            this.cbTalle.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cbTalle.Location = new System.Drawing.Point(155, 20);
            this.cbTalle.Margin = new System.Windows.Forms.Padding(4);
            this.cbTalle.Name = "cbTalle";
            this.cbTalle.Size = new System.Drawing.Size(160, 24);
            this.cbTalle.TabIndex = 71;
            this.cbTalle.Visible = false;
            this.cbTalle.SelectedIndexChanged += new System.EventHandler(this.cbTalle_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.SystemColors.Control;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblColor.Location = new System.Drawing.Point(8, 57);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(67, 23);
            this.lblColor.TabIndex = 72;
            this.lblColor.Text = "COLOR";
            this.lblColor.Visible = false;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "ROJO",
            "AZUL",
            "AMARILLO",
            "NEGRO",
            "BLANCO"});
            this.cbColor.Location = new System.Drawing.Point(155, 59);
            this.cbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(160, 24);
            this.cbColor.TabIndex = 73;
            this.cbColor.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblModelo.Location = new System.Drawing.Point(8, 21);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 23);
            this.lblModelo.TabIndex = 74;
            this.lblModelo.Text = "MODELO";
            this.lblModelo.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(155, 18);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(160, 22);
            this.txtModelo.TabIndex = 75;
            this.txtModelo.Visible = false;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaterial.Location = new System.Drawing.Point(8, 53);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(93, 23);
            this.lblMaterial.TabIndex = 78;
            this.lblMaterial.Text = "MATERIAL";
            this.lblMaterial.Visible = false;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(155, 53);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(160, 22);
            this.txtMaterial.TabIndex = 79;
            this.txtMaterial.Visible = false;
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.BackColor = System.Drawing.SystemColors.Control;
            this.lblUso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUso.Location = new System.Drawing.Point(8, 22);
            this.lblUso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(45, 23);
            this.lblUso.TabIndex = 80;
            this.lblUso.Text = "USO";
            this.lblUso.Visible = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.SystemColors.Control;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAutor.Location = new System.Drawing.Point(8, 27);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(67, 23);
            this.lblAutor.TabIndex = 82;
            this.lblAutor.Text = "AUTOR";
            this.lblAutor.Visible = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(155, 24);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(160, 22);
            this.txtAutor.TabIndex = 83;
            this.txtAutor.Visible = false;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.SystemColors.Control;
            this.lblEditorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEditorial.Location = new System.Drawing.Point(8, 60);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(96, 23);
            this.lblEditorial.TabIndex = 84;
            this.lblEditorial.Text = "EDITORIAL";
            this.lblEditorial.Visible = false;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(155, 60);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(160, 22);
            this.txtEditorial.TabIndex = 85;
            this.txtEditorial.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTalle);
            this.groupBox1.Controls.Add(this.cbTalle);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.cbUso);
            this.groupBox1.Controls.Add(this.txtEditorial);
            this.groupBox1.Controls.Add(this.lblUso);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Location = new System.Drawing.Point(568, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(324, 108);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // cbUso
            // 
            this.cbUso.FormattingEnabled = true;
            this.cbUso.Items.AddRange(new object[] {
            "COCINA",
            "LIMPIEZA",
            "DECORACION",
            "COMIDA"});
            this.cbUso.Location = new System.Drawing.Point(155, 21);
            this.cbUso.Margin = new System.Windows.Forms.Padding(4);
            this.cbUso.Name = "cbUso";
            this.cbUso.Size = new System.Drawing.Size(160, 24);
            this.cbUso.TabIndex = 81;
            this.cbUso.Visible = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblUsern);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Ocultar todos los campos específicos
        OcultarCamposCategoria();

        string categoria = cbCategory.SelectedItem.ToString();

            switch (categoria)
            {
                case "Indumentaria":
                    lblTalle.Visible = true;
                    cbTalle.Visible = true;
                    lblColor.Visible = true;
                    cbColor.Visible = true;
                    break;

                case "Tecnologia":
                    lblModelo.Visible = true;
                    txtModelo.Visible = true;
                    break;

                case "Libreria":
                    lblAutor.Visible = true;
                    txtAutor.Visible = true;
                    lblEditorial.Visible = true;
                    txtEditorial.Visible = true;
                    break;

                case "Bazar":
                    lblMaterial.Visible = true;
                    txtMaterial.Visible = true;
                    lblUso.Visible = true;
                    cbUso.Visible = true;
                    break;

                case "Otros":
                    break;
            }
        
        }
 private void OcultarCamposCategoria()
        {
            // Indumentaria
            lblTalle.Visible = false;
            cbTalle.Visible = false;
            lblColor.Visible = false;
            cbColor.Visible = false;

            // Tecnología
            lblModelo.Visible = false;
            txtModelo.Visible = false;

            // Librería
            lblAutor.Visible = false;
            txtAutor.Visible = false;
            lblEditorial.Visible = false;
            txtEditorial.Visible = false;

            // Bazar
            lblMaterial.Visible = false;
            txtMaterial.Visible = false;
            lblUso.Visible = false;
            cbUso.Visible = false;

            // Otros



        }
        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblUsern;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.ComboBox cbTalle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label lblUso;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUso;
    }
}