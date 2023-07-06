using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PersonalWork.Application.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PersonalWork.Application.Utils
{
    public class TokenService
    {
        private readonly IConfiguration _config;
        private readonly IUnitOfWork _uow;
        
        public TokenService(IConfiguration config, IUnitOfWork uow)
        {
            _config = config;
            _uow = uow;
   
        }
        public Token CreateToken(int userId, string[] role, int expireInMin = 0)
        {
            var keyBytes = Encoding.ASCII.GetBytes(_config.GetSection("Jwt:Key").Value);
            var tokenHandler = new JwtSecurityTokenHandler();
            var descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString()),
                    new Claim(ClaimTypes.Role, role[0].Trim()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),

                Expires = DateTime.UtcNow.AddMinutes(expireInMin < 1 ? _config.GetSection("Jwt:ExpireMinutes").Get<int>() : expireInMin),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(descriptor);
            return new Token { AccessToken = tokenHandler.WriteToken(token) };
        }

    }
}
