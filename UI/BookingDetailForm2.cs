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

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter address.");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter first name.");
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter last name.");
                return;
            }

            if (txtPhoneNum.Text == "")
            {
                MessageBox.Show("Please enter phone num.");
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

        private void btnBasic_Click(object sender, EventArgs e)
        {

        }
    }
}