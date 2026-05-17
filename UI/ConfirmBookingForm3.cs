using System;
using System.Windows.Forms;
using abog.Models;
using abog.Services;

namespace abog.UI
{
    public partial class ConfirmBookingForm3 : Form
    {
        // =========================
        // DATA FROM PREVIOUS FORM
        // =========================
        public string FirstName;
        public string LastName;
        public string Address;
        public string Phone;
        public string Email;
        public string Service;
        public DateTime PreferredDate;
        public DateTime PreferredTime;
        public string Instructions;

        private double price = 0;

        BookingService bookingService = new BookingService();

        public ConfirmBookingForm3()
        {
            InitializeComponent();
            btnConfirm.Click += btnConfirm_Click;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ConfirmBookingForm3_Load(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblName.Text = $"{FirstName} {LastName}";
            lblService.Text = Service ?? "";

            lblDateTime.Text =
                PreferredDate.ToString("MMMM dd, yyyy") + " • " + PreferredTime.ToString("hh:mm tt");

            lblAddress.Text = Address ?? "";
            lblEmail.Text = Email ?? "";
            lblPhone.Text = Phone ?? "";
            lblInstruction.Text = Instructions ?? "";

            // =========================
            // PRICE
            // =========================
            switch (Service)
            {
                case "Basic Clean": price = 699; break;
                case "Standard Clean": price = 1499; break;
                case "Deep Clean": price = 3199; break;
                case "Auto Detail": price = 499; break;
            }

            lblTotal.Text = $"₱ {price:N0}";
        }

        // =========================
        // BACK BUTTON
        // =========================
        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingDetailForm2 frm = new BookingDetailForm2(this);
            Main_Form.LoadForm(frm);
        }

        // =========================
        // CONFIRM BUTTON
        // =========================
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // =========================
                // VALIDATION
                // =========================
                if (string.IsNullOrEmpty(Service))
                {
                    MessageBox.Show("Service is missing.");
                    return;
                }

                if (string.IsNullOrEmpty(Address))
                {
                    MessageBox.Show("Address is missing.");
                    return;
                }

                // =========================
                // SERVICE ID VALIDATION  <-- KEY FIX
                // =========================
                int serviceId = GetServiceId(Service);

                if (serviceId == 0)
                {
                    MessageBox.Show(
                        $"Unknown service: '{Service}'\n\n" +
                        "Valid services are: Basic Clean, Standard Clean, Deep Clean, Auto Detail."
                    );
                    return;
                }

                // =========================
                // USER CHECK
                // =========================
                if (CurrentUser.User == null)
                {
                    MessageBox.Show("User session not found.");
                    return;
                }

                int userId = CurrentUser.User.UserId;

                // =========================
                // CREATE BOOKING
                // =========================
                Booking booking = new Booking();


                booking.UserId = userId;
                booking.ServiceId = serviceId;   // uses validated ID
                booking.Address = Address;

                booking.StartDateTime = PreferredDate.Date + PreferredTime.TimeOfDay;

                booking.EndDateTime = PreferredDate.Date + PreferredTime.TimeOfDay + TimeSpan.FromHours(1);

                booking.Status = "Pending";

                // =========================
                // SAVE TO DATABASE
                // =========================
                bool success = bookingService.CreateBooking(booking);

                // =========================
                // SUCCESS
                // =========================
                if (success)
                {
                    MessageBox.Show("Booking Confirmed!");

                    homePage home = new homePage();
                    home.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Booking failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR:\n\n" + ex.Message +
                    "\n\n" +
                    ex.StackTrace
                );
            }
        }

        // =========================
        // SERVICE ID MAPPING
        // Returns 0 if not found (caller must validate!)
        // =========================
        private int GetServiceId(string serviceName)
        {
            switch (serviceName?.Trim())
            {
                case "Basic Clean": return 1;
                case "Standard Clean": return 2;
                case "Deep Clean": return 3;
                case "Auto Detail": return 4;
                default: return 0;
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblService_Click(object sender, EventArgs e)
        {

        }
    }
}