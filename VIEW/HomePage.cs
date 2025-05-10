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
    public partial class HomePage : Form
    {
        private readonly IProductService _productService;

        private readonly User _user;
        public HomePage(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
            _user = user;
            ShowProducts();
            ShowUserName();
        }

        private void ShowUserName()
        {
            nameUserLB.Text = _user.Name;
        }

        private void showProfile(object sender, EventArgs e)
        {

        }

        private void sortBT(object sender, EventArgs e)
        {

        }

        private void ShowProducts()
        {

            var products = _productService.GetAvailableProducts();
            if (products == null || !products.Any())
            {
                MessageBox.Show("No products available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var product in products)
            {
                productBindingSource.Add(product);
            }

        }

        private void showDetails(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (productTB.SelectedCells.Count > 1 && productTB.SelectedCells[1]?.Value != null)
            {
                var selectedProductName = productBindingSource.Current?.GetType().GetProperty("Name")?.GetValue(productBindingSource.Current, null)?.ToString();
                if (!string.IsNullOrWhiteSpace(selectedProductName))
                {
                    Product selectedProduct = _productService.getDistinctProductByName(selectedProductName);
                    if (selectedProduct != null)
                    {
                        var productDetailsForm = new ProductDetail(selectedProduct, _user);
                        productDetailsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please select a product to view details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selected product name is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to view details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void allBooking(object sender, EventArgs e)
        {

        }
    }
}
