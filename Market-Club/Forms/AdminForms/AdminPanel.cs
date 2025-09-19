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

namespace Market_Club.Forms.AdminForms
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
            if (parentForm != null)
            {
                parentForm.contentPanel.Controls.Clear();
                parentForm.contentPanel.Controls.Add(new AboutMe());
            }
        }

        private void AdminHome_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            AdminPanel adminPanel = new AdminPanel();
            AdminHome adminHome = new AdminHome();

            parentForm.dashboardPanel.Controls.Clear();
            parentForm.dashboardPanel.Controls.Add(adminPanel);
            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(adminHome);
        }
    }
}
