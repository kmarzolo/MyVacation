using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVacation
{
    public partial class MainForm : Form
    {
        string startlocation, endlocation, departdate, returndate;
        public MainForm()
        {//startup form, first page user sees
            InitializeComponent();
            FlightTable.Hide();
            SignOutButton.Hide();
            SearchMessage.Hide();
            ProfileButton.Hide();

            Variables.flights.AddFlights(@"C:\Users\kmarz\source\repos\MyVacation\MyVacation\Flight Log.txt");
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //go to sign up page, users can register accounts
            SignUpForm signupform = new SignUpForm();
            signupform.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();

            //show sign up button if logged in
            if (!(Variables.logins.GetLoginStatus()))
            {
                SignOutButton.Hide();
                SignUpButton.Show();
                LoginButton.Show();
                ProfileButton.Hide();
                Welcome.Text = "Welcome";
            }
            //show sign out button if logged in
            else if (Variables.logins.GetLoginStatus())
            {
                SignUpButton.Hide();
                SignOutButton.Show();
                LoginButton.Hide();
                ProfileButton.Show();
                Welcome.Text = "Welcome " + Variables.logins.GetLoginAccount().firstName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {//search flights
            //show flight table
            FlightTable.Show();

            //remove all rows if new search criteria
            while (FlightTable.RowCount > 1)
            {
                int row = FlightTable.RowCount - 1;
                for (int i = 0; i < FlightTable.ColumnCount; i++)
                {
                    Control control = FlightTable.GetControlFromPosition(i, row);
                    FlightTable.Controls.Remove(control);
                }

                FlightTable.RowStyles.RemoveAt(row);
                FlightTable.RowCount--;
            }

            //show available flights
            SetUpFlightTable();
        }

        private void FlightTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutus = new AboutUs();
            aboutus.ShowDialog();
        }

        private void SetUpFlightTable()
        {
            SearchMessage.Hide();
            //collect search criteria
            startlocation = StartLocationBox.Text;
            endlocation = EndLocationBox.Text;
            departdate = DepartBox.Text;
            returndate = ReturnBox.Text;

            //if no location is entered for start location
            if (startlocation == "")
            {
                startlocation = "Anywhere";
            }
            //search list for startlocation
            else if (Variables.flights.FindFlights(startlocation))
            {
                startlocation = Variables.flights.GetFlight(startlocation);
            }
            else
            {
                //show error message
                SearchMessage.Show();
                SearchMessage.Text = "Start Location Not Found, Enter Another Location";
                return;
            }

            if (!CheckDates(departdate, returndate))
            {
                return;
            }

            //Search flight list for location
            if (Variables.flights.FindFlights(endlocation))
            {
                string[] tempList = Variables.flights.GetAllFlights(endlocation);

                for (int i = 0; i < tempList.Length; i++)
                {
                    //create label for displaying information
                    Label city = new Label();
                    city.Text = tempList[i];
                    city.Name = tempList[i];
                    city.Dock = DockStyle.Fill;
                    city.TextAlign = ContentAlignment.MiddleCenter;
                    city.Font = new Font("Arial", 12, FontStyle.Regular);

                    //create button for purchasing flight
                    Button select = new Button();
                    select.Text = "See Prices";
                    select.Anchor = AnchorStyles.None;
                    select.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                    select.AutoSize = true;
                    select.Name = city.Text;
                    select.Click += new EventHandler(SeePrices_Click);

                    //Add row including available flight and select button
                    FlightTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    FlightTable.Controls.Add(city, 0, FlightTable.RowCount);
                    FlightTable.Controls.Add(select, 3, FlightTable.RowCount);
                    FlightTable.RowCount++;
                }
            }
            else
            {
                //show error message
                SearchMessage.Show();
                SearchMessage.Text = "Start Location Not Found, Enter Another Location";
                return;
            }
        }

        private bool CheckDates(string date1, string date2)
        {//check if dates are invalid
            int month1, day1, year1;
            int month2, day2, year2;

            if(date1.Contains("  "))
            {
                SearchMessage.Show();
                SearchMessage.Text = "Please enter in departdate";
                return false;
            }
            if(date2.Contains("  "))
            {
                SearchMessage.Show();
                SearchMessage.Text = "Please enter return date";
                return false;
            }

            //break up dates
            month1 = Int32.Parse(date1.Substring(0, 2));
            day1 = Int32.Parse(date1.Substring(3, 2));
            year1 = Int32.Parse(date1.Substring(6, 4));
            month2 = Int32.Parse(date2.Substring(0, 2));
            day2 = Int32.Parse(date2.Substring(3, 2));
            year2 = Int32.Parse(date2.Substring(6, 4));

            if ((month1 > month2) || (day1 > day2) || (year1 > year2))
            {
                SearchMessage.Show();
                SearchMessage.Text = "Return date cannot be before depart date";
                return false;
            }

            if (!MonthlyRange(month1, day1, year1))
            {
                SearchMessage.Show();
                SearchMessage.Text = "Depart date out of range";
                return false;
            }
            if (!MonthlyRange(month2, day2, year2))
            {
                SearchMessage.Show();
                SearchMessage.Text = "Return date out of range";
                return false;
            }

            return true;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            AccountForm accountform = new AccountForm();
            accountform.ShowDialog();
        }

        private bool MonthlyRange(int month, int day, int year)
        {
            if (year == 2021)
            {
                if (month < 8)
                {
                    return false;
                }
            }
            if (year < 2021)
            {
                return false;
            }
            if (month == 2)
            {
                if ((day < 1) || (day > 28))
                {
                    return false;
                }
            }
            else if ((month == 1) || (month == 3) || (month == 5) ||
                (month == 7) || (month == 8) || (month == 10) || (month == 12))
            {
                if ((day < 1) || (day > 31))
                {
                    return false;
                }
            }
            else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
            {
                if ((day < 1) || (day > 30))
                {
                    return false;
                }
            }

            return true;
        }

        private void SeePrices_Click(object sender, EventArgs e)
        {
            endlocation = (sender as Button).Name;

            Variables.flights.SetFlight(startlocation, endlocation,
               departdate, returndate, 0);

            FlightForm flightform = new FlightForm();
            flightform.ShowDialog();

            if (Variables.logins.GetLoginStatus())
            {
                //show sign out button if logged in
                if (Variables.logins.GetLoginStatus())
                {
                    SignUpButton.Hide();
                    SignOutButton.Show();
                    LoginButton.Hide();
                    ProfileButton.Show();
                    Welcome.Text = "Welcome " + Variables.logins.GetLoginAccount().firstName;
                }
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            //log out
            Variables.logins.SetLoginStatus(false);
            Variables.logins.SetLoginAccount(new LoginEntry());

            //show sign up button
            Welcome.Text = "Welcome";
            SignOutButton.Hide();
            SignUpButton.Show();
            LoginButton.Show();
            ProfileButton.Hide();
        }
    }
}