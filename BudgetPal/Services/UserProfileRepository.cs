using BudgetPal.Data;
using BudgetPal.Models;

namespace BudgetPal.Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;
        public UserProfileRepository(ApplicationDbContext context) { 
           _context = context; 
        }
        public async Task<UserProfile?> GetProfileAsync(string id) {
            return await _context.UserProfiles.FindAsync(id);
        }
        public async Task<UserProfile> SaveProfileAsync(UserProfile profile) {
            _context.UserProfiles.Add(profile);
            await _context.SaveChangesAsync();
            return profile;
        }

    }
}
