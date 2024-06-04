using Microsoft.AspNetCore.Identity;

namespace Dolphin.Core.Entities
{
    public class User: IdentityUser
    {
        public double Budget { get; set; }
        public string Fullname { get; set; }
    }
}
