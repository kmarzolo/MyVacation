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
    public partial class PurchaseForm : Form
    {
        Flight flight;

        public PurchaseForm()
        {
            InitializeComponent();
            Message.Hide();
            SignOutButton.Hide();

            flight = Variables.flights.GetFlight();

            //if logged in, display user information
            if (Variables.logins.GetLoginStatus())
            {
                UserLabel.Text = "User: " + Variables.logins.GetLoginAccount().firstName;
                EmailBox.Text = Variables.logins.GetLoginAccount().email;
                CardNumber.Text = Variables.logins.GetLoginAccount().cardNumber;
                ExpirationDate.Text = Variables.logins.GetLoginAccount().expirationDate;
                CVV.Text = Variables.logins.GetLoginAccount().cvv;

                //hide login and sign up buttons
                LoginButton.Hide();
                SignUpButton.Hide();
                SignOutButton.Show();
            }

            FromLocationLabel.Text = "From: " + flight.startlocation;
            EndLocationLabel.Text = "To: " + flight.endlocation;
            DateRangeLabel.Text = flight.departdate + '-' + flight.returndate;
            PriceLabel.Text = flight.price.ToString();
        }

        public PurchaseForm(string user, string location)
        {
            InitializeComponent();
            UserLabel.Text = "User: " + user;
            EndLocationLabel.Text = "To: " + location;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string cardNumber = CardNumber.Text;
            string expirationDate = ExpirationDate.Text;
            string cvv = CVV.Text;
            Message.Hide();

            //check if user left textboxes empty
            if(email == "")
            {
                Message.Show();
                Message.Text = "Please enter email addresses";
                return;
            }
            if(cardNumber.Contains("  "))
            {
                Message.Show();
                Message.Text = "Please enter in valid credit card";
                return;
            }
            if (expirationDate.Contains("  "))
            {
                Message.Show();
                Message.Text = "Please enter in valid credit card";
                return;
            }
            if (cvv.Contains("  "))
            {
                Message.Show();
                Message.Text = "Please enter in valid credit card";
                return;
            }

            //check if card number is valid
            if (!Variables.validation.ValidateCardNumber(cardNumber))
            {
                Message.Show();
                Message.Text = "Card Number is Invalid";
                return;
            }

            //check if expiration date is valid
            if (!Variables.validation.ValidateExpirationDate(expirationDate))
            {
                Message.Show();
                Message.Text = "Expiration Date Invalid";
                return;
            }

            if (Variables.logins.GetLoginStatus())
            {
                Variables.logins.SetFlight(flight);
            }

            Variables.logins.SetFlight(flight);

            Message.Show();
            Message.Text = "Payment Processed Successfully, Confirmation Email Sent";

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();

            //check if user logged in
            if (Variables.logins.GetLoginStatus())
            {
                UserLabel.Text = "User: " + Variables.logins.GetLoginAccount().firstName;
                EmailBox.Text = Variables.logins.GetLoginAccount().email;
                CardNumber.Text = Variables.logins.GetLoginAccount().cardNumber;
                ExpirationDate.Text = Variables.logins.GetLoginAccount().expirationDate;
                CVV.Text = Variables.logins.GetLoginAccount().cvv;

                //hide login and signup buttons
                LoginButton.Hide();
                SignUpButton.Hide();
                SignOutButton.Show();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signupform = new SignUpForm();
            signupform.ShowDialog();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            LoginButton.Show();
            SignUpButton.Show();
            SignOutButton.Hide();
            EmailBox.Text = "";
            CardNumber.Text = "";
            ExpirationDate.Text = "";
            CVV.Text = "";
            UserLabel.Text = "User: Guest";
        }
    }
}
