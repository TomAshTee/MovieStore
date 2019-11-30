using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;
using MovieStore.ViewModels;

namespace MovieStore.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> moviesList = new List<Movie>
        {
            new Movie{Title = "Star Wars", Id = "1"},
            new Movie{Title = "Ex Machina", Id = "2"},
            new Movie{Title = "Hobbit", Id = "3"}
        };

        // GET: Movies
        public ActionResult Index()
        {
            var moviesViewModel = new MovieViewModel();
            moviesViewModel.Movies = moviesList;

            return View(moviesViewModel);
        }
    }
}