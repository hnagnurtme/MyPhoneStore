using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace PhoneHub.DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet
                .Where(e => !EF.Property<bool>(e, "IsDeleted"))
                .ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            var key = _context.Model.FindEntityType(typeof(TEntity)).FindPrimaryKey().Properties.FirstOrDefault();
            if (key == null)
                throw new Exception("Không tìm thấy khóa chính.");

            var keyValue = key.PropertyInfo.GetValue(entity);
            var existing = _dbSet.Local.FirstOrDefault(e =>
                key.PropertyInfo.GetValue(e).Equals(keyValue));

            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
            }
            else
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
