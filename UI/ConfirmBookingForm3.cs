using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class ConfirmBookingForm3 : Form
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string Phone;
        public string Email;
        public string Service;
        public DateTime PreferredDate;
        public DateTime PreferredTime;
        public string Instructions;

        double price = 0;
        public ConfirmBookingForm3()
        {
            InitializeComponent();
        }

        private void ConfirmBookingForm3_Load(object sender, EventArgs e)
        {
            lblService.Text = Service;

            lblDateTime.Text =
                PreferredDate.ToString("MMMM dd, yyyy") + " • " + PreferredTime.ToString("hh:mm tt");

            lblAddress.Text = Address;
            lblEmail.Text = Email;
            lblPhone.Text = Phone;

            lblInstruction.Text = Instructions;

            if (Service == "Basic Clean")
            {
                price = 699;
            }
            else if (Service == "Standard Clean")
            {
                price = 1499;
            }
            else if (Service == "Deep Clean")
            {
                price = 3199;
            }
            else if (Service == "Auto Detail")
            {
                price = 499;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Confirmed!");

            homePage frm = new homePage();
            frm.Show();

            this.Hide();
        }
    }
}
