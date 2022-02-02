using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext context)
        {
            _logger = logger;
            movieContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Movies(MovieResponse response)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(response);
                movieContext.SaveChanges();
                return View("confirmation");
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();

                return View(response);
            }
        }

        public IActionResult Collection()
        {
            var context = movieContext.responses
                .Include(x => x.Category)
                .ToList();

            return View(context);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            var movie = movieContext.responses.Single(x => x.MovieId == movieid);

            return View("Movies", movie);
        }
        [HttpPost]
        public IActionResult Edit(MovieResponse movie)
        {
            movieContext.Update(movie);
            movieContext.SaveChanges();

            return RedirectToAction("Collection");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponse movie)
        {
            movieContext.responses.Remove(movie);
            movieContext.SaveChanges();

            return RedirectToAction("Collection");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
