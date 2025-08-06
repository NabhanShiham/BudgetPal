using BudgetPal.Data;

namespace BudgetPal.Models
{
    public class BudgetCategory
    {
        private int Id { get; set; }
        private int CategoryOwnerId { get; set; }
        public required string BudgetName { get; set; }
        private double Allowance { get; set; }
        private double CurrentSpent { get; set; }

        // foreign key
        public int UserId { get; set; }

        // nav property
        public required ApplicationUser User { get; set; }

        public List<Receipt> Receipts { get; set; } = new List<Receipt>();

    }
}
