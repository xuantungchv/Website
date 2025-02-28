using Microsoft.AspNetCore.Identity;

namespace Domain.Responsitory.Entity
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
