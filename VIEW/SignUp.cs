using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneHub.BLL;
using PhoneHub.BLL.Services;
using PhoneHub.DAL;
using PhoneHub.DAL.Repositories;
using PhoneHub.DAL.UnitOfWorks;

namespace PhoneHub.VIEW
{
    public partial class SignUp : Form
    {
        private readonly IUserService _userService;
        public SignUp()
        {
            InitializeComponent();

            // Setup dependency injection using factory
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _userService = new UserService(unitOfWork);

        }

        private void register(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            string confirmPassword = confirmPasswordTB.Text.Trim();
            string address = addressTB.Text.Trim();
            string phone = phoneTB.Text.Trim();


            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if email is valid
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check password strength
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check SDT
            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Attempt to register using BLL
                bool isRegistered = _userService.RegisterUser(username, password, email, address, phone);

                if (isRegistered)
                {
                    MessageBox.Show("Registration successful! Please login.", "Registration Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open login form
                    OpenLoginForm();
                }
                else
                {
                    MessageBox.Show("Registration failed. Username or email may already be in use.",
                        "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OpenLoginForm()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation using regex
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void changeToLogin(object sender, EventArgs e)
        {
            OpenLoginForm();
        }
    }
}

