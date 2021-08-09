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
    public partial class FlightForm : Form
    {
        Flight flight;
        int deltaPrice, spiritPrice, uaPrice, swPrice, jetbluePrice, aaPrice;

        public FlightForm()
        {
            Random randomNumber = new Random(); //used to set prices
            InitializeComponent();

            //set user label
            if (Variables.logins.GetLoginStatus())
            {
                UserLabel.Text = "User: " + Variables.logins.GetLoginAccount().firstName;
            }

            flight = Variables.flights.GetFlight();

            //set date range
            DateRange.Text = flight.departdate + '-' + flight.returndate;

            //set location labels
            StartLocation.Text = "From: " + flight.startlocation;
            EndLocation.Text = "To: " + flight.endlocation;

            //set prices
            deltaPrice = randomNumber.Next(500, 2000);
            DeltaPrice.Text = deltaPrice.ToString();
            spiritPrice = randomNumber.Next(500, 2000);
            SpiritPrice.Text = spiritPrice.ToString();
            uaPrice = randomNumber.Next(500, 2000);
            UAPrice.Text = uaPrice.ToString();
            swPrice = randomNumber.Next(500, 2000);
            SWPrice.Text = swPrice.ToString();
            jetbluePrice = randomNumber.Next(500, 2000);
            JetBluePrice.Text = jetbluePrice.ToString();
            aaPrice = randomNumber.Next(500, 2000);
            AAPrice.Text = aaPrice.ToString();

        }

        private void DeltaBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(deltaPrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void SpiritBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(spiritPrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void UABuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(uaPrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void SWBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(swPrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void JetBlueBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(jetbluePrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void AABuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.flights.SetPrice(aaPrice);
            PurchaseForm purchaseform = new PurchaseForm();
            purchaseform.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
