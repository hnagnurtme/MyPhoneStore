using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PhoneHub.Models;

namespace PhoneHub.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }        
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

          
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);

          
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Bookings)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);            
            modelBuilder.Entity<Role>().HasData(
                new Role { 
                    Id = 1, 
                    Name = "Administrator", 
                    Code = "ADMIN", 
                    Description = "System Administrator",
                    CreatedAt = new DateTime(2025, 5, 9) 
                },
                new Role { 
                    Id = 2, 
                    Name = "Customer", 
                    Code = "CUSTOMER", 
                    Description = "Regular Customer",
                    CreatedAt = new DateTime(2025, 5, 9)
                }
            );
        }
    }
}
