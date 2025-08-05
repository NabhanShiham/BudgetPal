namespace BudgetPal.Models
{
    public class Receipt
    {
        public required string Id;
        private int uploaderId;
        public required byte[] receiptImage;
        private DateTime uploadTime;
    }
}
