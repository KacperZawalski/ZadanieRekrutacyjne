using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public sealed class AppDbContext() : DbContext
    {
        private const string DbName = "StoreDb";
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(DbName);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
