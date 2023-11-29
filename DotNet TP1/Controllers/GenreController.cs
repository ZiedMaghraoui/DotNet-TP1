using DotNet_TP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet_TP1.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationdbContext _db;
        public GenreController(ApplicationdbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var genres = _db.genres.ToList();
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
            _db.genres.Add(genre);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _db.genres.Find(id);

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
            _db.genres.Update(genre);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Genre genre)
        {
            _db.genres.Remove(genre);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
