using Microsoft.AspNetCore.Identity;

namespace Ocak.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
