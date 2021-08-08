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

            //collect list of all flights
            //Variables.flights = System.IO.File.ReadAllLines(@"C:\Users\kmarz\source\repos\MyVacation\MyVacation\Flight Log.txt");
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
                Welcome.Text = "Welcome";
            }
            //show sign out button if logged in
            else if (Variables.logins.GetLoginStatus())
            {
                SignUpButton.Hide();
                SignOutButton.Show();
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

            //search list for startlocation
            if(Variables.flights.FindFlights(startlocation))
            {
                startlocation = Variables.flights.GetFlight(startlocation);
            }
            else
            {
                SearchMessage.Show();
                SearchMessage.Text = "Start Location Not Found, Enter Another Location";
                return;
            }

            //Search flight list for location
            if(Variables.flights.FindFlights(endlocation))
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
                SearchMessage.Show();
                SearchMessage.Text = "Start Location Not Found, Enter Another Location";
                return;
            }
        }

        private void SeePrices_Click(object sender, EventArgs e)
        {
            string strg = (sender as Button).Name;
            FlightForm flightform = new
                FlightForm(startlocation, departdate, returndate, strg);
            flightform.ShowDialog();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Variables.logins.SetLoginStatus(false);
            Variables.logins.SetLoginAccount(new LoginEntry());

            Welcome.Text = "Welcome";
            SignOutButton.Hide();
            SignUpButton.Show();
        }
    }
}
