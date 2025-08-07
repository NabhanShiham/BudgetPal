using BudgetPal.Models;

namespace BudgetPal.Services
{
    public interface IUserProfileRepository
    {
        Task<UserProfile?> GetProfileAsync(string id);
        Task<UserProfile> SaveProfileAsync(UserProfile profile);
    }
}
