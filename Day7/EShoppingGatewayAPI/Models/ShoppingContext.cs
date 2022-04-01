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
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShipLocation> ShipLocations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Sationary"
            });
            modelBuilder.Entity<Product>().HasData(new Product { 
                Id=101,
                Name="Pencil",
                Price=12.5f,
                Quantity=10,
                CategoryId=1
            });
            modelBuilder.Entity<ShipLocation>().HasData(new ShipLocation()
            {
                Location = "Abc",
                ProductId = 101,
                ShipDuration = 5
            });
          
        }
    }
}
