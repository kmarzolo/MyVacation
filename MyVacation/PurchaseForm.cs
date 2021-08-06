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
            LocationLabel.Text = location;
        }

        public PurchaseForm(string user, string location)
        {
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

            ValidateCard(cardNumber, expirationDate, cvv);

        }

        private bool ValidateCard(string cardNumber, string expirationDate, string cvv)
        {
            if ((cardNumber.Length > 16) || (cardNumber.Length < 12))
            {
                return false;
            }



            return true;
        }

    }
}
