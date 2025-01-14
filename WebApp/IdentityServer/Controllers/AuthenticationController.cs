using Microsoft.AspNetCore.Mvc;
using IdentityServer4.
namespace IdentityServer.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
