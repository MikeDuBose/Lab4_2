using System;
using System.Collections.Generic;

namespace Lab4_2
{
    class Program
    {
        static List<Movie> listMov = new List<Movie>();

        static void Main(string[] args)
        {
            //instead of animate, drama, horror, scifi
            //i used christmas, comedy, and horror
            //instantiate list
            //List <Movie> listMov = new List<Movie>();
            //create movie objects
            Movie movie1 = new Movie("Die Hard", "Christmas");
            Movie movie2 = new Movie("Elf", "Christmas");
            Movie movie3 = new Movie("Home Alone", "Christmas");
            Movie movie4 = new Movie("Superbad", "Comedy");
            Movie movie5 = new Movie("Step-Brothers", "Comedy");
            Movie movie6 = new Movie("Hot Fuzz", "Comedy");
            Movie movie7 = new Movie("The Shining", "Horror");
            Movie movie8 = new Movie("Stephen King's 'IT'", "Horror");
            Movie movie9 = new Movie("Silence of the Lambs", "Horror");
            Movie movie0 = new Movie("Saw", "Horror");
            //add movie objects to list
            listMov.Add(movie1);
            listMov.Add(movie2);
            listMov.Add(movie3);
            listMov.Add(movie4);
            listMov.Add(movie5);
            listMov.Add(movie6);
            listMov.Add(movie7);
            listMov.Add(movie8);
            listMov.Add(movie9);
            listMov.Add(movie0);
            //prints out all movie objects in the list
            foreach (Movie m in listMov)
            {
                //ensures all attributes are shown
                Console.WriteLine("Your title is " +m.title + " and your category" +
                    " is " + m.category);
            }

            PromptCategory();

            
        }
        private static void PromptCategory()
        {
            Console.Write("Please input a category [Horror, Christmas, Comedy]: ");
            string input = Console.ReadLine().ToLower();
            foreach (Movie mo in listMov)
            {
                if (mo.category.ToLower().Contains(input))
                {
                    Console.WriteLine("The " + input + " movie, " + mo.title);
                }
                
            }
            Console.Write("Would you like to continue?  Y/N: ");
            input = Console.ReadLine().ToLower();
            if (input != "y")
            {
                return;
            }
            else PromptCategory();
        }
    }

    class Movie
    {
        public string title;
        public string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}
