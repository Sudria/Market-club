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

namespace Market_Club.Forms.SupervisorForm
{
    public partial class SupervisorPanel : UserControl
    {
        public SupervisorPanel()
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

        private void ButtonAboutMe_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(new AboutMe());
        }

        private void ButtonGraphics_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(new SupervisorGraphic());
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;

            parentForm.contentPanel.Controls.Clear();
            parentForm.contentPanel.Controls.Add(new SupervisorReports());
        }
    }
}
