using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PhoneHub.BLL.Services;
using PhoneHub.DAL;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;
using User = PhoneHub.Models.User;


namespace PhoneHub.VIEW
{
    public partial class Orders : Form
    {
        private readonly Models.User _user;

        private readonly IProductService _productService;

        private readonly IBookingService _bookingService;
        public Orders(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
            _bookingService = new BookingService(unitOfWork, _productService);
            _user = user;
            LoadGUI();
            Style.ApplyStyleToFormControls(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGUI()
        {
            if( _user.RoleId == 1)
            {
                bookingBindingSource.DataSource = _bookingService.GetAll().ToList();
                bookingView.DataSource = bookingBindingSource;

                toatlRevue.Text = _bookingService.countToatlAmount().ToString("C");

                totalOrders.Text = _bookingService.countTotalBooking().ToString();

                bookingView.Columns[0].Width = 100;
                bookingView.Columns[1].Width = 200;
                bookingView.Columns[2].Width = 200;
                bookingView.Columns[3].Width = 200;
                bookingView.Columns[4].Width = 200;
                bookingView.Columns[5].Width = 300;

            }
            else
            {
                tong.Text = "Tong so tien da mua";
                toatlRevue.Text = _bookingService.GetBookingsByUserId(_user.Id)
                    .Sum(b => b.TotalPrice).ToString("C");

                bookingBindingSource.DataSource = _bookingService.GetBookingsByUserId(_user.Id).ToList();
                bookingView.DataSource = bookingBindingSource;

                totalOrders.Text = _bookingService.GetBookingsByUserId(_user.Id).ToList()
                    .Count(b => !b.IsDeleted && b.Status != "Cancelled").ToString();

                bookingView.Columns[0].Width = 100;
                bookingView.Columns[1].Width = 200;
                bookingView.Columns[2].Width = 200;
                bookingView.Columns[3].Width = 200;
                bookingView.Columns[4].Width = 200;
                bookingView.Columns[5].Width = 300;

            }
            
        }

    }
}
