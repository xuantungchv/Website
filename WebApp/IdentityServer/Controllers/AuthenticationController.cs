using Application.Services.Token;
using Application.Services.User;
using IdentityServer.DTOs;
using IdentityServer.Fillter;
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
                throw new Exception("co ngom khong");
                var res = _userServices.AuthenUser(request.UserName, request.Password).Result;
                if (!res)
                    return ResponseRequest(StatusCodes.Status401Unauthorized);
                return ResponseRequest(StatusCodes.Status200OK, _tokenService.GenerateToken(request.UserName, request.Password), "");
                //return ResponseRequest(StatusCodes.Status200OK, "");
            }
            catch (Exception ex)
            {
                throw ex;
                //return ResponseRequest(StatusCodes.Status400BadRequest); ;
            }

        }
    }
}
