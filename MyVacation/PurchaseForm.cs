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
        public PurchaseForm()
        {
            InitializeComponent();
        }

        public PurchaseForm(string location)
        {
            InitializeComponent();
            Message.Hide();

            //if logged in, display user information
            if (Variables.logins.GetLoginStatus())
            {
                UserLabel.Text = "User: " + Variables.logins.GetLoginAccount().firstName;
                EmailBox.Text = Variables.logins.GetLoginAccount().email;
                CardNumber.Text = Variables.logins.GetLoginAccount().cardNumber;
                ExpirationDate.Text = Variables.logins.GetLoginAccount().expirationDate;
                CVV.Text = Variables.logins.GetLoginAccount().cvv;
            }

            LocationLabel.Text = "To: " + location;
        }

        public PurchaseForm(string user, string location)
        {
            InitializeComponent();
            UserLabel.Text = "User: " + user;
            LocationLabel.Text = "To: " + location;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string cardNumber = CardNumber.Text;
            string expirationDate = ExpirationDate.Text;
            string cvv = CVV.Text;
            Message.Hide();

            if(!(ValidateCardNumber(cardNumber)))
            {
                Message.Show();
                Message.Text = "Card Number is Invalid";
                return;
            }

            if(!(ValidateExpirationDate(expirationDate)))
            {
                Message.Show();
                Message.Text = "Expiration Date Invalid";
                return;
            }

            Message.Show();
            Message.Text = "Payment Processed Successfully";

        }

        private bool ValidateCardNumber(string cardNumber)
        {
            int[] numbers = new int[cardNumber.Length - 3];
            if ((cardNumber.Length > 19) || (cardNumber.Length < 15))
            {
                return false;
            }

            //convert strings to integer
            for (int i = 0, j = 0; i < cardNumber.Length; i++)
            {
                if(cardNumber[i] == ' ')
                {
                    i++;
                }
                numbers[j] = Int32.Parse(cardNumber[i].ToString());
                j++;
            }

            //start Luhn's algorithm
            //double every second integer
            //if doubling results in double digit number, add digits together
            //sum integers together
            //if mod 10 == 0, card is valid
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i % 2) == 1)
                {
                    numbers[i] = numbers[i] * 2;

                    //if numbers[i] > 9, add digits
                    if(numbers[i] >9)
                    {
                        string temp = numbers[i].ToString();
                        int[] templist = new int[2];

                        templist[0] = Int32.Parse(temp[0].ToString());
                        templist[1] = Int32.Parse(temp[1].ToString());

                        numbers[i] = templist[0] + templist[1];
                    }
                }
                sum = numbers[i] + sum;
            }

            if (!((sum % 10) == 0))
            {
                return false;
            }

            return true;
        }

        private bool ValidateExpirationDate(string expirationDate)
        {
            int month, year;

            month = Int32.Parse(expirationDate.Substring(0, 2));
            year = Int32.Parse(expirationDate.Substring(3, 2));

            //if the year is 2021, 8-12 months are valid
            if (year == 21)
            {
                if ((month < 8) || (month > 12))
                {
                    return false;
                }
            }
            //if the year is higher than 2021, any month is valid
            else if (year > 21)
            {
                if ((month < 0) || (month > 12))
                {
                    return false;
                }
            }
            //if the year is lower than 2021, invalid
            else if (year < 21)
            {
                return false;
            }

            return true;
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
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signupform = new SignUpForm();
            signupform.ShowDialog();
        }
    }
}
