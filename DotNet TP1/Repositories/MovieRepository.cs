using DotNet_TP1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_TP1.Repositories
{
    public class MovieRepository
    {
        private readonly ApplicationdbContext _db;
        public MovieRepository(ApplicationdbContext db)
        {
            _db = db;
        }

        public List<IGrouping<Guid, Movie>> GetMoviesByGenre()
        {
            return _db.movies
                .Include(m => m.Genre)
                .GroupBy(m => m.GenreId)
                .ToList();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _db.movies
                .OrderBy(movie => movie.Name)
                .Include(m=> m.Genre)
                .ToList();
        }

        public IEnumerable<Movie> GetMoviesByGenreId(Guid? genreId)
        {
            return _db.movies
                .Where(movie => movie.GenreId == genreId)
                .Include(m => m.Genre)
                .ToList();
        }
    }
}
