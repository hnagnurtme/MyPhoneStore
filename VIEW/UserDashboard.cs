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
    public partial class UserDashboard : Form
    {
        private readonly User _user;

        private readonly IUserService _userService;

        public UserDashboard(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _userService = new UserService(unitOfWork);
            _user = user;
            LoadGUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGUI()
        {
            IEnumerable<User> users = _userService.GetAll();
            userBindingSource.DataSource = users.ToList();
            userView.DataSource = users.ToList();
            totalUser.Text = users.Count(u => !u.IsDeleted && u.IsActive).ToString();

        }
    }
}
