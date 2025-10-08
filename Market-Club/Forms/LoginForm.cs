using Market_Club;
using Market_Club.Controllers;
using Market_Club.Models;
using System;

using System.Windows.Forms;
namespace MarketClub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

       

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserModel userMod = new UserModel();
            UserController userController = new UserController();
            userMod = userController.Login(txtUsername.Text, txtPassword.Text);
            if (userMod == null) return;

            this.Hide();
            Dashboard dashboard = new Dashboard(userMod);
            dashboard.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
