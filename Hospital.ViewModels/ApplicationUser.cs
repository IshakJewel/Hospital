using Microsoft.AspNet.Identity.EntityFramework;

namespace Hospital.ViewModels
{
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}