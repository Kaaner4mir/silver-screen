using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Services
{
    public class MovieService
    {
        private readonly SilverScreenContext _context;

        public MovieService(SilverScreenContext context)
        {
            _context = context;
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateMovie(Movie movie)
        {
            var existingMovie = _context.Movies.FirstOrDefault(e => e.Id == movie.Id);
            if (existingMovie != null)
            {
                existingMovie.Name = movie.Name;
                existingMovie.Type = movie.Type;
                existingMovie.Duration = movie.Duration;
                existingMovie.ReleaseTime = movie.ReleaseTime;
                _context.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}
