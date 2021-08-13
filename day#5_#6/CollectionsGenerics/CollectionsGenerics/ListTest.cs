using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class ListTest
    {
        static void Main()
        {
            try
            {
                List<int> list = new List<int>();
                list.Add(9);
                list.Add(9);
                list.Add(9);
                list.Add(9);
                list.Add(9);
                list.Add(9);
                list.Add(9);

                foreach (var num in list)
                    Console.WriteLine(num);

                // collection initializers 
                List<Pen> penList = new List<Pen>()
                {
                    new Pen { Color = "red", Rate = 10 },
                    new Pen { Color = "blue", Rate = 21 },
                    new Pen { Color = "violet", Rate = 11 },
                    new Pen { Color = "orange", Rate = 19 }

                };

                foreach (var pen in penList)
                    Console.WriteLine(pen);

                penList.Sort(); // Sort method should be given something as a value to sort by
                
                foreach (var pen in penList)
                    Console.WriteLine(pen);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
