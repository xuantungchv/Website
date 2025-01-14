using log4net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApi.Responsitory.Entity;
using WebApi.Services.DTOs;
using WebApi.Services.Token;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/Authen")]
    public class AuthenticationController : BaseController
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly ILog _logger = LogManager.GetLogger(typeof(AuthenticationController));
        public AuthenticationController(SignInManager<Users> signInManager, UserManager<Users> userManager, ITokenService tokenService) 
        {
            _signInManager= signInManager;
            _userManager= userManager;
            _tokenService = tokenService;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            try
            {

                if (request.UserName == null || request.Password == null)
                    return ResponseRequest(StatusCodes.Status400BadRequest);
                var user = new Users
                {
                    UserName = request.UserName,
                    Email = "111@gamil.com"
                    
                };
                var response = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, false);
                if (response != null && response.Succeeded)
                    return ResponseRequest(StatusCodes.Status200OK, _tokenService.GenerateToken(user));
                return ResponseRequest(StatusCodes.Status401Unauthorized);
            }
            catch (Exception ex)
            {

                return ResponseRequest(StatusCodes.Status400BadRequest); ;
            }
            
        }


    }
}
