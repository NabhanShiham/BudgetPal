using BudgetPal.Data;

namespace BudgetPal.Models
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public required string FromUserId { get; set; }
        public required ApplicationUser FromUser { get; set; }

        public required string ToUserId { get; set; }
        public required ApplicationUser ToUser { get; set; }
        public FriendRequestStatus Status { get; set; }

        public DateTime RequestedAt { get; set; }
        public DateTime? RespondedAt { get; set; }
    }
    public enum FriendRequestStatus {
        PENDING,
        ACCEPTED,
        REJECTED
    }
}
