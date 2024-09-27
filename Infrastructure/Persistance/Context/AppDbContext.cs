using System.Reflection;
using Api.Domain.Commen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context 
{
    public class AppDbContext : DbContext
    {
   
     
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=testapi;Password=12345;Host=localhost;Port=5432;Database=testapi;Pooling=true;Connection Lifetime=0;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Brand> Brands { get; set; }

   
    }
}