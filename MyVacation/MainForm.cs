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
        LinkedList<LoginEntry> logins = new LinkedList<LoginEntry>(); //to hold all accounts
        LinkedList<Flight> flights = new LinkedList<Flight>(); //to hold all flights
        ListOps listoperations = new ListOps(); //methods for updating lists
        LoginEntry entry;
        Flight flight;
        LinkedListNode<Flight> flightnode;
        Point startpoint;
        bool loginFound;

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

            //collect list of all flights
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kmarz\source\repos\MyVacation\MyVacation\Flight Log.txt");
            foreach (string line in lines)
            {
                flight.endLocation = line;
                flights.AddLast(flight);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //go to sign up page, users can register accounts
            SignUpForm signupform = new SignUpForm(ref logins);
            signupform.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginFound = false;
            //if login button hasn't been clicked yet
            //click to reveal login fields
            if (LoginButton.Location == startpoint)
            {

                LoginButton.Location = new Point(589, 78);
                CancelButton.Show();
                UsernameBox.Show();
                UsernameLabel.Show();
                PasswordBox.Show();
                PasswordLabel.Show();
                SignUpButton.Hide();
                Message.Hide();
            }
            //user enters login information
            //search for their account
            else
            {
                entry.username = UsernameBox.Text;
                entry.password = PasswordBox.Text;

                //search for account
                loginFound = listoperations.Verify(ref entry, ref logins);

                //if found, let user know and welcome them top left corner of screen
                Message.Show();
                if (loginFound)
                {
                    Message.Text = "Login Successful";
                    Welcome.Text = "Welcome, " + entry.firstName;
                }
                //if not found, revert back to original;
                if (!loginFound)
                {
                    Message.Text = "Login Failed";
                    Welcome.Text = "Welcome";
                    return;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //if cancel button is clicked, hide login fields
            CancelButton.Hide();
            UsernameBox.Hide();
            UsernameLabel.Hide();
            PasswordBox.Hide();
            PasswordLabel.Hide();
            SignUpButton.Show();
            Message.Hide();
            LoginButton.Location = startpoint;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //collect search criteria
            string location = EndLocationBox.Text;
            string departdate = DepartBox.Text;
            string returndate = ReturnBox.Text;

            flightnode = flights.First;

            //search
            while (flightnode.Next != null)
            {
                if (flightnode.Value.endLocation.Contains(location))
                {
                    //create label for displaying information;
                    Label city = new Label();
                    city.Text = flightnode.Value.endLocation;
                    city.Dock = DockStyle.Fill;
                    city.TextAlign = ContentAlignment.MiddleCenter;
                    city.Font = new Font("Arial", 12, FontStyle.Regular);
                    city.Name = city.Text;

                    //create button for purchasing flight
                    this.SeePrices = new System.Windows.Forms.Button();
                    this.SeePrices.Text = "See Prices";
                    this.SeePrices.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                    this.SeePrices.AutoSize = true;
                    this.SeePrices.Name = "SeePrices";
                    this.SeePrices.Click += new EventHandler(SeePrices_Click);

                    //Add row including available flight and select button
                    FlightTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    FlightTable.Controls.Add(city, 0, FlightTable.RowCount);
                    FlightTable.Controls.Add(SeePrices, 3, FlightTable.RowCount);
                    FlightTable.RowCount++;
                }

                //move on to next node
                flightnode = flightnode.Next;
            }
        }

        private void FlightTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SeePrices_Click(object sender, EventArgs e)
        {
            FlightForm flightform = new FlightForm();
            flightform.ShowDialog();
            
        }
    }
}
