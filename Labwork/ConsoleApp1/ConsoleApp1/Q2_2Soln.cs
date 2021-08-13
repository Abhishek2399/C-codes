using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Q2_2Soln
    {
        static void Main()
        {
            try
            {
                int rows = 3, cols = 4;
                int[,] arr = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"[{i}, {j}] => ");
                        arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong start again ");
                Main();
            }
        }
    }
}
