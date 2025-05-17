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

        public delegate void UpdateUserProfileHandler();

        public event UpdateUserProfileHandler UpdateUserProfileEvent;
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
            // Lưu lại email cũ để dùng kiểm tra mật khẩu
            string oldEmail = _user.Email;

            // Kiểm tra bắt buộc nhập liệu trước
            if (string.IsNullOrEmpty(userNameTB.Text) || string.IsNullOrEmpty(emailTB.Text) ||
                string.IsNullOrEmpty(sdtTB.Text) || string.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.Name = userNameTB.Text;
            _user.Email = emailTB.Text;
            _user.PhoneNumber = sdtTB.Text;
            _user.Address = addressTB.Text;

            if (!string.IsNullOrEmpty(newPassTB.Text))
            {
                string oldPassword = oldPassTB.Text;
                if (string.IsNullOrEmpty(oldPassword) || !_userService.IsPassWordCorrect(oldPassword, oldEmail))
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

                // Mã hóa mật khẩu mới trước khi lưu
                _user.Password = _userService.HashPassword(newPassword);
            }

            this._userService.Update(_user);
            MessageBox.Show("Update user successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateUserProfileEvent?.Invoke();
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
