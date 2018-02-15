using System;
using System.Collections.Generic;

namespace af.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }

    }
}