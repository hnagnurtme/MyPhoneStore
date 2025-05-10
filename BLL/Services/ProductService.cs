// filepath: d:\PhoneHub\BLL\Services\ProductService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;

namespace PhoneHub.BLL.Services
{
    public interface IProductService : IService<Product>
    {
        IEnumerable<Product> GetAvailableProducts();
        IEnumerable<Product> SearchProducts(string searchTerm);
        IEnumerable<Product> GetProductsByBrand(string brand);
        IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);

        bool CreateOrUpdateProduct(Product product);
        Product getDistinctProductByName(string name);
        
        bool UpdateStock(int productId, int newQuantity);
        int GetStockLevel(int productId);

        public void SoftDelete(int id);
    }

    public class ProductService : Service<Product>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAvailableProducts()
        {
            try
            {
                return _unitOfWork.Repository<Product>().GetAll().Where(p => p.IsAvailable && p.StockQuantity > 0 && !p.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving available products: {innerException.Message}", innerException);
            }
        }

        public IEnumerable<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAvailableProducts();

            try
            {
                searchTerm = searchTerm.ToLower();
                return _unitOfWork.Repository<Product>().GetAll().Where(p => 
                    (p.Name.ToLower().Contains(searchTerm) || 
                     p.Description.ToLower().Contains(searchTerm) || 
                     p.Brand.ToLower().Contains(searchTerm) || 
                     p.Model.ToLower().Contains(searchTerm)) && 
                    p.IsAvailable && 
                    !p.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error searching products: {innerException.Message}", innerException);
            }
        }

        public IEnumerable<Product> GetProductsByBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
                return GetAvailableProducts();

            try
            {
                return _unitOfWork.Repository<Product>().GetAll().Where(p => 
                    p.Brand.ToLower() == brand.ToLower() && 
                    p.IsAvailable && 
                    !p.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving products by brand: {innerException.Message}", innerException);
            }
        }

        public IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            try
            {
                return _unitOfWork.Repository<Product>().GetAll().Where(p => 
                    p.Price >= minPrice && 
                    p.Price <= maxPrice && 
                    p.IsAvailable && 
                    !p.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving products by price range: {innerException.Message}", innerException);
            }
        }

        public bool UpdateStock(int productId, int newQuantity)
        {
            if (newQuantity < 0)
                throw new ArgumentException("Quantity cannot be negative");

            try
            {
                var product = GetById(productId);
                if (product == null)
                    return false;

                product.StockQuantity = newQuantity;
                
                // Update IsAvailable based on stock quantity
                product.IsAvailable = newQuantity > 0;
                
                // Set UpdatedAt timestamp
                product.UpdatedAt = DateTime.Now;
                
                _unitOfWork.Repository<Product>().Update(product);
                _unitOfWork.Save();
                
                return true;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error updating product stock: {innerException.Message}", innerException);
            }
        }

        public int GetStockLevel(int productId)
        {
            try
            {
                var product = GetById(productId);
                return product?.StockQuantity ?? 0;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving product stock level: {innerException.Message}", innerException);
            }
        }

        Product getDistinctProductByName(string name)
        {
            try
            {
                return _unitOfWork.Repository<Product>().GetAll().FirstOrDefault(p => p.Name == name && !p.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving product by name: {innerException.Message}", innerException);
            }
        }

        Product IProductService.getDistinctProductByName(string name)
        {
            return getDistinctProductByName(name);
        }

        bool CreateOrUpdateProduct(Product product)
        {
            try
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Repository<Product>().Add(product);
                }
                else
                {
                    var existingProduct = GetById(product.Id);
                    if (existingProduct == null)
                        return false;
                    existingProduct.Name = product.Name;
                    existingProduct.Description = product.Description;
                    existingProduct.Price = product.Price;
                    existingProduct.StockQuantity = product.StockQuantity;
                    existingProduct.Model = product.Model;
                    existingProduct.Brand = product.Brand;
                    existingProduct.ImageUrl = product.ImageUrl;
                    existingProduct.UpdatedAt = DateTime.Now;
                    _unitOfWork.Repository<Product>().Update(existingProduct);
                }
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error creating or updating product: {innerException.Message}", innerException);
            }
        }

        bool IProductService.CreateOrUpdateProduct(Product product)
        {
            return CreateOrUpdateProduct(product);
        }

        public void SoftDelete(int id)
        {
            try
            {
                var product = GetById(id);
                if (product == null)
                    throw new Exception($"Product with ID {id} not found.");
                product.IsDeleted = true;
                product.DeletedAt = DateTime.Now;
                _unitOfWork.Repository<Product>().Update(product);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error soft deleting product: {innerException.Message}", innerException);
            }
        }
    }
}