using PhoneHub.BLL.Services;
using PhoneHub.DAL;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.VIEW;

namespace PhoneHub
{
    public partial class Login : Form
    {
        private readonly IUserService _userService;
        public Login()
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _userService = new UserService(unitOfWork);
        }

        private void login(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Attempt to login using BLL
            var user = _userService.Login(email, password);
            if (user != null)
            {
                HomePage mainForm = new HomePage(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void changeToRegister(object sender, EventArgs e)
        {
            OpenSingUpForm();

        }

        private void OpenSingUpForm()
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
