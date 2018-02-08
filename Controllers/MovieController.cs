using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using af.Models;

namespace af.Controllers
{
    public class MovieController
    {
        public string Random()
        {
            var movie = new Movie(); {movie.Name = "Pronchai!";}
            return movie.Name;

        }
    }
}