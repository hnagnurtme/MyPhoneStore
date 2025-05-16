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
    public partial class BookingDetail : Form
    {
        private readonly IBookingService _bookingService;
        private readonly IProductService _productService;
        private readonly Product _product;
        private int count = 1;
        private readonly User _user;
        public BookingDetail(Product product, User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
            _bookingService = new BookingService(unitOfWork, _productService);
            _product = product;
            _user = user;
            LoadGUI();
            Style.ApplyModernStyleToControl(this);
        }

        private void confirmBooking(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("Please fill in all fields", "Booking Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (deliveryTB.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a future delivery date", "Booking Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(noteTB.Text))
            {
                MessageBox.Show("Please enter a note", "Booking Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Booking booking = new Booking
            {
                Name = $"Booking for {_product.Name}",
                Description = $"Customer order for {_product.Model}",
                UserId = _user.Id,
                ProductId = _product.Id,
                BookingDate = DateTime.Now,
                DeliveryDate = deliveryTB.Value,
                ShippingAddress = addressTB.Text,
                TotalPrice = _product.Price * count,
                Notes = noteTB.Text,
                Status = "Pending",
                CreatedAt = DateTime.Now
            };

            try
            {
                _bookingService.Create(booking);
                MessageBox.Show("Booking created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                HomePage homePage = new HomePage(_user);
                homePage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Booking Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadGUI()
        {
            nameTB.Text = _user.Name;
            addressTB.Text = _user.Address;
            nameProductTB.Text = _product.Name;
            try
            {
                productPic.Image = Image.FromFile(_product.ImageUrl);
            }
            catch (Exception ex)
            {
                productPic.Image = Properties.Resources.anhdt1;
            }
            totalTB.Text = _product.Price.ToString("C");
            countCBB.Items.AddRange(Enumerable.Range(1, _product.StockQuantity).Select(i => i.ToString()).ToArray());

        }

        private void changeCount(object sender, EventArgs e)
        {

            count = int.Parse(countCBB.SelectedItem.ToString());
            totalTB.Text = (_product.Price * count).ToString("C");
        }
    }
}
