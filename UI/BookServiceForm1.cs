using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class BookServiceForm1 : Form
    {
        private Panel selectedPanel = null;
        private string selectedService = "";
        public BookServiceForm1()
        {
            InitializeComponent();
        }

        private void SelectService(Panel panel, string serviceName)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
            }

            panel.BackColor = Color.FromArgb(90, 118, 132);

            selectedPanel = panel;
            selectedService = serviceName;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void BookServiceForm1_Load(object sender, EventArgs e)
        {
            RoundPanel(panelBasic);
            RoundPanel(panelStandard);
            RoundPanel(panelDeep);
            RoundPanel(panelAuto);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            SelectService(panelBasic, "Basic Clean");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SelectService(panelStandard, "Standard Clean");
        }

        private void panelDeep_Paint(object sender, PaintEventArgs e)
        {
            SelectService(panelDeep, "Deep Clean");
        }

        private void panelAuto_Paint(object sender, PaintEventArgs e)
        {
            SelectService(panelAuto, "Auto Detail");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService));
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            MessageBox.Show("You selected: " + selectedService);

            BookServiceForm1 frm = new BookServiceForm1();
            frm.Show();

            this.Hide();
        }

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
    }
}
