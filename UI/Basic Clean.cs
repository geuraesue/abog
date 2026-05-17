using abog.Models;
using abog.Services;
using abog.UI;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace abog
{
    public partial class basicClean : Form
    {
        public basicClean()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void RoundButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

        }
        private void basicClean_Load(object sender, EventArgs e)
        {
            RoundButton(btnBasClean);
            panel1.SendToBack();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new homePage());
        }

        private void btnBasClean_Click(object sender, EventArgs e)
        {
            if (!Users.IsLoggedIn)
            {
                // Not logged in — show login form
                Main_Form.LoadForm(new LoginForm());

                // Check again after login form closes
                if (!Users.IsLoggedIn)
                    return; // they closed without logging in
            }

            // ✅ Logged in — proceed to booking
            Main_Form.LoadForm(new BookServiceForm1());
        }
    }
}
