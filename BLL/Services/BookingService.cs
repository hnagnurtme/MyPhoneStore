using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;

namespace PhoneHub.BLL.Services
{
    public interface IBookingService : IService<Booking>
    {
        IEnumerable<Booking> GetBookingsByUserId(int userId);
       
        decimal CalculateBookingTotal(int productId, int quantity);

        long countTotalBooking();

        decimal countToatlAmount();
    }

    public class BookingService : Service<Booking>, IBookingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;

        public BookingService(IUnitOfWork unitOfWork, IProductService productService) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
        }

        public IEnumerable<Booking> GetBookingsByUserId(int userId)
        {
            try
            {
                return _unitOfWork.Repository<Booking>().GetAll().Where(b => b.UserId == userId && !b.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving bookings by user ID: {innerException.Message}", innerException);
            }
        }

        public IEnumerable<Booking> GetBookingsByProductId(int productId)
        {
            try
            {
                return _unitOfWork.Repository<Booking>().GetAll().Where(b => b.ProductId == productId && !b.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving bookings by product ID: {innerException.Message}", innerException);
            }
        }



        public decimal CalculateBookingTotal(int productId, int quantity)
        {
            try
            {
                if (quantity <= 0)
                    throw new ArgumentException("Quantity must be greater than zero");

                var product = _productService.GetById(productId);
                if (product == null)
                    throw new ArgumentException($"Product with ID {productId} not found");

                return product.Price * quantity;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error calculating booking total: {innerException.Message}", innerException);
            }
        }

        public new void Create(Booking booking)
        {
            try
            {
                // Validate booking
                if (booking == null)
                    throw new ArgumentNullException(nameof(booking));

                // Check if delivery date is in the future
                if (booking.DeliveryDate <= DateTime.Now)
                    throw new ArgumentException("Delivery date must be in the future");

                // Set booking date to current time if not already set
                if (booking.BookingDate == default)
                    booking.BookingDate = DateTime.Now;

                // Set default status if not provided
                if (string.IsNullOrWhiteSpace(booking.Status))
                    booking.Status = "Pending";

                // Calculate total price if not provided
                if (booking.TotalPrice <= 0)
                {
                    var product = _productService.GetById(booking.ProductId);
                    if (product != null)
                    {
                        booking.TotalPrice = product.Price;
                    }
                }

                // Update product stock
                var productToUpdate = _productService.GetById(booking.ProductId);
                if (productToUpdate != null && productToUpdate.StockQuantity > 0)
                {
                    _productService.UpdateStock(productToUpdate.Id, productToUpdate.StockQuantity - 1);
                }
                else
                {
                    throw new InvalidOperationException("Product is out of stock");
                }

                // Set creation timestamp
                booking.CreatedAt = DateTime.Now;

                base.Create(booking);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error creating booking: {innerException.Message}", innerException);
            }
        }

        public long countTotalBooking()
        {
            try
            {
                return _unitOfWork.Repository<Booking>().GetAll().Count(b => !b.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error counting total bookings: {innerException.Message}", innerException);
            }
        }

        public decimal countToatlAmount()
        {
            try
            {
                return _unitOfWork.Repository<Booking>().GetAll().Sum(b => b.TotalPrice);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error counting total amount: {innerException.Message}", innerException);
            }
        }
    }
}