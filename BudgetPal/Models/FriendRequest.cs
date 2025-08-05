namespace BudgetPal.Models
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public required User FromUser { get; set; }

        public int ToUserId { get; set; }
        public required User ToUser { get; set; }
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
