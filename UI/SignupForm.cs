using abog.DBAccess;
using abog.Models;
using System;
using System.Windows.Forms;

namespace abog.UI
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new homePage());
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form.LoadForm(new LoginForm());
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccess uAccess = new UserAccess();

                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();

                //DEBUG: show input values
                MessageBox.Show(
                    $"DEBUG INPUT:\n{firstName}\n{lastName}\n{email}\n{phoneNumber}"
                );

                // basic validation
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Please enter email and phone number.");
                    return;
                }

                Users u = new Users(firstName, lastName, email, password, phoneNumber);

                bool success = uAccess.addUser(u);

                if (success)
                {
                    MessageBox.Show("User registered successfully!");
                }
                else
                {
                    MessageBox.Show("User already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}