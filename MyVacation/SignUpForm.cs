﻿using System;
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
    public partial class SignUpForm : Form
    {
        LinkedList<LoginEntry> temp = new LinkedList<LoginEntry>();
        ListOps listoperations = new ListOps();
        LoginEntry entry;

        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(ref LinkedList<LoginEntry> logins)
        {
            //share linked list
            InitializeComponent();
            temp = logins;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            //close page
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            //user enters information to register
            //check if password and confirm password match
            int comparison = String.Compare(PasswordBox.Text, ConfirmBox.Text);
            if (comparison != 0)
            {
                Message.Text = "Password and Confirmation must be the same";
                return;
            }

            Message.ForeColor = Color.Red;
            Message.Text = " ";

            //user enters information
            entry.firstName = FirstNameBox.Text;
            entry.lastName = LastNameBox.Text;
            entry.username = UsernameBox.Text;
            entry.password = PasswordBox.Text;
            
            //check if username already exists
            if (listoperations.Search(ref entry, ref temp))
            {
                Message.Text = "Username already exists";
                return;
            }

            //tests passed, add user
            temp.AddLast(entry);
            Message.ForeColor = Color.Black;
            Message.Text = "Sign up Successful, Press Close";
        }
    }
}
