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
        private IProductService _productService;

        private readonly User _user;
        public HomePage(User user)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);            
            _productService = new ProductService(unitOfWork);
            _user = user;
            ShowProducts("ALL");
            ShowUserName();
        }

        private void ShowUserName()
        {
            nameUserLB.Text = _user.Name;
            if( _user.RoleId == 2)
            {
               addBT.Visible = false;
            }
        }

        private void showProfile(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(_user);
            userProfile.ShowDialog();
        }        private void sortBT(object sender, EventArgs e)
        {
            string sortBy = sortByCBB.SelectedItem?.ToString() ?? "PRICE";
            string sortOrder = sortOrderCBB.SelectedItem?.ToString() ?? "ASC";
            sort(sortOrder == "ASC", sortBy);
        }        
        private void ShowProducts(String searchTerm)
        {
            try
            {
                RefreshProductService();
                // Reset and recreate the binding source
                if (productBindingSource == null)
                {
                    productBindingSource = new BindingSource();
                }
                else
                {
                    productBindingSource.Clear();
                }
                
                // Reset the data source
                productTB.DataSource = null;
                
                // Handle empty search
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    searchTerm = "ALL";
                }
                
                // Get products based on search term
                IEnumerable<Product> products;
                if (searchTerm == "ALL")
                {
                    products = _productService.GetAvailableProducts();
                }
                else
                {
                    products = _productService.SearchProducts(searchTerm);
                }
                
                // Check if we have any results
                if (products == null || !products.Any())
                {
                    if (searchTerm == "ALL")
                    {
                        MessageBox.Show("No products available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No products found with your search criteria", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    productTB.DataSource = productBindingSource;
                    return;
                }
                
                // Filter out deleted products and add to binding source
                foreach (var product in products.Where(p => !p.IsDeleted))
                {
                    productBindingSource.Add(product);
                }
                
                // Set the data source
                productTB.DataSource = productBindingSource;
                
                // If no results after filtering deleted products
                if (productBindingSource.Count == 0)
                {
                    MessageBox.Show("No active products found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (_user.RoleId == 2)
                        {
                            ProductDetail productDetailsForm = new ProductDetail(selectedProduct, _user);
                            productDetailsForm.ShowDialog();
                        }
                        else
                        {                            if (_user.RoleId == 1)                            {
                                CreateProduct productDetailsForm = new CreateProduct(selectedProduct);
                                  // Subscribe to the ProductChanged event to refresh the current view
                                string currentSearch = string.IsNullOrWhiteSpace(searchName.Text) ? "ALL" : searchName.Text;
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

        }        private void search(object sender, EventArgs e)
        {
            // Check if search box is empty
            string searchTerm = string.IsNullOrWhiteSpace(searchName.Text) ? "ALL" : searchName.Text;
            ShowProducts(searchTerm);
        }

        private void reset(object sender, EventArgs e)
        {
            // Clear the search box
            searchName.Clear();
            
            // Reset to show all products
            ShowProducts("ALL");
        }private void sort(bool ascending, string sortBy)
        {
            // Get the current search term
            string searchTerm = string.IsNullOrEmpty(searchName.Text) ? "ALL" : searchName.Text;
            
            // Get the products based on current search
            IEnumerable<Product> products;
            if (searchTerm == "ALL")
            {
                products = _productService.GetAvailableProducts().Where(p => !p.IsDeleted);
            }
            else
            {
                products = _productService.SearchProducts(searchTerm).Where(p => !p.IsDeleted);
            }
            
            // Apply sorting
            switch (sortBy)
            {
                case "PRICE":
                    products = ascending 
                        ? products.OrderBy(p => p.Price) 
                        : products.OrderByDescending(p => p.Price);
                    break;
                    
                case "STOCK":
                    products = ascending 
                        ? products.OrderBy(p => p.StockQuantity) 
                        : products.OrderByDescending(p => p.StockQuantity);
                    break;
                    
                default:
                    products = ascending 
                        ? products.OrderBy(p => p.Name) 
                        : products.OrderByDescending(p => p.Name);
                    break;
            }
            
            // Update the binding source
            productBindingSource.Clear();
            foreach (var product in products)
            {
                productBindingSource.Add(product);
            }
        }        private void addProduct(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(new Product());
            
            // Subscribe to the ProductChanged event to refresh the current view
            string currentSearch = string.IsNullOrWhiteSpace(searchName.Text) ? "ALL" : searchName.Text;
            createProduct.ProductChanged += () => ShowProducts(currentSearch);
            
            createProduct.ShowDialog();
        }

        private void RefreshProductService()
        {
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
        }
    }
}
