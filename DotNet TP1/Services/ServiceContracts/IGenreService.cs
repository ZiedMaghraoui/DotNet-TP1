using DotNet_TP1.Models;

namespace DotNet_TP1.Services.ServiceContracts
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenres();
        Genre GetGenreById(Guid? id);
        void AddGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
    }

}
