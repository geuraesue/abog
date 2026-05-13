using abog.UI;

namespace abog
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
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
    }
}
