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
    public class ReportingService
    {
        private readonly SilverScreenContext _context;

        public ReportingService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<decimal> GetDailyRevenueAsync(DateTime date)
        {
            var targetDate = date.Date;
            return await _context.CashRegisters
                .Where(t => DbFunctions.TruncateTime(t.TransactionDate) == targetDate)
                .SumAsync(t => (decimal?)t.Amount) ?? 0;
        }

        public async Task<List<object>> GetMovieStatisticsAsync()
        {
            return await _context.Reservations
                .GroupBy(r => r.Showtime.Movie.Name)
                .Select(g => new
                {
                    MovieName = g.Key,
                    ReservationCount = g.Count(),
                    TotalRevenue = g.Sum(r => (decimal?)r.Showtime.Price) ?? 0
                })
                .ToListAsync<object>();
        }

        public async Task<List<object>> GetOccupancyReportAsync()
        {
            // Simple occupancy based on taken seats vs total seats (assuming one hall for simplicity as per current DB seed)
            var totalSeats = await _context.Seats.CountAsync();
            if (totalSeats == 0) return new List<object>();

            return await _context.Showtimes
                .Select(s => new
                {
                    MovieName = s.Movie.Name,
                    StartTime = s.StartTime,
                    Hall = s.HallName,
                    OccupiedSeats = _context.Reservations.Count(r => r.ShowtimeId == s.Id),
                    TotalSeats = totalSeats,
                    OccupancyRate = (double)_context.Reservations.Count(r => r.ShowtimeId == s.Id) / totalSeats * 100
                })
                .ToListAsync<object>();
        }
    }
}
