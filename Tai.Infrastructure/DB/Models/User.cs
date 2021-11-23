using Microsoft.AspNetCore.Identity;

namespace Tai.Infrastructure.DB.Models
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
