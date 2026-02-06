using SilverScreen.DataAccess;
using SilverScreen.Entities.Models;
using SilverScreen.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Business.Services
{
    public class FinancialService
    {
        private readonly SilverScreenContext _context;

        public FinancialService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<FinancialSummary> GetDailySummaryAsync(DateTime date)
        {
            var targetDate = date.Date;
            var transactions = await _context.CashRegisters
                .Where(t => DbFunctions.TruncateTime(t.TransactionDate) == targetDate)
                .ToListAsync();

            return new FinancialSummary
            {
                Date = targetDate,
                TransactionCount = transactions.Count,
                TotalRevenue = transactions.Sum(t => t.Amount),
                AvgTransactionValue = transactions.Any() ? transactions.Average(t => t.Amount) : 0
            };
        }

        public async Task CloseDayAsync(DateTime date)
        {
            // In a real app, this might archive transactions or lock the day.
            // For now, we just create a log entry in CashRegister.
            var summary = await GetDailySummaryAsync(date);

            var closeEntry = new CashRegister
            {
                Amount = 0, // Closing entry doesn't add money, it summarizes
                Description = $"DAY CLOSED: Date: {date:yyyy-MM-dd}, Total Revenue: {summary.TotalRevenue:C2}, Count: {summary.TransactionCount}",
                TransactionDate = DateTime.Now
            };

            _context.CashRegisters.Add(closeEntry);
            await _context.SaveChangesAsync();
        }
    }
}
