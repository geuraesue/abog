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
        private bool isStyled = false;

        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {
            StyleGrid();
            SetupColumns();
            LoadBookings();

            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        // =========================
        // TRIGGERS AFTER DATA BINDS
        // =========================
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Count == 0) return;
            if (dataGridView1.Rows.Count == 0) return;

            // Keep these hidden after binding
            if (dataGridView1.Columns["booking_id"] != null)
                dataGridView1.Columns["booking_id"].Visible = false;

            if (dataGridView1.Columns["colLastName"] != null)
                dataGridView1.Columns["colLastName"].Visible = false;
        }

        // =========================
        // SETUP COLUMNS
        // =========================
        private void SetupColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Hidden — used for OpenViewForm
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "booking_id",
                DataPropertyName = "booking_id", // ✅ matches DB
                Visible = false
            });

            // Hidden — combined with first_name
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLastName",
                DataPropertyName = "last_name",  // ✅ matches DB
                Visible = false
            });

            // Customer full name (first_name + last_name)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCustomer",
                HeaderText = "Customers",
                DataPropertyName = "first_name", // ✅ matches DB
                FillWeight = 22
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colService",
                HeaderText = "Service",
                DataPropertyName = "service_name", // ✅ matches DB
                FillWeight = 18
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                HeaderText = "Date",
                DataPropertyName = "start_datetime", // ✅ matches DB
                FillWeight = 20
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                DataPropertyName = "status", // ✅ matches DB
                FillWeight = 15
            });

            dataGridView1.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "colAction",
                HeaderText = "Action",
                Text = "View",
                UseColumnTextForLinkValue = true,
                FillWeight = 10,
                LinkColor = Color.FromArgb(90, 118, 132),
                VisitedLinkColor = Color.FromArgb(90, 118, 132),
                ActiveLinkColor = Color.FromArgb(60, 90, 110)
            });
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
        // CELL FORMATTING
        // =========================
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            // =========================
            // COMBINE FIRST + LAST NAME
            // =========================
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colCustomer")
            {
                string firstName = e.Value?.ToString();
                string lastName = dataGridView1.Rows[e.RowIndex]
                                    .Cells["colLastName"].Value?.ToString();

                e.Value = $"{firstName} {lastName}".Trim();
                e.FormattingApplied = true;
            }

            // =========================
            // STATUS BADGE COLORS
            // =========================
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colStatus")
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
        // VIEW LINK CLICK
        // =========================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colAction")
                OpenViewForm(e.RowIndex);
        }

        // =========================
        // VIEW BOOKING BUTTON
        // =========================
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            OpenViewForm(dataGridView1.SelectedRows[0].Index);
        }

        // =========================
        // OPEN VIEW FORM
        // =========================
        private void OpenViewForm(int rowIndex)
        {
            int bookingId = Convert.ToInt32(
                dataGridView1.Rows[rowIndex].Cells["booking_id"].Value
            );

            View viewForm = new View();
            viewForm.FormClosed += (s, args) => LoadBookings();
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