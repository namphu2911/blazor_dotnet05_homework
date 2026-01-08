namespace web_blazor_server.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdraw
    }

    public class TransactionDto
    {
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}