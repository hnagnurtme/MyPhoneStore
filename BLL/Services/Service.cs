using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Đã loại bỏ System.Threading.Tasks
using PhoneHub.BLL.DTOs;
using System.Windows.Forms.Design;
using PhoneHub.DAL.UnitOfWorks;

namespace PhoneHub.BLL.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }        public IEnumerable<T> GetAll()
        {
            try
            {
                return _unitOfWork.Repository<T>().GetAll();
            }
            catch (Exception ex)
            {
                // Lấy inner exception nếu có
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving entities: {innerException.Message}", innerException);
            }
        }

        public T GetById(int id)
        {
            try
            {
                var entity = _unitOfWork.Repository<T>().GetById(id);
                if (entity == null)
                {
                    throw new Exception($"Entity with ID {id} not found.");
                }
                return entity;
            }
            catch (Exception ex)
            {
                // Lấy inner exception nếu có
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error retrieving entity with ID {id}: {innerException.Message}", innerException);
            }
        }public void Create(T entity)
        {
            try
            {
                _unitOfWork.Repository<T>().Add(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                // Lấy inner exception nếu có
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error creating entity: {innerException.Message}", innerException);
            }
        }

        public void Update(T entity)
        {
            try
            {
                _unitOfWork.Repository<T>().Update(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                // Lấy inner exception nếu có
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error updating entity: {innerException.Message}", innerException);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _unitOfWork.Repository<T>().Delete(id);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                // Lấy inner exception nếu có
                var innerException = ex.InnerException ?? ex;
                throw new Exception($"Error deleting entity: {innerException.Message}", innerException);
            }
        }
    }

}
