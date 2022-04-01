using EShoppingGatewayAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingGatewayAPI.Services
{
    public class SearchService : ISearch
    {
        private readonly ShoppingContext _context;

        public SearchService(ShoppingContext context)
        {
            _context = context;
        }
        public async Task<ICollection<ProductDetailsDTO>> GetProductsByCategory(SearchDTO DTO)
        {
           var products = new List<ProductDetailsDTO>();
            var category = _context.Categories.FirstOrDefault(c => c.Name == DTO.CategoryName);
            var user = _context.Users.FirstOrDefault(u=>u.Username==DTO.Username);
            if (user == null)
                return null;
            var location = user.Location;
            if (category == null)
                return null;
            var categoryId = category.Id;
            var MyProducts = _context.Products.Where(p => p.CategoryId == categoryId).Include(pr=>pr.Category).ToList();
            foreach (var product in MyProducts)
            {
                var shipLocation = _context.ShipLocations.FirstOrDefault(sl => sl.ProductId == product.Id && sl.Location==location);
                if (shipLocation == null)
                    break;
                var myProduct = new ProductDetailsDTO();
                myProduct.ProductId = product.Id;
                myProduct.CategoryName = product.Category.Name;
                myProduct.Price = product.Price;
                myProduct.ExpectedDays = shipLocation.ShipDuration;
                myProduct.Quantity = product.Quantity;
                myProduct.ProductName = product.Name;
                products.Add(myProduct);
            }
            return products;
        }
    }
}
