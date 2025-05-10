// filepath: d:\PhoneHub\BLL\Services\BookingService.cs
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
        IEnumerable<Booking> GetBookingsByProductId(int productId);
        IEnumerable<Booking> GetBookingsByStatus(string status);
        IEnumerable<Booking> GetBookingsByDateRange(DateTime startDate, DateTime endDate);
        bool UpdateBookingStatus(int bookingId, string status);
        bool CancelBooking(int bookingId);
        decimal CalculateBookingTotal(int productId, int quantity);
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

        public IEnumerable<Booking> GetBookingsByStatus(string status)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(status))
                    return _unitOfWork.Repository<Booking>().GetAll().Where(b => !b.IsDeleted);

                return _unitOfWork.Repository<Booking>().GetAll().Where(b => b.Status == status && !b.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving bookings by status: {innerException.Message}", innerException);
            }
        }

        public IEnumerable<Booking> GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return _unitOfWork.Repository<Booking>().GetAll().Where(b => 
                    b.BookingDate >= startDate && 
                    b.BookingDate <= endDate && 
                    !b.IsDeleted);
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving bookings by date range: {innerException.Message}", innerException);
            }
        }

        public bool UpdateBookingStatus(int bookingId, string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("Status cannot be null or empty");

            try
            {
                var booking = GetById(bookingId);
                if (booking == null)
                    return false;

                booking.Status = status;
                booking.UpdatedAt = DateTime.Now;

                _unitOfWork.Repository<Booking>().Update(booking);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error updating booking status: {innerException.Message}", innerException);
            }
        }

        public bool CancelBooking(int bookingId)
        {
            try
            {
                var booking = GetById(bookingId);
                if (booking == null)
                    return false;

                // Check if booking is already delivered or cancelled
                if (booking.Status == "Delivered" || booking.Status == "Cancelled")
                    return false;

                booking.Status = "Cancelled";
                booking.UpdatedAt = DateTime.Now;

                _unitOfWork.Repository<Booking>().Update(booking);
                _unitOfWork.Save();

                // Increase stock quantity for the product
                var product = _productService.GetById(booking.ProductId);
                if (product != null)
                {
                    _productService.UpdateStock(product.Id, product.StockQuantity + 1);
                }

                return true;
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error cancelling booking: {innerException.Message}", innerException);
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
    }
}