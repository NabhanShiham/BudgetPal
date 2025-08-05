namespace BudgetPal.Models
{
    public class User
    {
        private int Id { get; set; }
        public required String Username { get; set; }
        public required String Email { get; set; }
        public required String Password { get; set; }

        public ICollection<User> Friends { get; set; } = new List<User>();

        // nav property 1t1
        public required UserProfile UserProfile { get; set; }
    }
}
