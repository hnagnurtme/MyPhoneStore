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
            Style.ApplyStyleToFormControls(this);
        }
        private void LoadGUI()
        {
            try
            {
                long allUsers = _userService.CountTotalCustomer();
                customerTB.Text = allUsers.ToString();

                long allProducts = _productService.countTotalProduct();
                productTB.Text = allProducts.ToString();

                long allBookings = _bookingService.countTotalBooking();
                bookingTB.Text = allBookings.ToString();

                decimal allRevenue = _bookingService.countToatlAmount();
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
            userDashboard.ShowDialog();
        }

        private void showOrders(object sender, EventArgs e)
        {
            Orders orders = new Orders(_user);
            orders.ShowDialog();
        }

        private void showProducts(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(_user);
            homePage.ShowDialog();
        }
    }
}