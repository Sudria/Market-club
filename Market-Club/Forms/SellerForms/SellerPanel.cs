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
    }
}
