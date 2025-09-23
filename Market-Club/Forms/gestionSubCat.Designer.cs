namespace Market_Club.Forms
{
    partial class gestionSubCat
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
            this.lblSubCat = new System.Windows.Forms.Label();
            this.lblSubCateg = new System.Windows.Forms.Label();
            this.txtIdSubCat = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNombreSubCat = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarSubCat = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubCat
            // 
            this.lblSubCat.AutoSize = true;
            this.lblSubCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCat.Location = new System.Drawing.Point(318, 51);
            this.lblSubCat.Name = "lblSubCat";
            this.lblSubCat.Size = new System.Drawing.Size(306, 24);
            this.lblSubCat.TabIndex = 1;
            this.lblSubCat.Text = "GESTION DE SUB CATEGORIA";
            this.lblSubCat.Click += new System.EventHandler(this.lblSubCat_Click);
            // 
            // lblSubCateg
            // 
            this.lblSubCateg.AutoSize = true;
            this.lblSubCateg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSubCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCateg.Location = new System.Drawing.Point(41, 136);
            this.lblSubCateg.Name = "lblSubCateg";
            this.lblSubCateg.Size = new System.Drawing.Size(144, 16);
            this.lblSubCateg.TabIndex = 2;
            this.lblSubCateg.Text = "ID SUBCATEGORIA";
            // 
            // txtIdSubCat
            // 
            this.txtIdSubCat.Location = new System.Drawing.Point(272, 136);
            this.txtIdSubCat.Name = "txtIdSubCat";
            this.txtIdSubCat.Size = new System.Drawing.Size(100, 20);
            this.txtIdSubCat.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(41, 191);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(219, 16);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "NOMBRE DE SUBCATEGORIA";
            // 
            // txtNombreSubCat
            // 
            this.txtNombreSubCat.Location = new System.Drawing.Point(272, 190);
            this.txtNombreSubCat.Name = "txtNombreSubCat";
            this.txtNombreSubCat.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSubCat.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(41, 255);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(94, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(272, 255);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // btnAgregarSubCat
            // 
            this.btnAgregarSubCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSubCat.Location = new System.Drawing.Point(706, 93);
            this.btnAgregarSubCat.Name = "btnAgregarSubCat";
            this.btnAgregarSubCat.Size = new System.Drawing.Size(166, 63);
            this.btnAgregarSubCat.TabIndex = 8;
            this.btnAgregarSubCat.Text = "AGREGAR SUB CATEGORIA";
            this.btnAgregarSubCat.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(734, 178);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Market_Club.Properties.Resources.fondo_claro;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gestionSubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarSubCat);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNombreSubCat);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtIdSubCat);
            this.Controls.Add(this.lblSubCateg);
            this.Controls.Add(this.lblSubCat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gestionSubCat";
            this.Text = "gestionSubCat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubCat;
        private System.Windows.Forms.Label lblSubCateg;
        private System.Windows.Forms.TextBox txtIdSubCat;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombreSubCat;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregarSubCat;
        private System.Windows.Forms.Button btnSalir;
    }
}