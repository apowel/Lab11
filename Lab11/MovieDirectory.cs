using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab11
{
    public class MovieDirectory
    {
        List<Movie> directory = new List<Movie>
            {
                new Movie("The Emoji Movie", "Horror"),
                new Movie("Angry Birds", "Thriller"),
                new Movie("Boss Baby", "Thriller"),
                new Movie("Memento", "Thriller"),
                new Movie("The Conjuring", "Horror"),
                new Movie("Planet Earth", "Documentary"),
                new Movie("Blue Planet", "Documentary"),
                new Movie("The Prestige", "Thriller"),
                new Movie("Meet the Cast of Shrek 2", "Documentary"),
                new Movie("Final Desination 5", "Horror"),
            };
        public List<Movie> GetMovies(string genre)
        {
            List<Movie> selected = directory.FindAll(e => e.Genre == genre)
                .OrderBy(o => o.Title).ToList();
            return selected;
        }
    }
}
