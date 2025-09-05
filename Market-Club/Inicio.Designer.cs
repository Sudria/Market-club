namespace Market_Club
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prueba = new System.Windows.Forms.Button();
            this.Pruebas2 = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(294, 25);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 0;
            this.Prueba.Text = "Pruebas";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // Pruebas2
            // 
            this.Pruebas2.Location = new System.Drawing.Point(496, 25);
            this.Pruebas2.Name = "Pruebas2";
            this.Pruebas2.Size = new System.Drawing.Size(99, 23);
            this.Pruebas2.TabIndex = 1;
            this.Pruebas2.Text = "Pruebas 2";
            this.Pruebas2.UseVisualStyleBackColor = true;
            this.Pruebas2.Click += new System.EventHandler(this.Pruebas2_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(29, 198);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(759, 240);
            this.DataGrid.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Pruebas2);
            this.Controls.Add(this.Prueba);
            this.Name = "Inicio";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.Button Pruebas2;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}

