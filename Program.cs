using System;
using System.Reflection;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application! There are 10 movies in this list. Please enter the category you are interested in: animated, drama, horror, or scifi. ");
            var userInput = Console.ReadLine();
        
            var result = new Movie(Title, Category);
            Console.WriteLine($"The movies you selected are ({result.Title}, {result.Category})");
        }
    }
}
