using EShoppingGatewayAPI.Models;

namespace EShoppingGatewayAPI.Services
{
    public interface IToken
    {
        string GenerateToken(UserLoginDTO user);
    }
}
