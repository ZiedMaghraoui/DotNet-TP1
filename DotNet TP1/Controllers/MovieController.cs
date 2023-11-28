using DotNet_TP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_TP1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };

            List<Movie> movies = new List<Movie>(){
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
            };
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        public IActionResult ByRelease(int year, int month)
        {
            return Content(year+"   "+month);
        }
    }
}
