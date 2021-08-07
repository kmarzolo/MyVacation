using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVacation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Message.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //user enters login information
            //search for their account
            Variables.logins.VerifyAccount(UsernameBox.Text, PasswordBox.Text);

            //if found, let user know
            Message.Show();
            if (Variables.logins.GetLoginStatus())
            {
                Message.Text = "Login Successful, press \"Cancel\"";
            }
            //if not found, revert back to original
            if (!Variables.logins.GetLoginStatus())
            {
                Message.Text = "Login Failed";
                return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signupform = new SignUpForm();
            signupform.ShowDialog();
        }
    }
}
