using Microsoft.AspNetCore.Identity;

namespace Ifrastructure.Responsitory.Entity
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
