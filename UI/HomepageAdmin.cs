using System;
using System.Data;
using System.Windows.Forms;
using abog.Services;

namespace abog.UI
{
    public partial class HomepageAdmin : Form
    {
        private BookingService bookingService = new BookingService();

        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                DataTable dt = bookingService.GetBookings();
                dataGridView1.DataSource = dt;

                // =========================
                // STYLE THE GRID
                // =========================
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // =========================
                // RENAME COLUMN HEADERS
                // =========================
                if (dataGridView1.Columns["booking_id"] != null)
                    dataGridView1.Columns["booking_id"].HeaderText = "Booking ID";

                if (dataGridView1.Columns["user_id"] != null)
                    dataGridView1.Columns["user_id"].HeaderText = "User ID";

                if (dataGridView1.Columns["service_id"] != null)
                    dataGridView1.Columns["service_id"].HeaderText = "Service ID";

                if (dataGridView1.Columns["address"] != null)
                    dataGridView1.Columns["address"].HeaderText = "Address";

                if (dataGridView1.Columns["start_datetime"] != null)
                    dataGridView1.Columns["start_datetime"].HeaderText = "Start";

                if (dataGridView1.Columns["end_datetime"] != null)
                    dataGridView1.Columns["end_datetime"].HeaderText = "End";

                if (dataGridView1.Columns["status"] != null)
                    dataGridView1.Columns["status"].HeaderText = "Status";

                if (dataGridView1.Columns["created_at"] != null)
                    dataGridView1.Columns["created_at"].HeaderText = "Created At";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings:\n\n" + ex.Message);
            }
        }

        // =========================
        // OPEN VIEW FORM
        // =========================
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            // get selected booking id
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["booking_id"].Value);

            View viewForm = new View();
            viewForm.FormClosed += (s, args) => LoadBookings(); // refresh on close
            viewForm.Show();
        }

        // =========================
        // REFRESH BUTTON
        // =========================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }
    }
}