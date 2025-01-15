using Microsoft.AspNetCore.Mvc;
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
