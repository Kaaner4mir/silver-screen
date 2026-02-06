using SilverScreen.DataAccess;
using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Business.Services
{
    public class PaymentService
    {
        private readonly SilverScreenContext _context;

        public PaymentService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task ProcessPaymentAsync(int reservationId, string description)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Showtime)
                .FirstOrDefaultAsync(r => r.Id == reservationId);

            if (reservation == null)
                throw new Exception("Reservation not found.");

            if (reservation.IsPaid)
                throw new Exception("Reservation is already paid.");

            // Create CashRegister transaction
            var transaction = new CashRegister
            {
                Amount = reservation.Showtime.Price,
                Description = $"Payment for Reservation #{reservation.Id} - {description}",
                TransactionDate = DateTime.Now
            };

            reservation.IsPaid = true;
            _context.CashRegisters.Add(transaction);

            await _context.SaveChangesAsync();
        }

        public async Task<List<CashRegister>> GetTransactionLogsAsync(DateTime? date = null)
        {
            var query = _context.CashRegisters.AsQueryable();
            
            if (date.HasValue)
            {
                var targetDate = date.Value.Date;
                query = query.Where(t => DbFunctions.TruncateTime(t.TransactionDate) == targetDate);
            }

            return await query.OrderByDescending(t => t.TransactionDate).ToListAsync();
        }
    }
}
