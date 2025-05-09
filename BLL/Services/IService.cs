using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneHub.BLL.Services
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
