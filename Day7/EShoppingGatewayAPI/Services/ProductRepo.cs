using EShoppingGatewayAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingGatewayAPI.Services
{
    public class ProductRepo : IRepo<int, Product>
    {
        private readonly ShoppingContext _context;
        private readonly ILogger<ProductRepo> _logger;

        public ProductRepo(ShoppingContext context,ILogger<ProductRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<Product> Add(Product item)
        {
            try
            {
                _context.Products.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                _logger.LogError("Eror in adding product");
            }
            return null;
        }

        public async Task<Product> Delete(int key)
        {
            try
            {
                var item = await Get(key);
                _context.Products.Remove(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                _logger.LogError("Eror in deleting product");
            }
            return null;
        }

        public async Task<Product> Get(int key)
        {
            try
            {
                var item =  _context.Products.FirstOrDefault(p=>p.Id==key);
               
                return item;
            }
            catch (Exception e)
            {
                _logger.LogError("Eror in Getting product");
            }
            return null;
        }

        public async Task<ICollection<Product>> GetAll()
        {
            return _context.Products.ToList();
        }

        public async Task<Product> Update(Product item)
        {
            try
            {
                var product = await Get(item.Id);
                product.Quantity = item.Quantity;
                product.Price = item.Price;
                product.Name = item.Name;
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                _logger.LogError("Eror in updating product");
            }
            return null;
        }
    }
}
