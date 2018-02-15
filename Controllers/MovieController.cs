
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using af.Models;


namespace af.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            // var movie = new Movie();
            // { movie.Name = "Pronchai!"; }
            // Movie movie = new Movie { Name = "A" };
            ViewData["Top-Title"] = "Movie list";
            ViewData["Sub-Title"] = "movie name";

            var m = new List<Movie>
            {
                new Movie {Name = "Miku",Id=1},
                new Movie {Name="Jaw'A",Id=2}
            };
            return View(m);
            // return Content("A");
        }

        [Route("movie/edit/{year}/{day}")]
        public IActionResult Edit(int year, int day)
        {
            return Content("a" + year + "/" + day);
        }
    }
}