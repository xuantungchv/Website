using IdentityServer.DTOs;
using Infrastructure.Services.Token;
using Infrastructure.Services.User;
using Microsoft.AspNetCore.Mvc;
namespace IdentityServer.Controllers
{
    [ApiController]
    [Route("/Authen")]
    public class AuthenticationController : BaseController
    {
        private readonly ITokenService _tokenService;
        private readonly IUserServices _userServices;

        public AuthenticationController(ITokenService tokenService, IUserServices userServices)
        {
            _tokenService = tokenService;
            _userServices = userServices;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            try
            {
                var res = _userServices.AuthenUser(request.UserName, request.Password).Result;
                if (!res)
                    return ResponseRequest(StatusCodes.Status401Unauthorized);
                return ResponseRequest(StatusCodes.Status200OK, _tokenService.GenerateToken(request.UserName,request.Password), "");
            }
            catch (Exception ex)
            {
                return ResponseRequest(StatusCodes.Status400BadRequest); ;
            }

        }
    }
}
