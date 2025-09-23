using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms
{
    public partial class AboutMe : UserControl
    {
        public AboutMe()
        {
            InitializeComponent();
            this.Load += MiUserControl_Load;

        }


        private string GetRolName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin";
                case 2:
                    return "Supervisor";
                case 3:
                    return "Seller";
                default:
                    return "Unknown Role";
            }
        }

        private void MiUserControl_Load(object sender, EventArgs e)
        {
            Dashboard parentForm = this.FindForm() as Dashboard;
            if (parentForm?.user != null)
            {
                labelRol.Text = GetRolName(parentForm.user.RolId);
                labelSurname.Text = parentForm.user.Surname;
                labelName.Text = parentForm.user.Name;
                labelUsername.Text = parentForm.user.Username;
                labelEmail.Text = parentForm.user.Email;
            }
        }
    }
}
