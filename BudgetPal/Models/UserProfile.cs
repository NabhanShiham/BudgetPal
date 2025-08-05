namespace BudgetPal.Models
{
    public class UserProfile
    {
        private int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
        private double MainBudget { get; set; }
        private double CurrentSpent  { get; set; }

        // nav property
        public required User User { get; set; }

        // foreign key
        public int UserId { get; set; }

        private List<Receipt> Receipts = new List<Receipt> { };
        private List<BudgetCategory> BudgetCategories = new List<BudgetCategory> { };

    }
}
