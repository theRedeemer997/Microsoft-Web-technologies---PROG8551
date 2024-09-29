using Microsoft.AspNetCore.Mvc;
using Movies.Entities;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContext _movieDbContext;
        public MoviesController(MovieDBContext movieDBContext) 
        {
            _movieDbContext = movieDBContext;
        }

        
        public IActionResult List()
        {
            // List of movies -- converting the db set movies to list type
            List<Movie> movies = _movieDbContext.Movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if(ModelState.IsValid) 
            {
                    _movieDbContext.Movies.Add(movie);
                    _movieDbContext.SaveChanges();
                    //Actual Logic
                    return RedirectToAction("List");

            }
            else
            {
                    return View(new Movie());       
            }

        }
    }
}
