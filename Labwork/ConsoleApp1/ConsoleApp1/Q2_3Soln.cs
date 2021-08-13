using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Q2_3Soln
    {
        static void Main()
        {
            string[] cities = new string[3];
            for(int i=0; i<3; i++)
            {
                cities[i] = Console.ReadLine();
            }

            foreach(var city in cities)
            {
                Console.WriteLine($"City -> {city}");
            }
        }
    }
}
