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
    public partial class SignUpForm : Form
    {
        LoginEntry login;

        public SignUpForm()
        {
            InitializeComponent();
            NameFields.Show();
            CardInformation.Hide();
            SignUp.Hide();
            PreviousButton.Hide();
            Message.Hide();
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
                Message.Show();
                Message.ForeColor = Color.Red;
                Message.Text = "Password and Confirmation must be the same";
                return;
            }

            if (!(CheckEmptyFields()))
            {
                return;
            }

            //user enters information
            login.firstName = FirstNameBox.Text;
            login.lastName = LastNameBox.Text;
            login.username = UsernameBox.Text;
            login.password = PasswordBox.Text;
            login.email = EmailBox.Text;
            login.cardNumber = CardNumberBox.Text;
            login.expirationDate = ExpirationDateBox.Text;
            login.cvv = CVVBox.Text;

            if (!(login.cardNumber.Contains("  ")))
            {
                if (!Variables.validation.ValidateCardNumber(login.cardNumber))
                {
                    Message.Show();
                    Message.ForeColor = Color.Red;
                    Message.Text = "Card Number Not Valid";
                    return;
                }
            }

            if (!(login.expirationDate == "  /"))
            {
                if (!Variables.validation.ValidateExpirationDate(login.expirationDate))
                {
                    Message.Show();
                    Message.ForeColor = Color.Red;
                    Message.Text = "Expiration Date Not Valid";
                    return;
                }
            }

            //check if username already exists
            if (Variables.logins.SearchAccounts(login))
            {
                Message.Show();
                Message.ForeColor = Color.Red;
                Message.Text = "Username already exists";
                return;
            }

            //tests passed, add user
            Variables.logins.AddAccount(login);
            Message.Show();
            Message.ForeColor = Color.Black;
            Message.Text = "Sign up Successful, Press Close";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {//reveal card information
            NameFields.Hide();
            CardInformation.Show();
            SignUp.Show();
            NextButton.Hide();
            PreviousButton.Show();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {//reveal name panels
            NameFields.Show();
            CardInformation.Hide();
            SignUp.Hide();
            NextButton.Show();
            PreviousButton.Hide();
        }

        private bool CheckEmptyFields()
        {//check if user filled out fields
            if (FirstNameBox.Text == "")
            {
                Message.Show();
                Message.Text = "First Name cannot be empty";
                return false;
            }
            if (LastNameBox.Text == "")
            {
                Message.Show();
                Message.Text = "Last Name cannot be empty";
                return false;
            }
            if (UsernameBox.Text == "")
            {
                Message.Show();
                Message.Text = "Username cannot be empty";
                return false;
            }
            if (PasswordBox.Text == "")
            {
                Message.Show();
                Message.Text = "Password cannot be empty";
                return false;
            }
            if (ConfirmBox.Text == "")
            {
                Message.Show();
                Message.Text = "Confirm Password cannot be empty";
                return false;
            }
            if (EmailBox.Text == "")
            {
                Message.Show();
                Message.Text = "Email cannot be empty";
                return false;
            }

            return true;
        }
    }
}
