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
    public partial class CreateProduct : Form
    {
        private readonly Product _product;        
        private readonly IProductService _productService;

        public delegate void ProductHandler();

        public event ProductHandler ProductChanged;


        public CreateProduct(Product product)
        {
            InitializeComponent();
            var context = DbContextFactory.CreateDbContext();
            var unitOfWork = new UnitOfWork(context);
            _productService = new ProductService(unitOfWork);
            _product = product;
            LoadGUI();
            Style.ApplyStyleToFormControls(this);
        }

        private void confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameProductTB.Text) ||
                string.IsNullOrEmpty(descriptionTB.Text) ||
                string.IsNullOrEmpty(priceTB.Text) ||
                string.IsNullOrEmpty(stockTB.Text) ||
                string.IsNullOrEmpty(modelTB.Text) ||
                string.IsNullOrEmpty(brandTB.Text) ||
                string.IsNullOrEmpty(imageTB.Text))
            {
                MessageBox.Show("Please fill in all fields", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(priceTB.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(stockTB.Text, out int stock))
            {
                MessageBox.Show("Invalid stock format", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (stock < 0)
            {
                MessageBox.Show("Stock quantity cannot be negative", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _product.Name = nameProductTB.Text;
            _product.Description = descriptionTB.Text;
            _product.Price = price;
            _product.StockQuantity = stock;
            _product.Model = modelTB.Text;
            _product.Brand = brandTB.Text;
            _product.ImageUrl = imageTB.Text;
            bool result = this._productService.CreateOrUpdateProduct(_product);            if (result)
            {
                MessageBox.Show("Product created successfully", "Create Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Notify subscribers that product was changed
                ProductChanged?.Invoke();
                
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Failed to create product", "Create Product Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGUI()
        {
            nameProductTB.Text = _product.Name;
            descriptionTB.Text = _product.Description;
            priceTB.Text = _product.Price.ToString();
            stockTB.Text = _product.StockQuantity.ToString();
            modelTB.Text = _product.Model;
            brandTB.Text = _product.Brand;
            imageTB.Text = _product.ImageUrl;

            try
            {
                productPic.Image = Image.FromFile(_product.ImageUrl);
            }
            catch (Exception ex)
            {
                productPic.Image = Properties.Resources.anhdt1;
            }
            if (_product.Id != 0)
            {
                deleteBT.Visible = true;
               
            }
            else
            {
                deleteBT.Visible = false;
            }
        }

        private void delete(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {                
                try
                {
                    _productService.SoftDelete(_product.Id);
                    MessageBox.Show("Product deleted successfully", "Delete Product",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ProductChanged?.Invoke();
                    
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete product: {ex.Message}", "Delete Product Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Product deletion cancelled", "Delete Product",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }

}
