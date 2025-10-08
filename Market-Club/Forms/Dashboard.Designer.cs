namespace Market_Club
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.SellerButton = new System.Windows.Forms.Button();
            this.SupervisorButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RolLabel = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.SellerButton);
            this.panel1.Controls.Add(this.SupervisorButton);
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RolLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 47);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.exitButton.Location = new System.Drawing.Point(1288, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 28);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SellerButton
            // 
            this.SellerButton.Location = new System.Drawing.Point(676, 13);
            this.SellerButton.Name = "SellerButton";
            this.SellerButton.Size = new System.Drawing.Size(75, 23);
            this.SellerButton.TabIndex = 4;
            this.SellerButton.Text = "Vendedor";
            this.SellerButton.UseVisualStyleBackColor = true;
            this.SellerButton.Click += new System.EventHandler(this.SellerButton_Click);
            // 
            // SupervisorButton
            // 
            this.SupervisorButton.Location = new System.Drawing.Point(534, 11);
            this.SupervisorButton.Name = "SupervisorButton";
            this.SupervisorButton.Size = new System.Drawing.Size(75, 23);
            this.SupervisorButton.TabIndex = 3;
            this.SupervisorButton.Text = "Supervisor";
            this.SupervisorButton.UseVisualStyleBackColor = true;
            this.SupervisorButton.Click += new System.EventHandler(this.SupervisorButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(392, 12);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(75, 23);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(222, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RolLabel.Location = new System.Drawing.Point(14, 9);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(40, 25);
            this.RolLabel.TabIndex = 0;
            this.RolLabel.Text = "Rol";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 47);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(215, 694);
            this.dashboardPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(215, 47);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1146, 694);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 741);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SellerButton;
        private System.Windows.Forms.Button SupervisorButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Panel contentPanel;
    }
}

