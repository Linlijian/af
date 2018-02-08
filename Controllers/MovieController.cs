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
        public Movie Random()
        {
            // var movie = new Movie(); {movie.Name = "Pronchai!";}
            Movie movie= new Movie {Name = "A"};
            
            return movie;

        }
    }
}