using BudgetPal.Models;
using BudgetPal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetPal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileRepository _repository;

        public UserProfilesController(IUserProfileRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfile>> GetProfile(string id) {
            var profile = await _repository.GetProfileAsync(id);
            if (profile == null) {
                return NotFound();
            }
            return Ok(profile);
        }

        [HttpPost]
        public async Task<ActionResult<UserProfile>> SaveProfile(UserProfile profile) {
            var saved = await _repository.SaveProfileAsync(profile);
            return CreatedAtAction(nameof(GetProfile), new { id = saved.Id }, saved);
        }

    }
}
