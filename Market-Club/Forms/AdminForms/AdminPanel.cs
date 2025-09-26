using Market_Club.Forms.AdminForms;
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

namespace Market_Club.Forms.CrudClient
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Form parentForm  = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
            
        }

        private void buttonAboutMe_Click(object sender, EventArgs e)
        {
                Dashboard parentForm = this.FindForm() as Dashboard;
         
                parentForm.contentPanel.Controls.Clear();
                parentForm.contentPanel.Controls.Add(new AboutMe());
            
        }

        private void AdminHome_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            AdminHome adminHome = new AdminHome();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminHome);
        }

        private void AdminProduct_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            AdminProduct adminProduct = new AdminProduct();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminProduct);
        }

        private void AdminUsers_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            AdminUser adminUsers = new AdminUser();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminUsers);
        }

        private void AdminClient_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            AdminClient adminClient = new AdminClient();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminClient);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AdminReport adminReports = new AdminReport();
            Dashboard parentForm = this.FindForm() as Dashboard;
            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminReports);

        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            AdminReport adminReports = new AdminReport();
            Dashboard parentForm = this.FindForm() as Dashboard;
            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminReports);
        }
    }
}
