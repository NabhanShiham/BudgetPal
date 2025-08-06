using BudgetPal.Models;
using Microsoft.AspNetCore.Identity;

namespace BudgetPal.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUser> Friends { get; set; } = new List<ApplicationUser>();

        // nav property 1t1
        public required UserProfile UserProfile { get; set; }
    }

}
