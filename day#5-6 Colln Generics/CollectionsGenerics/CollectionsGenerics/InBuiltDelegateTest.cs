using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class InBuiltDelegateTest
    {
        static void Main()
        {

            // Func<type1, type2, type3, .... , lastType is REturn>
            //Func<string> show = Display; // here last is return 

            Func<int, int, int> add = delegate (int x, int y) { return x + y; }; // <int, int, int> first 2 ints are for the parameter and last one is return type

            Console.WriteLine($"Add { add(2,4)}");

            // Action takes more than one param but returns nothing 
            // Action delegate is a generic delegate present in the system namespace
            
        }
    }
}
