using System;
using System.Drawing;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class BookingDetailForm2 : Form
    {
        public string selectedService = "";

        public BookingDetailForm2()
        {
            InitializeComponent();
        }

        private void BookingDetailForm2_Load(object sender, EventArgs e)
        {
            HighlightService();
        }

        // =========================
        // HIGHLIGHT SERVICE
        // =========================
        private void HighlightService()
        {
            btnBasic.BackColor = Color.White;
            btnStandard.BackColor = Color.White;
            btnDeep.BackColor = Color.White;
            btnAuto.BackColor = Color.White;

            btnBasic.ForeColor = Color.Black;
            btnStandard.ForeColor = Color.Black;
            btnDeep.ForeColor = Color.Black;
            btnAuto.ForeColor = Color.Black;

            if (selectedService == "Basic Clean")
                Style(btnBasic);
            else if (selectedService == "Standard Clean")
                Style(btnStandard);
            else if (selectedService == "Deep Clean")
                Style(btnDeep);
            else if (selectedService == "Auto Detail")
                Style(btnAuto);
        }

        private void Style(Button btn)
        {
            btn.BackColor = Color.FromArgb(90, 118, 132);
            btn.ForeColor = Color.White;
        }

        // =========================
        // CONTINUE BUTTON
        // =========================
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService))
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name.");
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name.");
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.");
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNum.Text))
            {
                MessageBox.Show("Please enter phone number.");
                txtPhoneNum.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtEmail.Text,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (!long.TryParse(txtPhoneNum.Text, out _))
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtPhoneNum.Focus();
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

            Main_Form.LoadForm(frm);
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {

        }

        public BookingDetailForm2(ConfirmBookingForm3 data)
        {
            InitializeComponent();

            // Pre-fill all fields from passed data
            selectedService = data.Service;

            // These run after InitializeComponent so controls exist
            this.Load += (s, e) =>
            {
                txtFirstName.Text = data.FirstName;
                txtLastName.Text = data.LastName;
                txtAddress.Text = data.Address;
                txtEmail.Text = data.Email;
                txtPhoneNum.Text = data.Phone;
                dtpDate.Value = data.PreferredDate;
                dtpTime.Value = data.PreferredTime;
                txtInstructions.Text = data.Instructions;

                HighlightService(); // re-highlight the selected service button
            };
        }
    }
}