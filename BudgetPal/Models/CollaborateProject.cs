namespace BudgetPal.Models
{
    public class CollaborateProject
    {
        private int Id {  get; set; }
        private int OwnerId { get; set; }
        public required string CollaborateProjectName { get; set; }
        private List<int> MemberIds { get; set; } = new List<int>();
        private List<int> IncomingProjectRequestIds { get; set; } = new List<int>(); // id of the projects
        private List<Receipt> Receipts { get; set; } = new List<Receipt>();
        private double ProjectGoal {  get; set; }
        private double CurrentProgressToGoal { get; set; }
    }
    public enum CollaborateProjectStatus { 
        PENDING,
        ACCEPTED,
        REJECTED
    }
}
