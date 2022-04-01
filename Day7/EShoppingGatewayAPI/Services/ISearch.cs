using EShoppingGatewayAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShoppingGatewayAPI.Services
{
    public interface ISearch
    {
        Task<ICollection<ProductDetailsDTO>> GetProductsByCategory(SearchDTO DTO);
    }
}
