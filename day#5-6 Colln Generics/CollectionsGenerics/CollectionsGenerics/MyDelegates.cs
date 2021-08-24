using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class MyDelegates
    {
        // declaring a delegate 
        // Syntax => <accessor type> delegate <return type> <delegate name{self defined}>(Params)
        // eg :-
        public delegate void calDelegate(int x, int y); // Declaring delegate

        public delegate void ToppingDelegate(string name);

        public delegate void OnlyString(string someString);

        public delegate bool SortDelegate<T>(T x, T y); // As this delegate has to sort any type, we have to use generic type parameters 
        // as this will compare and will be used in a if statement, this will return True or False i.e. Bool
        
        public void MySort<T>(List<T> data, SortDelegate<T> sd) // as the list can be of any specific type we have to make it generic and the delegate we are using is already generic 
        {
            for(int i=0; i<data.Count; i++)
            {
                for(int j=i+1; j<data.Count; j++)
                {
                    if(sd(data[i], data[j]))
                    {
                        T temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }



        // Using Delegates in Function Calling 
        public void MakePizza(ToppingDelegate td, string name) // td repersents a function which func will run will be decided at the run time 
        {
            Console.WriteLine("Make Pizza Sauce");
            Console.WriteLine("Make Pizza Dough");
            Console.WriteLine("Spread Pizza Dough");
            Console.WriteLine("Spread Pizza Sauce");
            Console.WriteLine("#####################################");
            td(name); // calling the topping method which topping will be decided in the runtime 
            Console.WriteLine("#####################################");
            Console.WriteLine("Bake it");
            Console.WriteLine("Serve it");

        }

    }
}
