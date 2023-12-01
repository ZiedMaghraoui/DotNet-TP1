using DotNet_TP1.Models;
using DotNet_TP1.Services.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_TP1.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            var genres = _genreService.GetAllGenres();
            return View(genres);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre)
        {
            _genreService.AddGenre(genre);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _genreService.GetGenreById(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Genre genre)
        {
            _genreService.UpdateGenre(genre);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Genre genre)
        {
            _genreService.DeleteGenre(genre);
            return RedirectToAction(nameof(Index));
        }
    }
}
