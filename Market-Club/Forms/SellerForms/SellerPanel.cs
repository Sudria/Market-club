using Market_Club.Forms.CrudClient;
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

namespace Market_Club.Forms.SellerForms
{
    public partial class SellerPanel : UserControl
    {
        public SellerPanel()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void SellerDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellSeller_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            SellerSale admin = new SellerSale();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(admin);
        }

        private void ProductSeller_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            SellerProduct admin = new SellerProduct();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(admin);
        }

        private void ClientSeller_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            SellerClient admin = new SellerClient();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(admin);
        }

        private void HomeSeller_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            SellerHome admin = new SellerHome();

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(admin);
        }

        private void ButtonAboutMe_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(new AboutMe());
        }
    }
}
