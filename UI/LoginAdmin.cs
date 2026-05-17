using abog.Service;


namespace abog.UI
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            Authentication auth = new Authentication();
            var admin = auth.aLogin(email, password);

            if (admin == null)
            {
                MessageBox.Show("Invalid...");
                return;
            }

            MessageBox.Show($"Welcome {admin.firstName}");
            HomepageAdmin hAdmin = new HomepageAdmin();
            Main_Form.LoadForm(hAdmin);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new LoginForm());
        }
    }
}
