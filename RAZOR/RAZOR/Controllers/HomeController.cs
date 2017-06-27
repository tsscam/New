using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RAZOR.Models;
namespace RAZOR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public Hashtable GetListOfMovies()
        {
            Hashtable MovieList = new Hashtable();

            MovieList.Add("STAR WARS", new Movie("Star Wars", "Sci Fi", "George Lucas"));
            MovieList.Add("LION KING", new Movie("Lion King", "Family", "Roger Allers"));
            MovieList.Add("FINDING NEMO", new Movie("Finding Nemo", "Family", "Andrew Stanton"));
            MovieList.Add("CHRISTMAS PARTY", new Movie("Christmas Party", "Commedy","Josh Gordon"));
            MovieList.Add("SAW", new Movie("Saw", "Horror", "James Wan"));
            MovieList.Add("LOVE AND BASKETBALL", new Movie("Love Story", "Drama", "Gina Prince-Bythewood"));

            return MovieList;

        }

        public ActionResult SearchByTitle(string Title)
        {
            Hashtable MovieList = GetListOfMovies();

            //if (MovieList[Title.ToUpper()] != null)
            //{
            //    ViewBag.Message = "Search Results: ";
            //    ViewBag.MovieResult = (Movie)MovieList[Title.ToUpper()];
            //}
            //else
            //    ViewBag.Message = "Movie not Found :( ";

            List<Movie> Lst = MovieList.Values.Cast<Movie>().ToList();

            List<Movie> SearchResult = Lst.Where(x => x.Title.ToUpper().Contains(Title.ToUpper()) || x.Director.ToUpper().Contains(Title.ToUpper())).ToList();

            //foreach (Movie element in Lst)
            //{
            //    if (element.Title.ToUpper().Contains(Title.ToUpper()))
            //        SearchResult.Add(element);
            //}

            ViewBag.SearchResults = SearchResult;

            return View("Index");


        }
        public ActionResult SearchByCategory(string Category)
        {
            Hashtable MovieList = GetListOfMovies();

            List<Movie> SearchResult = new List<Movie>();

            foreach(Movie element in MovieList.Values)
            {
                if (element.Category.ToUpper() == Category.ToUpper())
                {
                    SearchResult.Add(element);
                }

            }
            if (SearchResult.Count != 0)
                ViewBag.Message = "Search Results are: ";
            else
                ViewBag.Message = "No Movies in this Category!";
            ViewBag.SearchResults = SearchResult;
                return View("Index");
        }
        //public ActionResult SearchByDirector(string Director)
        //{
        //    Hashtable MovieList = GetListOfMovies();

        //    List<Movie> Lst = MovieList.Values.Cast<Movie>().ToList();

        //    List<Movie> SearchResult = Lst.Where(x => x.Director.ToUpper().Contains(Director.ToUpper())).ToList();

        //    ViewBag.SearchResultes = SearchResult;

        //    return View("Index");

        }
    }
