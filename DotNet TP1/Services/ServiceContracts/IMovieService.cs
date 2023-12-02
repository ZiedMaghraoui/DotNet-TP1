using DotNet_TP1.Models;

namespace DotNet_TP1.Services.ServiceContracts
{
    public interface IMovieService
    {
        List<IGrouping<Guid, Movie>> GetMoviesByGenre();
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetMoviesByGenreId(Guid? genreId);
    }
}
