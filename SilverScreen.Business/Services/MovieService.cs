using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SilverScreen.DataAccess;

namespace SilverScreen.Business.Services
{
    public class MovieService
    {
        private readonly SilverScreenContext _context;

        public MovieService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task AddMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            var existingMovie = await _context.Movies.FindAsync(movie.Id);
            if (existingMovie != null)
            {
                _context.Entry(existingMovie).CurrentValues.SetValues(movie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                // Remove associated showtimes and their reservations first
                var showtimes = _context.Showtimes.Where(s => s.MovieId == id).ToList();
                foreach (var showtime in showtimes)
                {
                    var reservations = _context.Reservations.Where(r => r.ShowtimeId == showtime.Id);
                    _context.Reservations.RemoveRange(reservations);
                }
                _context.Showtimes.RemoveRange(showtimes);

                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
