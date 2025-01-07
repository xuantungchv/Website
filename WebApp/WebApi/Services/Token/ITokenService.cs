using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Responsitory.Entity;

namespace WebApi.Services.Token
{
    public interface ITokenService
    {
        public string GenerateToken(Users user);
         
    }
}
