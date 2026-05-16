using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class BookingDetailForm2 : Form
    {
        public BookingDetailForm2()
        {
            InitializeComponent();
        }

        public string selectedService = "";
        private void BookingDetailForm2_Load(object sender, EventArgs e)
        {
            if (selectedService == "Basic Clean")
            {
                btnBasic.BackColor = Color.FromArgb(90, 118, 132);
                btnBasic.ForeColor = Color.White;
            }

            if (selectedService == "Standard Clean")
            {
                btnStandard.BackColor = Color.FromArgb(90, 118, 132);
                btnStandard.ForeColor = Color.White;
            }

            if (selectedService == "Deep Clean")
            {
                btnDeep.BackColor = Color.FromArgb(90, 118, 132);
                btnDeep.ForeColor = Color.White;
            }

            if (selectedService == "Auto Detail")
            {
                btnAuto.BackColor = Color.FromArgb(90, 118, 132);
                btnAuto.ForeColor = Color.White;
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First name")
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First name";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last name")
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Address";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
            }
        }
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
            }
        }
        private void txtPhoneNum_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNum.Text == "Phone Number")
            {
                txtPhoneNum.Text = "";
            }
        }

        private void txtPhoneNum_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNum.Text == "")
            {
                txtPhoneNum.Text = "Phone Number";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService)) ;
            {
                MessageBox.Show("Please fill out the information first.");
                return;
            }
        }
    }
}
