using abog.Models;
using abog.Service;
using abog.Services;
using abog.UI;

namespace abog.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            Authentication auth = new Authentication();
            Users user = auth.Login(email, password);

            if (user != null)
            {
                CurrentUser.User = user;

                homePage home = new homePage();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }


            MessageBox.Show($"Welcome {user.firstName}");            
            BookServiceForm1 book1 = new BookServiceForm1();
            book1.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new homePage());
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new SignupForm());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Main_Form.LoadForm(new LoginAdmin());
        }
    }
}
