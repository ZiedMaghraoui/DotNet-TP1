using DotNet_TP1.Models;
using DotNet_TP1.Repositories;
using DotNet_TP1.Services.ServiceContracts;

namespace DotNet_TP1.Services.Services
{
    public class GenreService : IGenreService
    {
        private readonly GenreRepository _genreRepository;

        public GenreService(GenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _genreRepository.GetAllGenres();
        }

        public void AddGenre(Genre genre)
        {
            _genreRepository.AddGenre(genre);
        }

        public void UpdateGenre(Genre genre)
        {
            _genreRepository.UpdateGenre(genre);
        }

        public void DeleteGenre(Genre genre)
        {
            _genreRepository.DeleteGenre(genre);
        }

        public Genre GetGenreById(Guid? id)
        {
            return _genreRepository.GetGenreById(id);
        }
    }

}
