using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFilm.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public string FilmYear { get; set; }
        public string FilmCountry { get; set; }
        public string FilmGenre { get; set; }
        public string FilmDirector { get; set; }
        public string FilmActor { get; set; }
        public string FilmTime { get; set; }
        public string FilmAbout { get; set; }
        public string FilmImage { get; set; }
        public string FilmPath { get; set; }
    }
}
