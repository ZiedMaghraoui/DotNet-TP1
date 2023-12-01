using DotNet_TP1.Models;

namespace DotNet_TP1.Repositories
{
    public class GenreRepository
    {
        private readonly ApplicationdbContext _db;

        public GenreRepository(ApplicationdbContext db)
        {
            _db = db;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _db.genres.ToList();
        }

        public Genre GetGenreById(Guid? id)
        {
            var genre = _db.genres.Find(id);
            return genre;
        }

        public void AddGenre(Genre genre)
        {
            _db.genres.Add(genre);
            _db.SaveChanges();
        }

        public void UpdateGenre(Genre genre)
        {
            _db.genres.Update(genre);
            _db.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            _db.genres.Remove(genre);
            _db.SaveChanges();
        }

    }

}
