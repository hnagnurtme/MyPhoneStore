using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneHub.Models;

namespace PhoneHub.VIEW
{
    public partial class ProductDetail : Form
    {
        private readonly Product _product;

        private readonly User _user;
        public ProductDetail(Product product, User user)
        {
            InitializeComponent();
            _product = product;
            _user = user;
            ProductDetail_Load();

            Style.ApplyStyleToFormControls(this);
        }

        private void ProductDetail_Load()
        {
            nameLB.Text = _product.Name;
            descriprionLB.Text = _product.Description;
            priceLB.Text = _product.Price.ToString("C");
            stockLB.Text = _product.StockQuantity.ToString();
            try
            {
                productPic.Image = Image.FromFile(_product.ImageUrl);
            }
            catch (Exception ex)
            {
                productPic.Image = Properties.Resources.anhdt1;
            }

        }

        private void order(object sender, EventArgs e)
        {
            BookingDetail booking = new BookingDetail(_product, _user);
            booking.ShowDialog();
        }

        private void backClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
