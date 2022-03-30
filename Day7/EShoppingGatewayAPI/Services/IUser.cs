using EShoppingGatewayAPI.Models;

namespace EShoppingGatewayAPI.Services
{
    public interface IUser
    {
        UserLoginDTO Register(UserDTO user);
        UserLoginDTO Login(UserLoginDTO user);
    }
}
