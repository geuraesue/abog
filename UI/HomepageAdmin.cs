using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using abog.Services;

namespace abog.UI
{
    public partial class HomepageAdmin : Form
    {
        private BookingService bookingService = new BookingService();
        private bool isStyled = false; // ← prevents re-styling on refresh

        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {
            StyleGrid();    // ← once only
            LoadBookings(); // ← data

            // ← rename columns only after data is fully bound
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
        }

        // =========================
        // TRIGGERS AFTER DATA BINDS
        // =========================
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Count == 0) return;
            if (dataGridView1.Rows.Count == 0) return;

            RenameColumns();
        }

        // =========================
        // STYLE — runs once
        // =========================
        private void StyleGrid()
        {
            if (isStyled) return;
            isStyled = true;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Header
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            // Rows
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 245);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.RowTemplate.Height = 45;

            // Wire events once
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        // =========================
        // LOAD DATA
        // =========================
        private void LoadBookings()
        {
            try
            {
                DataTable dt = bookingService.GetBookings();

                if (dt == null || dt.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    return;
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings:\n\n" + ex.Message);
            }
        }

        // =========================
        // RENAME COLUMNS
        // Only runs when data is present
        // =========================
        private void RenameColumns()
        {
            var renames = new System.Collections.Generic.Dictionary<string, string>
            {
                { "booking_id",     "Booking ID" },
                { "user_id",        "User ID"    },
                { "service_id",     "Service ID" },
                { "address",        "Address"    },
                { "start_datetime", "Start"      },
                { "end_datetime",   "End"        },
                { "status",         "Status"     },
                { "created_at",     "Created At" }
            };

            foreach (var col in renames)
                if (dataGridView1.Columns[col.Key] != null)
                    dataGridView1.Columns[col.Key].HeaderText = col.Value;
        }

        // =========================
        // STATUS BADGE COLORS
        // =========================
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "status")
            {
                switch (e.Value.ToString())
                {
                    case "Pending":
                        e.CellStyle.BackColor = Color.FromArgb(255, 220, 150);
                        e.CellStyle.ForeColor = Color.FromArgb(150, 90, 0);
                        break;
                    case "Completed":
                        e.CellStyle.BackColor = Color.FromArgb(180, 230, 180);
                        e.CellStyle.ForeColor = Color.FromArgb(0, 100, 0);
                        break;
                    case "Cancelled":
                        e.CellStyle.BackColor = Color.FromArgb(255, 180, 180);
                        e.CellStyle.ForeColor = Color.FromArgb(150, 0, 0);
                        break;
                }

                e.CellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // =========================
        // VIEW BOOKING
        // =========================
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["booking_id"].Value
            );

            View viewForm = new View();
            Main_Form.LoadForm(viewForm);
        }

        // =========================
        // REFRESH
        // =========================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }
    }
}