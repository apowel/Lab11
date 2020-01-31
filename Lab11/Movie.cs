using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
        private string title;
        private string genre;

        public string Title { get => title; }
        public string Genre { get => genre; }
        public Movie(string setTitle, string setGenre)
        {
            title = setTitle;
            genre = setGenre;
        }
    }
}
