using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess
{
    public class DatabaseSeeder
    {
        private readonly SilverScreenContext _context;

        public DatabaseSeeder(SilverScreenContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            SeedUser();
            SeedMovie();
            SeedCustomer();
            SeedSeat();
            SeedShowtime();
            SeedReservation();
        }

        private void SeedUser()
        {
            if (_context.Users.Any()) return;

            var users = new List<User>
            {
                new User { Username = "admin", Password = "123", FullName = "System Admin", Role = "Admin" },
                new User { Username = "cashier1", Password = "123", FullName = "John Doe", Role = "Cashier" }
            };

            _context.Users.AddRange(users);
            _context.SaveChanges();
        }

        private void SeedMovie()
        {
            if (_context.Movies.Any()) return;

            var movies = new List<Movie>
            {
                new Movie { Name = "Inception", Type = "Sci-Fi", Duration = 148, ReleaseTime = new DateTime(2010, 7, 16) },
                new Movie { Name = "The Dark Knight", Type = "Action", Duration = 152, ReleaseTime = new DateTime(2008, 7, 18) },
                new Movie { Name = "Interstellar", Type = "Sci-Fi", Duration = 169, ReleaseTime = new DateTime(2014, 11, 7) },
                new Movie { Name = "Dune", Type = "Sci-Fi", Duration = 155, ReleaseTime = new DateTime(2021, 10, 22) },
                new Movie { Name = "The Matrix", Type = "Sci-Fi", Duration = 136, ReleaseTime = new DateTime(1999, 3, 31) },
                new Movie { Name = "Avatar: The Way of Water", Type = "Adventure", Duration = 192, ReleaseTime = new DateTime(2022, 12, 16) },
                new Movie { Name = "Top Gun: Maverick", Type = "Action", Duration = 130, ReleaseTime = new DateTime(2022, 5, 27) },
                new Movie { Name = "Spider-Man: No Way Home", Type = "Action", Duration = 148, ReleaseTime = new DateTime(2021, 12, 17) }
            };

            _context.Movies.AddRange(movies);
            _context.SaveChanges();
        }

        private void SeedCustomer()
        {
            if (_context.Customers.Any()) return;

            var customers = new List<Customer>
            {
                new Customer { Name = "Kaan", Surname = "Emir", PhoneNumber = "5551234567", Email = "kaan@example.com" },
                new Customer { Name = "Ahsen", Surname = "Demir", PhoneNumber = "5559876543", Email = "ahsen@example.com" }
            };

            _context.Customers.AddRange(customers);
            _context.SaveChanges();
        }

        public void SeedSeat()
        {
            if (_context.Seats.Any()) return;

            for (int i = 1; i <= 50; i++)
            {
                _context.Seats.Add(new Seat
                {
                    HallName = "Hall 1",
                    SequenceNumber = (i - 1) / 10 + 1,
                    SeatNumber = i,
                    Taken = false
                });
            }
            _context.SaveChanges();
        }

        private void SeedShowtime()
        {
            if (_context.Showtimes.Any()) return;

            var movies = _context.Movies.ToList();
            if (!movies.Any()) return;

            var showtimes = new List<Showtime>
            {
                new Showtime { MovieId = movies[0].Id, HallName = "Hall 1", StartTime = DateTime.Now.AddHours(2), Price = 50.00m },
                new Showtime { MovieId = movies[1].Id, HallName = "Hall 1", StartTime = DateTime.Now.AddHours(5), Price = 45.00m }
            };

            _context.Showtimes.AddRange(showtimes);
            _context.SaveChanges();
        }

        private void SeedReservation()
        {
            if (_context.Reservations.Any()) return;

            var showtime = _context.Showtimes.FirstOrDefault();
            var customer = _context.Customers.FirstOrDefault();
            var seat = _context.Seats.FirstOrDefault();

            if (showtime == null || customer == null || seat == null) return;

            var reservation = new Reservation
            {
                ShowtimeId = showtime.Id,
                CustomerId = customer.Id,
                SeatId = seat.Id,
                ReservationTime = DateTime.Now
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }
    }
}
