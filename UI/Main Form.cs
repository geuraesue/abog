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
    public partial class Main_Form : Form
    {
        public static Panel MainPanel;
        public Main_Form()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new homePage());
        }

        public static void LoadForm(Form form)
        {
            MainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(form);
            form.Show();
        }
    }
}
