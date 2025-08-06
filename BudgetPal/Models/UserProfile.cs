using BudgetPal.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetPal.Models
{
    public class UserProfile
    {
        [Key]
        public required string Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
        private double MainBudget { get; set; }
        private double CurrentSpent  { get; set; }

        // Foreign key
        [Required]
        public required string ApplicationUserId { get; set; }

        // Navigation property
        [ForeignKey("ApplicationUserId")]
        public required ApplicationUser User { get; set; }


        private List<Receipt> Receipts = new List<Receipt> { };
        private List<BudgetCategory> BudgetCategories = new List<BudgetCategory> { };

    }
}
