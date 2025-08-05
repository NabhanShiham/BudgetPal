namespace BudgetPal.Models
{
    public class User
    {
        private int Id { get; set; }
        private String Username { get; set; }
        private String Email { get; set; }
        private String Password { get; set; }

        public ICollection<User> Friends { get; set; } = new List<User>();

        // nav property 1t1
        public UserProfile UserProfile { get; set; }
    }
}
