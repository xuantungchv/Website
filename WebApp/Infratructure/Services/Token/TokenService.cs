using Application.Services.Token;
using Infratructure.Responsitory.Entity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infratructure.Services.Token
{
    public class TokenService : ITokenService
    {
        //private readonly IConfiguration _configuration;
        //public TokenService(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        public string GenerateToken(string userName, string passWord)
        {


            var user = new Users
            {
                UserName = userName,
                Email = "111@gamil.com"

            };

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationHelper.GetByKey("Jwt:Key")));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: ConfigurationHelper.GetByKey("Jwt:Issuer"),
                audience: ConfigurationHelper.GetByKey("Jwt:YourAudience"),
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
