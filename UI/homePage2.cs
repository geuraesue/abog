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
    public partial class homePage2 : Form
    {
        public homePage2()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new homePage());
        }

        private void btnBasicClean_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new basicClean());
        }

        private void btnStandardClean_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new standardClean());
        }

        private void btnDeepClean_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new deepClean());
        }

        private void btnAutoDetail_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new autoDetail());
        }
    }
}
