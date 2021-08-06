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
        //declared variables
        bool loginFound = false;
        ListOps listoperations = new ListOps();
        LinkedList<LoginEntry> logins = new LinkedList<LoginEntry>();
        LoginEntry login;
        public LoginEntry returnLogin;

        public LoginForm()
        {
            InitializeComponent();
            Message.Hide();
        }
        public LoginForm(ref LinkedList<LoginEntry> log)
        {
            InitializeComponent();
            logins = log;
            Message.Hide();
        }

        public bool GetLoginStatus()
        {
            return loginFound;
        }

        public LoginEntry GetLogin()
        {
            return login;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //user enters login information
            //search for their account
            login.username = UsernameBox.Text;
            login.password = PasswordBox.Text;

            //search for account
            loginFound = listoperations.Verify(ref login, ref logins);

            //if found, let user know
            Message.Show();
            if (loginFound)
            {
                Message.Text = "Login Successful, press \"Cancel\"";
            }
            //if not found, revert back to original
            if (!loginFound)
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
            SignUpForm signupform = new SignUpForm(ref logins);
            signupform.ShowDialog();
        }
    }
}
