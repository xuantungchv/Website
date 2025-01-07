using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApi.Responsitory.Entity;
using WebApi.Services.DTOs;
using WebApi.Services.Token;

namespace WebApi.Controllers
{
    [Route("/Authen")]
    public class AuthenticationController : BaseController
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<Users> userManager;
        private readonly SignInManager<Users> signInManager;
        public AuthenticationController() { }
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            var user = new Users
            {
                UserName = request.UserName
            };
            var response = await signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (response != null && response.Succeeded)
                return ResponseRequest(StatusCodes.Status200OK, _tokenService.GenerateToken(user));
            return ResponseRequest(StatusCodes.Status401Unauthorized);
        }


    }
}
