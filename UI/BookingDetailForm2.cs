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
            }else if (selectedService == "Standard Clean")
            {
                btnStandard.BackColor = Color.FromArgb(90, 118, 132);
                btnStandard.ForeColor = Color.White;
            }else if (selectedService == "Deep Clean")
            {
                btnDeep.BackColor = Color.FromArgb(90, 118, 132);
                btnDeep.ForeColor = Color.White;
            }else if (selectedService == "Auto Detail")
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
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name";
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
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
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

        private void txtInstructions_Enter(object sender, EventArgs e)
        {
            if (txtInstructions.Text == "Special Instruction")
            {
                txtInstructions.Text = "";
            }
        }

        private void txtInstructions_Leave(object sender, EventArgs e)
        {
            if (txtInstructions.Text == "")
            {
                txtInstructions.Text = "Special Instruction";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService) ||
                txtFirstName.Text == "First Name" ||
                txtLastName.Text == "Last Name" ||
                txtAddress.Text == "Address" ||
                txtPhoneNum.Text == "Phone Number" ||
                txtEmail.Text == "Email")
            {
                MessageBox.Show("Please fill out all information first.");
                return;
            }
            if (dtpDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid booking date.");
                return;
            }

            if (dtpDate.Value.Date == DateTime.Now.Date && 
                    dtpTime.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Please select a valid booking time.");
                return;
            }

            ConfirmBookingForm3 frm = new ConfirmBookingForm3();

            frm.FirstName = txtFirstName.Text;
            frm.LastName = txtLastName.Text;
            frm.Address = txtAddress.Text;
            frm.Phone = txtPhoneNum.Text;
            frm.Email = txtEmail.Text;
            frm.Service = selectedService;

            frm.PreferredDate = dtpDate.Value;
            frm.PreferredTime = dtpTime.Value;

            frm.Instructions = txtInstructions.Text;

            frm.ShowDialog();
        }
    }
}
