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
            Style.ApplyStyleToFormControls(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGUI()
        {
            IEnumerable<User> users = _userService.GetAllCustomer();
            userBindingSource.DataSource = users.ToList();
            userView.DataSource = users.ToList();
            totalUser.Text = _userService.CountTotalCustomer().ToString();

            if (userView.Columns.Count > 0)
            {

                // Hoặc set theo chỉ số cột (index)
                userView.Columns[0].Width = 200;  // cột đầu tiên
                userView.Columns[1].Width = 200;  // cột thứ 2
                userView.Columns[2].Width = 200;  // cột thứ 3

            }

        }

        private void viewUserDetail(object sender, EventArgs e)
        {
            if (userView.CurrentRow != null)
            {
                var selectedUser = userView.SelectedRows[0].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(selectedUser)) 
                {
                    User? user = _userService.GetAll().FirstOrDefault(u => u.Email == selectedUser);
                    if (user != null)
                    {
                        UserView userViewForm = new UserView(user);
                        userViewForm.UserDeleted += LoadGUI;
                        userViewForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
