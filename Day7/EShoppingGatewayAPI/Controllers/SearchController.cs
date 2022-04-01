using EShoppingGatewayAPI.Models;
using EShoppingGatewayAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShoppingGatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearch _searchService;

        public SearchController(ISearch search)
        {
            _searchService = search;
        }
        [Route("SearchProductByCategory")]
        [HttpPost]
        public async Task<ActionResult<ProductDetailsDTO>> SearProduct(SearchDTO search)
        {
            var result = await _searchService.GetProductsByCategory(search);
            if(result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
