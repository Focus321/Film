namespace MyFilm.Context
{
    using MyFilm.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FilmContext : DbContext
    {
        public FilmContext()
            : base("name=FilmContext")
        {
        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}