using EShoppingGatewayAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EShoppingGatewayAPI.Services
{
    public class TokenService : IToken
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration configuration)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }
        public string GenerateToken(UserLoginDTO user)
        {
            var claim = new List<Claim>
           {
               new Claim(JwtRegisteredClaimNames.NameId,user.Username)
           };
            var cred = new SigningCredentials(_key,SecurityAlgorithms.HmacSha512Signature);
            var tokenDecc = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = cred
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDecc);
            return tokenHandler.WriteToken(token);

        }
    }
}
