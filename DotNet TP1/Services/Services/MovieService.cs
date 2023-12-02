using DotNet_TP1.Models;
using DotNet_TP1.Repositories;
using DotNet_TP1.Services.ServiceContracts;

namespace DotNet_TP1.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieRepository _movieRepository;
        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public List<IGrouping<Guid, Movie>> GetMoviesByGenre()
        {
            return _movieRepository.GetMoviesByGenre();
        }

        public IEnumerable<Movie> GetMoviesByGenreId(Guid? genreId)
        {
            return _movieRepository.GetMoviesByGenreId(genreId);
        }
    }
}
