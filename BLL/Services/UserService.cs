using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;
using System.Windows.Forms; 

namespace PhoneHub.BLL.Services
{
    public interface IUserService : IService<User>
    {
        User Login(string email, string password);
        bool IsEmailExists(string email);

        bool IsPassWordCorrect(string password, string email);
        
        bool RegisterUser(string username, string password, string email, string address, string phone);

        IEnumerable<User> GetAllUserAndRole();
    }

    public class UserService : Service<User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public User Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            var user = _unitOfWork.UserRepository
                .GetAll()
                .FirstOrDefault(u => u.Email == email);

            if (user != null && VerifyPasswordHash(password, user.Password))
            {
                user.LastLoginDate = DateTime.Now;
                _unitOfWork.UserRepository.Update(user);
                _unitOfWork.Save();
                return user;
            }

            return null;
        }

        public bool IsEmailExists(string email)
        {
            return _unitOfWork.UserRepository
                .GetAll()
                .Any(u => u.Email == email);
        }

        public bool RegisterUser(string username, string password, string email, string address, string phone)
        {
            if (IsEmailExists(email))
            {
                return false;
            }

            string hashedPassword = HashPassword(password);

            var user = new User
            {
                Name = username,
                Email = email,
                Password = hashedPassword,
                PhoneNumber = phone,
                Address = address,
                RoleId = 2, // mặc định là user
                CreatedAt = DateTime.Now,
                LastLoginDate = null,
                IsActive = true,
                IsDeleted = false,
                Description = "New user created"
            };

            Create(user);

            MessageBox.Show("User created successfully", "Registration Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            var hashOfInput = HashPassword(password);
            return hashOfInput == storedHash;
        }
        public bool IsPassWordCorrect(string password, string email)
        {
            var user = _unitOfWork.UserRepository
                .GetAll()
                .FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return VerifyPasswordHash(password, user.Password);
            }
            return false;

        }

        IEnumerable<User> GetAllUserAndRole()
        {
            var users = _unitOfWork.UserRepository.GetAll();
            var roles = _unitOfWork.RoleRepository.GetAll();
            var userWithRole = from user in users
                               join role in roles on user.RoleId equals role.Id
                               select new User
                               {
                                   Id = user.Id,
                                   Name = user.Name,
                                   Email = user.Email,
                                   PhoneNumber = user.PhoneNumber,
                                   Address = user.Address,
                                   RoleId = role.Id,
                                   Role = role,
                                   CreatedAt = user.CreatedAt,
                                   LastLoginDate = user.LastLoginDate,
                                   IsActive = user.IsActive
                               };
            return userWithRole.ToList();
        }

        IEnumerable<User> IUserService.GetAllUserAndRole()
        {
            return GetAllUserAndRole();
        }
    }
}
