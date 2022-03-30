using EShoppingGatewayAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EShoppingGatewayAPI.Services
{
    public class UserService : IUser
    {
        private readonly ShoppingContext _context;
        private readonly ILogger<UserService> _logger;
        private readonly IToken _tokenService;

        public UserService(ShoppingContext context,ILogger<UserService> logger,IToken tokenService)
        {
            _context = context;
            _logger = logger;
            _tokenService = tokenService;
        }
        public UserLoginDTO Login(UserLoginDTO user)
        {
            var dbUSer = _context.Users.FirstOrDefault(usr => user.Username == user.Username);
            if (dbUSer == null)
                return null;
            HMACSHA512 hmac = new HMACSHA512(dbUSer.PassKey);
            byte[] userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < userPass.Length; i++)
            {
                if (userPass[i] != dbUSer.Password[i])
                    return null;
            }
            user.Role = dbUSer.Role;
            user.Token = _tokenService.GenerateToken(user);
            user.Password = "";
            return user;
        }

        public UserLoginDTO Register(UserDTO user)
        {
            User dbUSer = new User();
            HMACSHA512 hmac = new HMACSHA512();
            dbUSer.FullName = user.FullName;
            dbUSer.Role= user.Role;
            dbUSer.Phone = user.Phone;
            dbUSer.Age = user.Age;
            dbUSer.Username = user.Username;
            dbUSer.PassKey = hmac.Key;
            dbUSer.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            _context.Users.Add(dbUSer);
            try
            {
                _context.SaveChanges();
               UserLoginDTO myUSer =  new UserLoginDTO()
                {
                    Username = user.Username,
                    Role = user.Role
                };
                myUSer.Token = _tokenService.GenerateToken(myUSer);
                return myUSer;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message + " " + DateTime.Now);
            }
            return null;
        }
    }
}
