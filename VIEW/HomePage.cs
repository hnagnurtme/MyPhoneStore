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
            string searchName = "ALL";
            ShowProducts(searchName);
            ShowUserName();
        }

        private void ShowUserName()
        {
            nameUserLB.Text = _user.Name;
        }

        private void showProfile(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(_user);
            userProfile.ShowDialog();
        }

        private void sortBT(object sender, EventArgs e)
        {
            string sortBy = sortByCBB.SelectedText;
            string sortOrder = sortOrderCBB.SelectedText;
            sort(sortOrder == "ASC", sortBy);
        }

        private void ShowProducts(String searchName)
        {
            if (string.IsNullOrWhiteSpace(searchName))
            {
                searchName = "ALL";
            }
            if (searchName == "ALL")
            {
                var products = _productService.GetAvailableProducts();
                if (products == null || !products.Any())
                {
                    MessageBox.Show("No products available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                productBindingSource.Clear();
                foreach (var product in products)
                {
                    productBindingSource.Add(product);
                }
            }
            else
            {
                var products = _productService.SearchProducts(searchName);
                if (products == null || !products.Any())
                {
                    MessageBox.Show("No products found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                productBindingSource.Clear();
                foreach (var product in products)
                {

                    productBindingSource.Add(product);
                }
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
                        //var productDetailsForm = new ProductDetail(selectedProduct, _user);
                        //productDetailsForm.ShowDialog();
                        if (_user.RoleId == 2)
                        {
                            ProductDetail productDetailsForm = new ProductDetail(selectedProduct, _user);
                            productDetailsForm.ShowDialog();
                        }
                        else
                        {                            if (_user.RoleId == 1)
                            {
                                CreateProduct productDetailsForm = new CreateProduct(selectedProduct);
                                
                                // Capture the current search text
                                string currentSearch = searchName.Text;
                                
                                // Subscribe to the ProductChanged event
                                productDetailsForm.ProductChanged += () => ShowProducts(currentSearch);
                                
                                productDetailsForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("You do not have permission to view this product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

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

        private void changeOrder(object sender, EventArgs e)
        {

        }

        private void search(object sender, EventArgs e)
        {
            ShowProducts(searchName.Text);
        }

        private void reset(object sender, EventArgs e)
        {
            ShowProducts("ALL");
        }

        private void sort(bool ascending, string sortBy)
        {
            switch (sortBy)
            {
                case "PRICE":
                    if (ascending)
                    {
                        productBindingSource.DataSource = _productService.GetAvailableProducts().OrderBy(p => p.Price).ToList();
                    }
                    else
                    {
                        productBindingSource.DataSource = _productService.GetAvailableProducts().OrderByDescending(p => p.Price).ToList();
                    }
                    break;
                case "STOCK":
                    if (ascending)
                    {
                        productBindingSource.DataSource = _productService.GetAvailableProducts().OrderBy(p => p.StockQuantity).ToList();
                    }
                    else
                    {
                        productBindingSource.DataSource = _productService.GetAvailableProducts().OrderByDescending(p => p.StockQuantity).ToList();
                    }
                    break;
            }

        }        private void addProduct(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CreateProduct createProduct = new CreateProduct(new Product());
            
            // Capture the current search text
            string currentSearch = searchName.Text;
            
            // Subscribe to the ProductChanged event
            createProduct.ProductChanged += () => ShowProducts(currentSearch);
            
            createProduct.ShowDialog();
        }
    }
}
