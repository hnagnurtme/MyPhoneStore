using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneHub.Models;

namespace PhoneHub.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Check if roles already exist
            if (context.Set<Role>().Any())
            {
                return; // Database has been seeded
            }

            // Add default roles
            var roles = new Role[]
            {
                new Role{ Name = "Admin", Description = "Administrator with full access" },
                new Role{ Name = "User", Description = "Regular user with limited access" }
            };

            foreach (var role in roles)
            {
                context.Set<Role>().Add(role);
            }

            context.SaveChanges();

            // Add a default admin user if needed
            if (!context.Set<User>().Any())
            {
                var adminUser = new User
                {
                    Email = "admin@example.com",
                    Password = HashPassword("admin123"), // This should be hashed
                    PhoneNumber = "1234567890",
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    RoleId = 1 // Admin role
                };

                context.Set<User>().Add(adminUser);
                context.SaveChanges();
            }
        }

        private static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
