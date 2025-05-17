using PhoneHub.BLL.Services;
using PhoneHub.DAL;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneHub.VIEW
{
    public partial class UserView : Form
    {
        private readonly User _user;
        private readonly IUserService _userService;

        public delegate void UserDeletedEventHandler();

        public event UserDeletedEventHandler UserDeleted;
        public UserView(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _userService = new UserService(unitOfWork);
            _user = user;
            LoadGUI();
            Style.ApplyStyleToFormControls(this);
        }

        private void deleteUser(object sender, EventArgs e)
        {
            _userService.SoftDelete(_user.Id);

            UserDeleted?.Invoke();

            this.Close();

        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadGUI()
        {
            userNameTB.Text = _user.Name;
            emailTB.Text = _user.Email;
            sdtTB.Text = _user.PhoneNumber;
            addressTB.Text = _user.Address;
            tongsotien.Text = _userService.getTotalAmount(_user.Id).ToString();
            sodonhang.Text = _userService.getTotalBooking(_user.Id).ToString();
        }

        private void sodonhang_Click(object sender, EventArgs e)
        {

        }
    }
}
