using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class BookServiceForm1 : Form
    {
        private Panel selectedPanel = null;
        public string selectedService = "";

        public BookServiceForm1()
        {
            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void BookServiceForm1_Load(object sender, EventArgs e)
        {
            RoundPanel(panelBasic);
            RoundPanel(panelStandard);
            RoundPanel(panelDeep);
            RoundPanel(panelAuto);

            AttachClickEvents(panelBasic, panelBasic_Click);
            AttachClickEvents(panelStandard, panelStandard_Click);
            AttachClickEvents(panelDeep, panelDeep_Click);
            AttachClickEvents(panelAuto, panelAuto_Click);
        }

        // =========================
        // ATTACH CLICK EVENTS
        // =========================
        private void AttachClickEvents(Panel panel, EventHandler handler)
        {
            panel.Click += handler;

            foreach (Control c in panel.Controls)
            {
                c.Click += handler;
            }
        }

        // =========================
        // SELECT SERVICE
        // =========================
        private void SelectService(Panel panel, string serviceName)
        {
            // RESET PREVIOUS PANEL
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
                selectedPanel.BorderStyle = BorderStyle.None;

                foreach (Control c in selectedPanel.Controls)
                {
                    // Currency labels back to green
                    if (c.Name.Contains("Price") || c.Text.Contains("₱"))
                    {
                        c.ForeColor = Color.FromArgb(155, 167, 123);
                    }
                    else
                    {
                        // Other text back to blue
                        c.ForeColor = Color.FromArgb(90, 118, 132);
                    }
                }
            }

            // SELECT NEW PANEL
            panel.BackColor = Color.FromArgb(90, 118, 132);
            panel.BorderStyle = BorderStyle.FixedSingle;

            foreach (Control c in panel.Controls)
            {
                c.ForeColor = Color.White;
            }

            selectedPanel = panel;
            selectedService = serviceName;
        }

        // =========================
        // PANEL CLICKS
        // =========================
        private void panelBasic_Click(object sender, EventArgs e)
        {
            SelectService(panelBasic, "Basic Clean");
        }

        private void panelStandard_Click(object sender, EventArgs e)
        {
            SelectService(panelStandard, "Standard Clean");
        }

        private void panelDeep_Click(object sender, EventArgs e)
        {
            SelectService(panelDeep, "Deep Clean");
        }

        private void panelAuto_Click(object sender, EventArgs e)
        {
            SelectService(panelAuto, "Auto Detail");
        }

        // =========================
        // CONTINUE BUTTON
        // =========================
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService))
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            BookingDetailForm2 frm = new BookingDetailForm2();
            frm.selectedService = selectedService;
            Main_Form.LoadForm(frm);


        }

        // =========================
        // ROUND PANEL
        // =========================
        private void RoundPanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void panelBasic_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}