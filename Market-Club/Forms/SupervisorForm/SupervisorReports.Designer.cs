namespace Market_Club.Forms.SupervisorForm
{
    partial class SupervisorReports
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxConsult = new System.Windows.Forms.ComboBox();
            this.labelOp1 = new System.Windows.Forms.Label();
            this.labelOp2 = new System.Windows.Forms.Label();
            this.comboBoxOp1 = new System.Windows.Forms.ComboBox();
            this.comboBoxOp2 = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.comboBoxOp2);
            this.panel3.Controls.Add(this.comboBoxOp1);
            this.panel3.Controls.Add(this.labelOp2);
            this.panel3.Controls.Add(this.labelOp1);
            this.panel3.Controls.Add(this.comboBoxConsult);
            this.panel3.Controls.Add(this.btnDeleteClient);
            this.panel3.Controls.Add(this.btnAddClient);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1146, 694);
            this.panel3.TabIndex = 6;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(1010, 105);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(102, 26);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Eliminar";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(898, 105);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(102, 26);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Nuevo";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1086, 523);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reportes";
            // 
            // comboBoxConsult
            // 
            this.comboBoxConsult.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxConsult.FormattingEnabled = true;
            this.comboBoxConsult.Location = new System.Drawing.Point(26, 87);
            this.comboBoxConsult.Name = "comboBoxConsult";
            this.comboBoxConsult.Size = new System.Drawing.Size(186, 37);
            this.comboBoxConsult.TabIndex = 8;
            // 
            // labelOp1
            // 
            this.labelOp1.AutoSize = true;
            this.labelOp1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp1.Location = new System.Drawing.Point(296, 65);
            this.labelOp1.Name = "labelOp1";
            this.labelOp1.Size = new System.Drawing.Size(0, 19);
            this.labelOp1.TabIndex = 10;
            // 
            // labelOp2
            // 
            this.labelOp2.AutoSize = true;
            this.labelOp2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp2.Location = new System.Drawing.Point(565, 65);
            this.labelOp2.Name = "labelOp2";
            this.labelOp2.Size = new System.Drawing.Size(0, 19);
            this.labelOp2.TabIndex = 11;
            // 
            // comboBoxOp1
            // 
            this.comboBoxOp1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxOp1.FormattingEnabled = true;
            this.comboBoxOp1.Location = new System.Drawing.Point(300, 87);
            this.comboBoxOp1.Name = "comboBoxOp1";
            this.comboBoxOp1.Size = new System.Drawing.Size(186, 37);
            this.comboBoxOp1.TabIndex = 12;
            this.comboBoxOp1.Visible = false;
            // 
            // comboBoxOp2
            // 
            this.comboBoxOp2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxOp2.FormattingEnabled = true;
            this.comboBoxOp2.Location = new System.Drawing.Point(571, 87);
            this.comboBoxOp2.Name = "comboBoxOp2";
            this.comboBoxOp2.Size = new System.Drawing.Size(186, 37);
            this.comboBoxOp2.TabIndex = 13;
            this.comboBoxOp2.Visible = false;
            // 
            // SupervisorReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "SupervisorReports";
            this.Size = new System.Drawing.Size(1146, 694);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxConsult;
        private System.Windows.Forms.Label labelOp2;
        private System.Windows.Forms.Label labelOp1;
        private System.Windows.Forms.ComboBox comboBoxOp1;
        private System.Windows.Forms.ComboBox comboBoxOp2;
    }
}
