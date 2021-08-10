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
    public partial class AccountForm : Form
    {
        LoginEntry login = Variables.logins.GetLoginAccount();
        public AccountForm()
        {
            InitializeComponent();
            //show current login info
            CurrentInfoPanel.Show();

            //hide all other panels
            UpdateUserPanel.Hide();
            UpdateCardPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            CardMessage.Hide();
            PassMessage.Hide();

            DisplayUserInfo();
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            CurrentInfoPanel.Hide();
            UpdateUserPanel.Show();
            UpdateCardPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            CardMessage.Hide();
            PassMessage.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CurrentInfoPanel.Show();
            UpdateUserPanel.Hide();
            UpdateCardPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            CardMessage.Hide();
            PassMessage.Hide();
        }

        private void SubmitUser_Click(object sender, EventArgs e)
        {
            //check if textboxes are empty
            if (FirstNameBox.Text != "")
            {
                login.firstName = FirstNameBox.Text;
            }
            if (LastNameBox.Text != "")
            {
                login.lastName = LastNameBox.Text;
            }
            if (EmailBox.Text != "")
            {
                login.email = EmailBox.Text;
            }

            //update account
            Variables.logins.EditAccount(login);

            UserMessage.Show();
            UserMessage.Text = "User Information Updated";

            //display information
            FirstNameLabel.Text = login.firstName;
            LastNameLabel.Text = login.lastName;
            EmailLabel.Text = login.email;
        }

        private void SubmitPass_Click(object sender, EventArgs e)
        {
            string oldpassword = OldPassBox.Text,
                newpassword = NewPassBox.Text,
                confirmpassword = ConfirmPassBox.Text;

            if (newpassword != confirmpassword)
            {
                PassMessage.Show();
                PassMessage.Text = "New Password and Confirmation Must Match";
                return;
            }

            bool passwordcheck = Variables.logins.CheckPassword(login.username, oldpassword);
            if (!passwordcheck)
            {
                PassMessage.Show();
                PassMessage.Text = "Old Password Invalid";
            }
            if (passwordcheck)
            {
                login.password = newpassword;
                Variables.logins.EditAccount(login);
                PassMessage.Show();
                PassMessage.Text = "Password Change Successful";
            }
        }

        private void SubmitCard_Click(object sender, EventArgs e)
        {
            string cardNumber = CardNumberBox.Text,
                expirationdate = ExpirationDateBox.Text,
                cvv = CVVBox.Text;

            //check if card number was filled out
            if (!(cardNumber.Contains("  ")))
            {
                //check if card number is valid
                bool cardcheck = Variables.validation.ValidateCardNumber(cardNumber);
                if (!cardcheck)
                {
                    CardMessage.Show();
                    CardMessage.Text = "Card number is not valid";
                    return;
                }

                if (!(expirationdate.Contains("  ")))
                {
                    bool datecheck = Variables.validation.ValidateExpirationDate(expirationdate);

                    //check if date is valid
                    if (!datecheck)
                    {
                        CardMessage.Show();
                        CardMessage.Text = "Expiration Date invalid";
                        return;
                    }
                }
                else
                {
                    CardMessage.Show();
                    CardMessage.Text = "Please enter valid expiration date";
                    return;
                }

                if (cvv == "")
                {
                    CardMessage.Show();
                    CardMessage.Text = "Please enter cvv";
                    return;
                }
            }
            else
            {
                CardMessage.Show();
                CardMessage.Text = "Please enter credit card";
                return;
            }

            //card is valid
            CardMessage.Show();
            CardMessage.Text = "Card has been updated";

            //update card
            Variables.logins.SetElement("cardNumber", cardNumber);
            Variables.logins.SetElement("expirationDate", expirationdate);
            Variables.logins.SetElement("cvv", cvv);
            login = Variables.logins.GetLoginAccount();


            CardLabel.Text = "**** **** **** " + cardNumber.Substring(15, 4);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            //show password panel
            UpdatePasswardPanel.Show();

            //hide all other panels
            CurrentInfoPanel.Hide();
            UpdateUserPanel.Hide();
            UpdateCardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            PassMessage.Hide();
            CardMessage.Hide();
        }

        private void ChangeCardButton_Click(object sender, EventArgs e)
        {
            //show card information panel
            UpdateCardPanel.Show();

            //hide all other panels
            CurrentInfoPanel.Hide();
            UpdateUserPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            PassMessage.Hide();
            CardMessage.Hide();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            //show user information panel
            UpdateUserPanel.Show();

            //hide all other panels
            UpdateCardPanel.Hide();
            CurrentInfoPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            PassMessage.Hide();
            CardMessage.Hide();
        }

        public void DisplayUserInfo()
        {
            //show user info
            UsernameLabel.Text = login.username;
            FirstNameLabel.Text = login.firstName;
            LastNameLabel.Text = login.lastName;
            EmailLabel.Text = login.email;

            if (!(login.cardNumber.Contains("  ")))
            {
                CardLabel.Text = "**** **** **** " + login.cardNumber.Substring(15, 4);
            }
            else
            {
                CardLabel.Text = "Not Entered";
            }

            if (login.flight.startlocation != null)
            {
                StartLocationLabel.Text = login.flight.startlocation;
            }
            else
            {
                StartLocationLabel.Text = "No Flight Information";
            }

            if (login.flight.endlocation != null)
            {
                EndLocationLabel.Text = login.flight.endlocation;
            }
            else
            {
                EndLocationLabel.Text = "No Flight Information";
            }

            if ((login.flight.departdate != null) || (login.flight.returndate != null))
            {
                DateRangeLabel.Text = login.flight.departdate + '-'
                    + login.flight.returndate;
            }
            else
            {
                DateRangeLabel.Text = "No Flight Information";
            }

            if (login.flight.price > 0)
            {
                PriceLabel.Text = login.flight.price.ToString();
            }
            else
            {
                PriceLabel.Text = "No Flight Information";
            }
        }


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            //show current panel
            CurrentInfoPanel.Show();

            //hide all other panels
            UpdateUserPanel.Hide();
            UpdateCardPanel.Hide();
            UpdatePasswardPanel.Hide();
            FlightPanel.Hide();
            UserMessage.Hide();
            CardMessage.Hide();
            PassMessage.Hide();

            DisplayUserInfo();
        }

        private void CancelFlightButton_Click(object sender, EventArgs e)
        {
            login.flight = new Flight();
            Variables.logins.SetFlight(new Flight());

            StartLocationLabel.Text = "No Flight Information";
            EndLocationLabel.Text = "No Flight Information";
            DateRangeLabel.Text = "No Flight Information";
            PriceLabel.Text = "No Flight Information";
        }

        private void FlightPanelButton_Click(object sender, EventArgs e)
        {
            //show flight panel
            FlightPanel.Show();

            //hide all other panels
            UpdateUserPanel.Hide();
            UpdateCardPanel.Hide();
            UpdatePasswardPanel.Hide();
            CurrentInfoPanel.Hide();
            UserMessage.Hide();
            CardMessage.Hide();
            PassMessage.Hide();

            DisplayUserInfo();
        }
    }
}