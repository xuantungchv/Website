using Microsoft.AspNetCore.Identity;

namespace WebApi.Responsitory.Entity
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
