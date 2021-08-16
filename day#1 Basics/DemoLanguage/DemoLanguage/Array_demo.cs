using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class Array_demo
    {
        public static void Main()// if main not written properly won't be showed in startup
        {
            /*
            // uncomment to run 
            //<single dim. arr>
            int[] arr = { 1, 2, 3, 4, 5 }; //  single dimension array 
            string[] names = new string[5]; // employee
            int[] salary = new int[5]; // salary 
            int salary_sum = 0;
            Console.WriteLine();
            for(int i=0; i<names.Length; i++)
            {             
                Console.WriteLine($"Enter the name ");
                names[i] = Console.ReadLine();

                Console.WriteLine($"Enter the salary");
                salary[i] = Convert.ToInt32(Console.ReadLine());

                salary_sum += salary[i];
            }

            for(int i=0; i<names.Length; i++)
            {
                Console.Write($"{names[i]} : {salary[i]}\n");
            }
            Console.WriteLine($"Sum of Salary {salary_sum}");
            
            */
            /* <multi dim arr>*/


           
            string[,] names = { { "p", "q", "r", "s" }, { "x", "y", "z", "e" }, { "a", "b", "c", "d" } };
            int[,] members = { { 2, 3, 5, 4 }, { 4, 6, 8, 9 }, { 7, 9, 2, 3 }, { 5, 7, 11, 9 } };
            int level = 3, total_members = 0 ;
            int rooms_per_level = 4;
            Console.WriteLine("-------------------------------");
            for (int floor=0; floor<level; floor++)
            {
                int mem_per_floor=0;
                Console.WriteLine($"Floor : {floor+1}");
                for(int room=0; room<rooms_per_level; room++)
                {
                    Console.Write($"{floor+1}.{room+1}) {names[floor, room]} lives with {members[floor, room]}\n");
                    mem_per_floor += members[floor, room];
                }
                total_members += mem_per_floor;
                Console.WriteLine("*******************************");
                Console.WriteLine($"Members on Floor{floor+1} : {mem_per_floor}");
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine($"Members in Building : {total_members}");
            
        }
    }
}
