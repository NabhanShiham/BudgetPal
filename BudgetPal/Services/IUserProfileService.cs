using BudgetPal.Models;

namespace BudgetPal.Services
{
    public interface IUserProfileService
    {
        Task<bool> HasProfileAsync(string userId);
        Task<UserProfile?> GetUserProfileAsync(string userId);
        Task<UserProfile?> SaveUserProfileAsync(UserProfile profile);
    }
}
