namespace Market_Club.Forms.AdminForms
{
    partial class AdminReport
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cbConsult = new System.Windows.Forms.ComboBox();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.btnNewReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(389, 122);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 31;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(633, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // cbConsult
            // 
            this.cbConsult.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbConsult.FormattingEnabled = true;
            this.cbConsult.Items.AddRange(new object[] {
            "Ventas totales",
            "Ventas por producto",
            "Ventas por categoría",
            "Ventas por vendedor",
            "Ventas por cliente"});
            this.cbConsult.Location = new System.Drawing.Point(32, 100);
            this.cbConsult.Name = "cbConsult";
            this.cbConsult.Size = new System.Drawing.Size(255, 37);
            this.cbConsult.TabIndex = 29;
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReport.FlatAppearance.BorderSize = 0;
            this.btnDeleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReport.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReport.Location = new System.Drawing.Point(1016, 118);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Size = new System.Drawing.Size(102, 26);
            this.btnDeleteReport.TabIndex = 28;
            this.btnDeleteReport.Text = "Eliminar";
            this.btnDeleteReport.UseVisualStyleBackColor = false;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // btnNewReport
            // 
            this.btnNewReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewReport.FlatAppearance.BorderSize = 0;
            this.btnNewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReport.ForeColor = System.Drawing.Color.White;
            this.btnNewReport.Location = new System.Drawing.Point(904, 118);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(102, 26);
            this.btnNewReport.TabIndex = 27;
            this.btnNewReport.Text = "Nuevo";
            this.btnNewReport.UseVisualStyleBackColor = false;
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Consultar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 523);
            this.dataGridView1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reportes";
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.cbConsult);
            this.Controls.Add(this.btnDeleteReport);
            this.Controls.Add(this.btnNewReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "AdminReport";
            this.Size = new System.Drawing.Size(1146, 694);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cbConsult;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Button btnNewReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}
