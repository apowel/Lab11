using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to the movie list application.\n");
            bool again = true;
            while (again)
            {

                MovieDirectory thisDirectory = new MovieDirectory();
                string[] genreSelection = new string[] { "Horror", "Documentary", "Thriller" };
                int i = 1;
                Console.WriteLine("Enter the number corresponding with the genre you're interested in.");
                foreach (string genre in genreSelection)
                {
                    Console.WriteLine($"{i}: {genre}");
                    i++;
                }
                int n;
                while ((!int.TryParse(Console.ReadLine(), out n)) || n < 1 || n > genreSelection.Length)
                { 
                    Console.WriteLine("That was not a valid input.\nEnter a number 1-"
                        + genreSelection.Length +" :");
                }
                var result = thisDirectory.GetMovies(genreSelection[n - 1]);
                Console.WriteLine($"The {genreSelection[n - 1].ToLower()} " +
                    $"movies in our listings include alphabetically: \n");
                foreach (var movie in result)
                {
                    Console.WriteLine(movie.Title);
                }
                again = Again();
            }
        }
        public static bool Again()
        {
            Console.WriteLine("Would you like to see the listings for another Genre? " +
                @"(enter ""yes"" or ""no"")");
            string againInput = "";
            againInput = Console.ReadLine().ToLower().Trim();
            
            if (againInput == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (againInput == "no")
            {
                return false;
            }
            else
            {
                return Again();
            }
        }
    }
}
