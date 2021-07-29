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
    public partial class MainForm : Form
    {
        LinkedList<LoginEntry> logins = new LinkedList<LoginEntry>(); //to hold all accounts
        LinkedList<Flight> flights = new LinkedList<Flight>(); //to hold all flights
        ListOps listoperations = new ListOps(); //methods for updating lists
        LoginEntry entry;
        Point startpoint;

        public MainForm()
        {//startup form, first page user sees
            InitializeComponent();

            //hide login fields, click login button will reveal them
            CancelButton.Hide();
            UsernameBox.Hide();
            UsernameLabel.Hide();
            PasswordBox.Hide();
            PasswordLabel.Hide();

            //save location of login button
            startpoint = LoginButton.Location;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //go to sign up page, users can register accounts
            SignUpForm signupform = new SignUpForm(ref logins);
            signupform.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if login button hasn't been clicked yet
            //click to reveal login fields
            if (LoginButton.Location == startpoint)
            {
                LoginButton.Location = new Point(638, 78);
                CancelButton.Show();
                UsernameBox.Show();
                UsernameLabel.Show();
                PasswordBox.Show();
                PasswordLabel.Show();
                SignUpButton.Hide();
            }
            //user enters login information
            //search for their account
            else
            {
                entry.username = UsernameBox.Text;
                entry.password = PasswordBox.Text;

                listoperations.Search(ref entry, ref logins);
                label1.Text = entry.firstName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //if cancel button is click, hide login fields
            CancelButton.Hide();
            UsernameBox.Hide();
            UsernameLabel.Hide();
            PasswordBox.Hide();
            PasswordLabel.Hide();
            SignUpButton.Show();
            LoginButton.Location = startpoint;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
