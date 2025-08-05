namespace BudgetPal.Models
{
    public class UserProfile
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string PhoneNumber { get; set; }
        private double MainBudget { get; set; }
        private double CurrentSpent  { get; set; }

        // nav property
        public User User { get; set; }

        // foreign key
        public int UserId { get; set; }

        private List<Receipt> Receipts = new List<Receipt> { };
        private List<BudgetCategory> BudgetCategories = new List<BudgetCategory> { };

    }
}
