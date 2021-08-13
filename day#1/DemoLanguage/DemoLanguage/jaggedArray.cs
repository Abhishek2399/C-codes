using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class jaggedArray
    {
        public static void Main(String[] args)
        {
            string[][] stud = new string[3][];
            stud[0] = new string[] { "cet", "ssc"};
            stud[1] = new string[] { "cet", "ssc", "hsc"};
            stud[2] = new string[] { "mhcit"};

            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"Student {i+1}");
                for(int j=0; j<stud[i].Length; j++)
                {
                    Console.Write($"{stud[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
