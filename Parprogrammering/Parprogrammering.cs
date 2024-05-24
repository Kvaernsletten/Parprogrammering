using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    internal class Parprogrammering
    {

        public string movieTitle = "";
        public string genre = "";
        public string yearOfRelease = "";
        public string shortDescription = "";
        public string producer = "";
        public string readKey = "";

        public List<string> actors = new List<string>();

        public void Run()
        {
            Console.WriteLine("Enter movie title: ");
            movieTitle = Console.ReadLine();
            Console.WriteLine("What is the movie genre?");
            genre = Console.ReadLine();
            Console.WriteLine("What year was the movie released?");
            yearOfRelease = Console.ReadLine();
            Console.WriteLine("Write a short description or movie summary: ");
            shortDescription = Console.ReadLine();
            Console.WriteLine("Enter producer's name: ");
            producer = Console.ReadLine();
            addActor();
        }

        public void addActor()
        {
            Console.WriteLine("Enter actors name: ");
            actors.Add(Console.ReadLine());
            Console.WriteLine("Add another actor? (Y/N)");
            readKey = Console.ReadLine();
       

            if (readKey == "Y" || readKey == "y")
            {
                addNewActor();
            }
            else if (readKey == "N" || readKey == "n")
            {
                printMovie();
            }
            else
            {
                printMovie();
            }
        }

        public void addNewActor()
        {
            addActor();
        }

        public void printMovie()
        {
            Console.Clear();
            Console.WriteLine($"Title: {movieTitle}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Release year: {yearOfRelease}");
            Console.WriteLine($"Summary: {shortDescription}");
            Console.WriteLine($"Produced by: {producer}");

            foreach (var actor in actors)
            {

                Console.WriteLine($"Actor: " + actor);

            }
        }

    }
}
