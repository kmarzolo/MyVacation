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
        PurchaseForm purchaseform = new PurchaseForm();
        public FlightForm()
        {
            InitializeComponent();
        }

        public FlightForm(string FlightLabelText)
        {
            Random randomNumber = new Random();

            InitializeComponent();
            FlightLabel.Text = FlightLabelText;
            
            int price = randomNumber.Next(500, 2000);
            DeltaPrice.Text = price.ToString();
            price = randomNumber.Next(500, 2000);
            SpiritPrice.Text = price.ToString();
            price = randomNumber.Next(500, 2000);
            UAPrice.Text = price.ToString();
            price = randomNumber.Next(500, 2000);
            SWPrice.Text = price.ToString();
            price = randomNumber.Next(500, 2000);
            JetBluePrice.Text = price.ToString();
            price = randomNumber.Next(500, 2000);
            AAPrice.Text = price.ToString();

        }

        private void DeltaBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }

        private void SpiritBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }

        private void UABuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }

        private void SWBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }

        private void JetBlueBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }

        private void AABuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchaseform.ShowDialog();
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
