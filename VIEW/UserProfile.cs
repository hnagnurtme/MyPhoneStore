using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneHub.BLL.Services;
using PhoneHub.DAL;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;

namespace PhoneHub.VIEW
{
    public partial class UserProfile : Form
    {
        private readonly IUserService _userService;

        private readonly User _user;
        public UserProfile(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _userService = new UserService(unitOfWork);
            _user = user;
            LoadGUI();
            Style.ApplyStyleToFormControls(this);

        }

        private void updateProfile(object sender, EventArgs e)
        {
            _user.Name = userNameTB.Text;
            _user.Email = emailTB.Text;
            _user.PhoneNumber = sdtTB.Text;
            _user.Address = addressTB.Text;
            if (!string.IsNullOrEmpty(newPassTB.Text))
            {
                string oldPassword = oldPassTB.Text;
                // Check if the old password is correct
                if (string.IsNullOrEmpty(oldPassword) || !_userService.IsPassWordCorrect(_user.Email,oldPassword))
                {
                    MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string newPassword = newPassTB.Text;
                string confirmPassword = newPassCFTB.Text;
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _user.Password = newPassword;
            }
            if (string.IsNullOrEmpty(_user.Name) || string.IsNullOrEmpty(_user.Email) || string.IsNullOrEmpty(_user.PhoneNumber) || string.IsNullOrEmpty(_user.Address))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this._userService.Update(_user);
            this.Close();
        }

        private void LoadGUI()
        {
            if (_user == null)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            userNameTB.Text = _user.Name;
            emailTB.Text = _user.Email;
            sdtTB.Text = _user.PhoneNumber;
            addressTB.Text = _user.Address;
        }
    }
}
