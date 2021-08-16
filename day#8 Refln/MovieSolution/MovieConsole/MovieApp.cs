using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntityLayer;
using MovieBussinessLayer;

namespace MovieConsole
{
    class MovieApp
    {
        public static void GetAllMovies()
        {
            MovieBL movieBL = new MovieBL();
            List<Movie> movies = movieBL.GetMoviesBL();
            if(movies != null)
            {
                Console.WriteLine("\n############################################");
                Console.WriteLine("--------------------------");
                foreach(var movie in movies)
                {
                    Console.WriteLine(movie);
                    Console.WriteLine("--------------------------");
                }
                Console.WriteLine("############################################\n");
            }
            else
            {
                Console.WriteLine("No movies Present ");
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("*********<Movie Menu>**************");
            Console.WriteLine("1. Get all the movies");
            Console.WriteLine("2. Find Movie");
            Console.WriteLine("3. Add Movie");
            Console.WriteLine("4. Delete Movie");
            Console.WriteLine("5. Edit Movie");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter the choice ");
        }

        public static void FindMovie()
        {
            try
            {
                Console.WriteLine("Enter the movie id:");
                int id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                // Console.WriteLine(movieBL.FindMovieBL(id));// self written
                Console.WriteLine(movieBL.FindMovieBL2(id));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddMovie()
        {
            Movie newMovie = new Movie();
            
            Console.WriteLine("Enter the ID");
            newMovie.ID = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Name");
            newMovie.Name = Console.ReadLine();
            
            Console.WriteLine("Enter the Rating");
            newMovie.Rating = Convert.ToInt32(Console.ReadLine());


        }


        static void Main(string[] args)
        {
            int choice=0;
            DisplayMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch(choice)
                {
                    case 1: GetAllMovies();  break;
                    case 2: FindMovie();  break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                }
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice != 0);
            Console.WriteLine("Bye !!!!");
        }
    }
}
