namespace EShoppingGatewayAPI.Models
{
    public class UserLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
