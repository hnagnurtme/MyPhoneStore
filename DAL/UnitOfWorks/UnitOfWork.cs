using System;
using System.Collections.Generic;

// Loại bỏ System.Threading.Tasks
using PhoneHub.DAL.Repositories;
using PhoneHub.Models;

namespace PhoneHub.DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repositories = new Dictionary<Type, object>();
        }        public IRepository<User> UserRepository => GetRepository<User>();
        public IRepository<Role> RoleRepository => GetRepository<Role>();
        public IRepository<Product> ProductRepository => GetRepository<Product>();
        public IRepository<Booking> BookingRepository => GetRepository<Booking>();

        public IRepository<T> Repository<T>() where T : class => GetRepository<T>();

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);

            if (!_repositories.TryGetValue(type, out object repository))
            {
                repository = new GenericRepository<T>(_context);
                _repositories[type] = repository;
            }            return (IRepository<T>)repository;
        }
        
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Capture full exception stack for debugging
                var fullMessage = GetFullExceptionMessage(ex);
                Console.WriteLine($"Database save error: {fullMessage}");
                throw; // Re-throw after logging to preserve stack trace
            }
        }
        
        private string GetFullExceptionMessage(Exception ex)
        {
            var message = ex.Message;
            if (ex.InnerException != null)
            {
                message += " -> " + GetFullExceptionMessage(ex.InnerException);
            }
            return message;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        // Đã loại bỏ các phương thức DisposeAsync và DisposeAsyncCore
    }
}
