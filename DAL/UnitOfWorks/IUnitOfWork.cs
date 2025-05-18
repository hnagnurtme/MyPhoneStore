using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneHub.DAL.Repositories;
using PhoneHub.Models;

namespace PhoneHub.DAL.UnitOfWorks
{    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<Product> ProductRepository { get; }
        IRepository<Booking> BookingRepository { get; }
        IRepository<T> Repository<T>() where T : class;
        void Save();

    }

}
