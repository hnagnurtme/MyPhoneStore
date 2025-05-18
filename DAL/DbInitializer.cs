using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using PhoneHub.Models;

namespace PhoneHub.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if the database already has data
            if (context.Users.Any())
            {
                return; // Database has been seeded already
            }

            // Add admin user
            var adminUser = new User
            {
                Name = "Administrator",
                Email = "admin@phonehub.com",
                Password = HashPassword("admin123"),
                PhoneNumber = "1234567890",
                Address = "Admin Office, PhoneHub HQ",
                RoleId = 1, // Admin role
                CreatedAt = new DateTime(2025, 5, 10),
                IsActive = true
            };
            context.Users.Add(adminUser);

            // Add demo customer
            var customer = new User
            {
                Name = "Demo Customer",
                Email = "customer@phonehub.com",
                Password = HashPassword("customer123"),
                PhoneNumber = "0987654321",
                Address = "123 Customer Street",
                RoleId = 2, // Customer role
                CreatedAt = new DateTime(2025, 5, 10),
                IsActive = true
            };
            context.Users.Add(customer);

            // Add products
            var products = new List<Product>
            {
                new Product
                {
                    Name = "iPhone 15 Pro Max",
                    Description = "Latest Apple flagship smartphone with A17 Pro chip and advanced camera system",
                    Model = "iPhone 15 Pro Max",
                    Brand = "Apple",
                    Price = 1199.99M,
                    StockQuantity = 50,
                    ImageUrl = "/Resources/iphone15promax.jpg",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 5, 10)
                },
                new Product
                {
                    Name = "Samsung Galaxy S25 Ultra",
                    Description = "Samsung flagship with 200MP camera and advanced AI features",
                    Model = "Galaxy S25 Ultra",
                    Brand = "Samsung",
                    Price = 1099.99M,
                    StockQuantity = 40,
                    ImageUrl = "/Resources/s25ultra.jpg",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 5, 10)
                },
                new Product
                {
                    Name = "Google Pixel 9 Pro",
                    Description = "Google flagship with the best smartphone camera and pure Android experience",
                    Model = "Pixel 9 Pro",
                    Brand = "Google",
                    Price = 999.99M,
                    StockQuantity = 30,
                    ImageUrl = "/Resources/pixel9pro.jpg",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 5, 10)
                },
                new Product
                {
                    Name = "OnePlus 13 Pro",
                    Description = "Flagship killer with Snapdragon 8 Gen 4 processor and 120Hz display",
                    Model = "OnePlus 13 Pro",
                    Brand = "OnePlus",
                    Price = 899.99M,
                    StockQuantity = 25,
                    ImageUrl = "/Resources/oneplus13pro.jpg",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 5, 10)
                },
                new Product
                {
                    Name = "Xiaomi 15",
                    Description = "High-performance smartphone with excellent price-performance ratio",
                    Model = "Xiaomi 15",
                    Brand = "Xiaomi",
                    Price = 799.99M,
                    StockQuantity = 35,
                    ImageUrl = "/Resources/xiaomi15.jpg",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 5, 10)
                }
            };

            context.Products.AddRange(products);

           
            context.SaveChanges();
        }

        // Helper method to hash passwords
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convert the string to a byte array first, to be hashed
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                
                // Hash the password
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                
                // Convert the hashed bytes back to a string
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
