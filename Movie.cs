using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie
    {
        public static List<Movie> MovieList()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Lorax", "animated"));
            movies.Add(new Movie("Lego Movie", "animated"));
            movies.Add(new Movie("Your Name", "animated"));
            movies.Add(new Movie("Summer Wars", "animated"));
            movies.Add(new Movie("1917", "drama"));
            movies.Add(new Movie("Midway", "drama"));
            movies.Add(new Movie("Alien", "horror"));
            movies.Add(new Movie("Predator", "horror"));
            movies.Add(new Movie("Star Wars", "scifi"));
            movies.Add(new Movie("Godzilla", "scifi"));
            return movies;
        }
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
