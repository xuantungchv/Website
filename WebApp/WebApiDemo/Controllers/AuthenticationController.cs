using Application.Authentication.Query;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Controllers.DTOs;

namespace WebApiDemo.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IMediator _mediator;
        public AuthenticationController(IMediator mediator) 
        { 
            _mediator = mediator;
        }
        public IActionResult Login([FromBody] LoginRequestDtos loginRequest)
        {
            try
            {
                var userLogin = new LoginQuery(loginRequest.UserName, loginRequest.Password);
                _mediator.Send(userLogin);
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
    }
}
