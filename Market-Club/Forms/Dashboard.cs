using Market_Club.Forms.AdminForms;
using Market_Club.Forms.SellerForms;
using Market_Club.Forms.SupervisorForm;
using Market_Club.Models;
using MarketClub;
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
    public partial class Dashboard : Form
    {


        public UserModel user = new UserModel();

        public Dashboard(UserModel LoggedUsser)
        {
            InitializeComponent();
            user = LoggedUsser;
            CargarPanelSegunRol();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

            DashboardPanel.Controls.Clear(); 
            RolLabel.Text = "Admin";
            AdminPanel adminPanel = new AdminPanel();
            DashboardPanel.Controls.Add(adminPanel);
            ContentPanel.Controls.Clear();
            AdminHome adminHome = new AdminHome();
            ContentPanel.Controls.Add(adminHome);

        }

        private void SupervisorButton_Click(object sender, EventArgs e)
        {
            DashboardPanel.Controls.Clear();
            RolLabel.Text = "Supervisor";
            SupervisorPanel supervisorPanel = new SupervisorPanel();
            DashboardPanel.Controls.Add(supervisorPanel);
            ContentPanel.Controls.Clear();
        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            DashboardPanel.Controls.Clear();
            RolLabel.Text = "Vendedor";
            SellerPanel sellerDashboard1 = new SellerPanel();
            DashboardPanel.Controls.Add(sellerDashboard1);
            ContentPanel.Controls.Clear();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarPanelSegunRol()
        {
            DashboardPanel.Controls.Clear();
            ContentPanel.Controls.Clear();

            switch (user.RolId)
            {
                case 1: // Admin
                    RolLabel.Text = "Admin";
                    AdminPanel adminPanel1 = new AdminPanel();
                    DashboardPanel.Controls.Add(adminPanel1);
                    AdminHome adminHome = new AdminHome();
                    ContentPanel.Controls.Add(adminHome);
                    break;

                case 2: // Supervisor
                    RolLabel.Text = "Supervisor";
                    break;

                case 3: // Vendedor
                    RolLabel.Text = "Vendedor";
                    SellerPanel sellerDashboard1 = new SellerPanel();
                    DashboardPanel.Controls.Add(sellerDashboard1);
                    break;

                default:
                    RolLabel.Text = "Desconocido";
                    break;
            }
        }
    }
     
}
