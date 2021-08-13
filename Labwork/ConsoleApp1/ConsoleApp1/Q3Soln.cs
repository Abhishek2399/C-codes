using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Q3Soln
    {
        static void Main()
        {
            Console.WriteLine("enter a number in between 1-5");
            int userNo = Convert.ToInt32(Console.ReadLine());
            switch (userNo)
            {
                case 1:
                    Console.WriteLine("this is 1");
                    break;
                case 2:
                    Console.WriteLine("this is 2");
                    break;
                case 3:
                    Console.WriteLine("this is 3");
                    break;
                case 4:
                    Console.WriteLine("this is 4");
                    break;
                case 5:
                    Console.WriteLine("this is 5");
                    break;
                default:
                    Console.WriteLine("this is 5");
                    break;
            }
        }
    }
}
