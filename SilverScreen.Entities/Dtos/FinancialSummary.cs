namespace SilverScreen.Entities.Dtos
{
    public class FinancialSummary
    {
        public System.DateTime Date { get; set; }
        public int TransactionCount { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal AvgTransactionValue { get; set; }
    }
}
