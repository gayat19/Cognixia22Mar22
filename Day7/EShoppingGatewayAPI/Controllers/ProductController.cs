using EShoppingGatewayAPI.Models;
using EShoppingGatewayAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingGatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IRepo<int, Product> _repo;

        public ProductController(IRepo<int,Product> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _repo.GetAll();
            return products.ToList();
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            return await _repo.Add(product);
        }
        [HttpGet]
        [Route("GetProductByID/{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await _repo.Get(id);
        }
    }
}
