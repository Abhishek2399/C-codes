using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entertainment;
namespace OOPSDemo
{
    class MovieTest
    {
        static void Main()
        {
            int totalMovies = 3;
            Movie[] myFav = new Movie[totalMovies];

            try
            {
                for (int i = 0; i < totalMovies; i++)
                {
                    myFav[i] = new Movie();
                    Console.WriteLine($"Enter the name of the Movie{i + 1} : ");
                    myFav[i].Name = Console.ReadLine();
                    Console.WriteLine("Give some description about the Movie : ");
                    myFav[i].Description = Console.ReadLine();
                    Console.WriteLine("Enter Movie ID : ");
                    myFav[i].Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Give Rating : ");
                    myFav[i].Rating = Convert.ToInt32(Console.ReadLine());
                    if(myFav[i].Rating < 0 || myFav[i].Rating > 5) { throw new Exception("Year less than 2021"); }
                    Console.WriteLine("Year Movie of Release : ");
                    myFav[i].Year = Convert.ToInt32(Console.ReadLine());
                    if(myFav[i].Year > 2021) { throw new Exception("Year less than 2021"); }
                    Console.WriteLine("------------------------");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("------------------------");

            for (int i = 0; i < totalMovies; i++)
            {
                Console.WriteLine(myFav[i].MovieInfo());
                Console.WriteLine("------------------------");
            }
           
        }

    }
}


