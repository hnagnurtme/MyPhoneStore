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
    public partial class Dashboard : Form
    {
        private readonly User _user;

        private readonly IProductService _productService;

        private readonly IBookingService _bookingService;

        private readonly IUserService _userService;


        public Dashboard(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
            _bookingService = new BookingService(unitOfWork, _productService);
            _userService = new UserService(unitOfWork);
            _user = user;
            LoadGUI();
        }
        private void LoadGUI()
        {
            try
            {
                int allUsers = _userService.GetAll().Count(u => !u.IsDeleted && u.IsActive);
                customerTB.Text = allUsers.ToString();

                int allProducts = _productService.GetAll().Count(p => !p.IsDeleted && p.IsAvailable);
                productTB.Text = allProducts.ToString();

                int allBookings = _bookingService.GetAll().Count(b => !b.IsDeleted && b.Status != "Cancelled");
                bookingTB.Text = allBookings.ToString();

                decimal allRevenue = _bookingService.GetAll()
                    .Where(b => !b.IsDeleted)
                    .Sum(b => b.TotalPrice);
                doanhthuTB.Text = allRevenue.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showCustomer(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(_user);
            userDashboard.Show();
            this.Hide();
        }

        private void productShow(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(_user);
            homePage.Show();
            this.Hide();
        }

        private void showOrders(object sender, EventArgs e)
        {
            Orders orders = new Orders(_user);
            orders.Show();
            this.Hide();
        }
    }
}