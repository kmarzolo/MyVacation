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
        bool loginFound;

        public MainForm()
        {//startup form, first page user sees
            InitializeComponent();

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
            LoginForm loginform = new LoginForm(ref logins);
            loginform.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
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
            SetUpFlightTable();
        }

        private void FlightTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetUpFlightTable()
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
                    city.Name = flightnode.Value.endLocation;
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

                //move on to next node
                flightnode = flightnode.Next;
            }

        }

        private void SeePrices_Click(object sender, EventArgs e)
        {
            string strg = (sender as Button).Name;
            FlightForm flightform = new FlightForm(strg);
            flightform.ShowDialog();
        }
    }
}
