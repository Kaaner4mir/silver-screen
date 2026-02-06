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
    public class ReservationService
    {
        private readonly SilverScreenContext _context;

        public ReservationService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<Reservation> CreateReservationAsync(int showtimeId, int customerId, int seatId)
        {
            // Check if seat is already taken in this showtime (Actually seat table has 'Taken' property but in a real app it should be per showtime)
            // For now, we use the simple 'Taken' property on Seat entity as implemented in the project
            var seat = await _context.Seats.FindAsync(seatId);
            if (seat == null || seat.Taken)
                throw new Exception("Seat is not available.");

            var reservation = new Reservation
            {
                ShowtimeId = showtimeId,
                CustomerId = customerId,
                SeatId = seatId,
                ReservationTime = DateTime.Now,
                IsPaid = false
            };

            seat.Taken = true; // Mark seat as taken

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return reservation;
        }

        public async Task CancelReservationAsync(int reservationId)
        {
            var reservation = await _context.Reservations.Include(r => r.Seat).FirstOrDefaultAsync(r => r.Id == reservationId);
            if (reservation == null)
                throw new Exception("Reservation not found.");

            if (reservation.IsPaid)
                throw new Exception("Cannot cancel a paid reservation.");

            reservation.Seat.Taken = false; // Release seat
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Reservation>> GetShowtimeReservationsAsync(int showtimeId)
        {
            return await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Seat)
                .Where(r => r.ShowtimeId == showtimeId)
                .ToListAsync();
        }
    }
}
