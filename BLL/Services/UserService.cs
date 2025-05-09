using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using PhoneHub.DAL.UnitOfWorks;
using PhoneHub.Models;

namespace PhoneHub.BLL.Services
{    public interface IUserService : IService<User>
    {
        User Login(string email, string password);
        User Register(User user, string password);
        bool IsEmailExists(string email);
        bool RegisterUser(string username, string password, string email);
    }

    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetAll()
        {
            return _unitOfWork.UserRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _unitOfWork.UserRepository.GetById(id);
        }

        public void Create(User user)
        {
            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.Save();
        }

        public void Update(User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Save();
        }

        public User Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            var user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == email);

            if (user != null && VerifyPasswordHash(password, user.Password))
            {
                // Update last login date
                user.LastLoginDate = DateTime.Now;
                _unitOfWork.UserRepository.Update(user);
                _unitOfWork.Save();

                return user;
            }

            return null;
        }        public User Register(User user, string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be empty");

            if (IsEmailExists(user.Email))
                throw new ArgumentException("Email already exists");

            // Hash the password
            user.Password = HashPassword(password);

            // Set default role (assume 2 is for regular users)
            user.RoleId = 2;
            
            user.Description = "New user created";

             if( user.Name == null ){ 
                user.Name = "Default Name"; // Set a default name if not provided
             }
            this.Create(user);

            return user;
        }

        public bool IsEmailExists(string email)
        {
            return _unitOfWork.UserRepository.GetAll().Any(u => u.Email == email);
        }

        public bool RegisterUser(string username, string password, string email)
        {
            if (IsEmailExists(email))
            {
                return false;
            }

            var user = new User
            {
                Email = "anhnon@gmail.com",
                Password = "password",
                PhoneNumber = "0123456789",
                RoleId = 2, // đảm bảo RoleId này phải tồn tại trong bảng Roles
                CreatedAt = DateTime.Now,
                LastLoginDate = null,
                IsActive = true,
                Description = "New user created",
                Name = username
            };
            MessageBox.Show("User created successfully", "Registration Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Create(user);
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
        }        User IUserService.Register(User user, string password)
        {
            return Register(user, password);
        }
    }
}
