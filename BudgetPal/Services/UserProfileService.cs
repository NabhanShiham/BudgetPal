using BudgetPal.Models;

namespace BudgetPal.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly HttpClient _httpClient;
        public UserProfileService(HttpClient httpClient) { 
            _httpClient = httpClient;
        }
        public async Task<bool> HasProfileAsync(string userId) {
            var profile = await _httpClient.GetFromJsonAsync<UserProfile>($"api/userprofiles/{userId}");
            return profile != null;
        }
        public async Task<UserProfile?> GetUserProfileAsync(string userId) {
            var profile = await _httpClient.GetFromJsonAsync<UserProfile>($"api/userprofiles/{userId}");
            if (profile != null)
            {
                return profile;
            }
            else {
                Console.WriteLine("User Profile Not found :(");
                return null;
            }
            
        }

        public async Task<UserProfile?> SaveUserProfileAsync(UserProfile profile)
        {
            var response = await _httpClient.PostAsJsonAsync("api/userprofiles", profile);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserProfile>();
            }
            else {
                return null;
            }
        }
    }
}
