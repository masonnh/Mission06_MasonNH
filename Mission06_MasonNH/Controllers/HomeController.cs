using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_MasonNH.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_MasonNH.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext { get; set; }

        public HomeController(MovieContext x)
        {
            _movieContext = x;
        }

        public IActionResult Index()
        {
            var movies = _movieContext.Responses.Include(x => x.category).ToList();
            return View(movies);
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movie()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Movie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(newMovie);
                _movieContext.SaveChanges();
                return View("Confirmation", newMovie);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            var movie = _movieContext.Responses.Single(x => x.MovieId == id);

            return View("Movie", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Responses.Update(movie);
                _movieContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieContext.Responses.Single(x => x.MovieId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieContext.Responses.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
