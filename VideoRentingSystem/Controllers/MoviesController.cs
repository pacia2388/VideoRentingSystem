using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private List<Movie> GetMovies()
        {
            return new System.Collections.Generic.List<Movie>()
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }
    }
}