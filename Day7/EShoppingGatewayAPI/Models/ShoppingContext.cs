using Microsoft.EntityFrameworkCore;

namespace EShoppingGatewayAPI.Models
{
    public class ShoppingContext:DbContext
    {
        public ShoppingContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product { Id=101,Name="Pencil",Price=12.5f,Quantity=10});
        }
    }
}
