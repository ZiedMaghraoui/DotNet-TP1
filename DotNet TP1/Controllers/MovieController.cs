using DotNet_TP1.Models;
using DotNet_TP1.Services.ServiceContracts;
using DotNet_TP1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_TP1.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();
            return View(movies);
        }

        public IActionResult List()
        {
            var movies = _movieService.GetAllMovies();
            return View(movies);
        }

        public IActionResult InputGenreId()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessGenreId(GenreIdVM vm)
        {
            if (string.IsNullOrWhiteSpace(vm.genreId))
            {
                ModelState.AddModelError("GroupId", "Please enter a valid group ID");
                return View("InputGenreId");
            }

            // Redirect to the ByGroupId action with the entered group ID
            Guid genreId = new Guid(vm.genreId);
            return RedirectToAction("ByGenreId", new { genreId });

        }

        public IActionResult ByGenreId(Guid genreId)
        {
            var movies = _movieService.GetMoviesByGenreId(genreId);
            return View(movies);
        }

        public IActionResult ByGenre()
        {
            var movies = _movieService.GetMoviesByGenre();
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        public IActionResult ByRelease(int year, int month)
        {
            return Content(year + "   " + month);
        }

        public IActionResult Viewers()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };

            List<Customer> customers = new List<Customer>(){
                new Customer{Name="John"},
                new Customer{Name="Alex"},
            };

            MovieCustomerViewData vm = new MovieCustomerViewData()
            {
                movie = movie,
                customers = customers
            };
            return View(vm);
        }
    }
}
