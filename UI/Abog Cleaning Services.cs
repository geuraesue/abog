using abog.UI;
using System.Drawing.Drawing2D;

namespace abog
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void homePage_Load(object sender, EventArgs e)
        {
            RoundButton(btnLogin);
            RoundButton(btnSignup);
            RoundButton(btnBasicClean);
            RoundButton(btnStandardClean);
            RoundButton(btnDeepClean);
            RoundButton(btnAutoDetail);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
        }
    }
}
