using Microsoft.AspNetCore.Identity;

namespace Infratructure.Responsitory.Entity
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
