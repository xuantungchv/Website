using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ifrastructure.Responsitory.Entity;

namespace Ifrastructure.Services.Token
{
    public interface ITokenService
    {
        public string GenerateToken(Users user);
         
    }
}
