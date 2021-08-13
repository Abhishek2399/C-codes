using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class MyListTest
    {
        static void Main()
        {
            MyList<int> my = new MyList<int>(5); // creating a mylist for int type
            my.Add(12);
            //my.Add("12"); // as we created template of int we will get error if we try to Add any other type of data 
            my.Add(12);
            my.Add(12);
            my.Add(12);
            my.Add(12);


            for(int i=0; i<my.Count; i++)
            {
                Console.WriteLine(my[i]); // using indexers concept 
            }

            foreach(int num in my)
                Console.WriteLine(num);


        }
    }
}
