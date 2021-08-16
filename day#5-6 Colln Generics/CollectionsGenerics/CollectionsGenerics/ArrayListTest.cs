using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // to get access to the array list 

namespace CollectionsGenerics
{
    class ArrayListTest
    {
        static void Main()
        {
            ArrayList arrList = new ArrayList(); //  creating an object of the Array List 
            
            // creating various objects to add in the ArrayList
            int num = 21;
            char alpha = 'a';
            string name = "Abhishek";
            Pen fineline = new Pen { Color = "Black", Rate = 12 };

            // adding following objects in the ArrayList 
            arrList.Add(num);
            arrList.Add(alpha);
            arrList.Add(name);
            arrList.Add(fineline);
            // 
            Console.WriteLine($"Total Elements -> {arrList.Count}");// Count -> total elements in the List 

            foreach(var objElement in arrList)
            {
                Console.WriteLine(objElement);
            }
            // Processing info as per the data/obj type 
            // if int multiply by 10 
            // if string conct with "Hello"
            // . . .. . 
            // in such cases we would be needing to check the data type first before starting the processing of those elements 
            // checking of objs is done with "is" keyword <Syntax> obj is Type -> will give true/false
            for(int i=0; i<arrList.Count; i++)
            {
                if (arrList[i] is string) Console.WriteLine($"Hello {arrList[i]}");
                else if (arrList[i] is int) Console.WriteLine($"{Convert.ToInt32(arrList[i]) * 10}");
                else if (arrList[i] is Pen)
                {
                    // unbox arrList to Pen type using "as"
                    Pen pen = arrList[i] as Pen;
                    if(pen.Rate > 500)
                    {
                        Console.WriteLine("Pen Too Expensive");
                    }
                    else Console.WriteLine("Pen is OK");
                    
                }

            }

        }
    }
}
