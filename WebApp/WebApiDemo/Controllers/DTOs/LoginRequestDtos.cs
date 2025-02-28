using Microsoft.AspNetCore.Identity.Data;

namespace WebApiDemo.Controllers.DTOs
{
    public class LoginRequestDtos
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
