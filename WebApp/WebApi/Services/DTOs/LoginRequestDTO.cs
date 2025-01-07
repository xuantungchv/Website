using Microsoft.AspNetCore.Identity.Data;

namespace WebApi.Services.DTOs
{
    public class LoginRequestDTO
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }

    }
}
