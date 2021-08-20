
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class AnonymousMethodsTest
    {
        // type of anonymous methods we have to use 
        // we have to declare the signature 
        delegate void ShowName(string name);
        delegate int ShowArth(int x, int y);
        static void Main()
        {
            string myName = "Abhishek";
            ShowName show = delegate(string name)
            {
                Console.WriteLine($"Hello, this is {name}");
                Console.WriteLine("Today is Satrday");
                Console.WriteLine("-------------------");
            };

            show(myName);
            show("abhi");

            ShowArth sum = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine($"Sum -> {sum(7,5)}");

            ShowArth mul = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine($"Mul -> {mul(7, 5)}");


            //  short hand way for writing the delegate using lanbda expression "=>"
            // Syntax variable list => expression{what to do with those vars}
            ShowArth add = (int a, int b) => a + b;
            Console.WriteLine("Add -> "+add(2,3));

            ShowName show2 = (string name) =>
            {
                Console.WriteLine($"Hey this is {name}");
                Console.WriteLine("I am a Extc engg");
            };

            show2("Abhi");


            List<Person> l = new List<Person>()
            {
                new Person(){Name = "Abhi", Age =21},
                new Person(){Name = "Abhi", Age =19},
                new Person(){Name = "Abhi", Age =20},
                new Person(){Name = "Abhi", Age =22},
            };

            Console.WriteLine(l.Max(p => p.Age));
        }
    }
}
