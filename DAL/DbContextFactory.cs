using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PhoneHub.DAL
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private static readonly string _connectionString = "Data Source=WINDOWS-F6D8G21\\SQLEXPRESS;Initial Catalog=PHONEHUB;Integrated Security=True;TrustServerCertificate=True;";

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            var context = new ApplicationDbContext(optionsBuilder.Options);

            return context;
        }
    }
    
    public static class DbContextFactory
    {
        private static readonly string _connectionString = "Data Source=WINDOWS-F6D8G21\\SQLEXPRESS;Initial Catalog=PHONEHUB;Integrated Security=True;TrustServerCertificate=True;";

        public static ApplicationDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            var context = new ApplicationDbContext(optionsBuilder.Options);

            DbInitializer.Initialize(context);

            return context;
        }
    }
}
