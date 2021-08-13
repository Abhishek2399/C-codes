using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymath // creating a namespace block "Mymath"
{  
    public class MyCalc 
    {  // creating a class "MyCalc" inside Mymath namespace
        public int add(int a, int b) // taking two integer types arguments and returing an integer i.e. signature{return : int, parameters : int, int}
        {
            return a + b;
        }
        public int mul(int a, int b) // signature{return : int, parameter : int, int}
        {
            return a * b;
        }
    }

}

namespace Greet // creating a namespace block "Greet"
{
    public class Hello // creating a class Hello
    {
        public string Welcome(string name) // signature = {return : string, param : string}
        {
            return $"{name}, Welcome to net";
        }
        public string GoodBye() // sign = {ret. : string, param : None}
        {
            return $"Good bye to net";
        }

        public void Nothing()
        {
            Console.WriteLine("nothing");
        }
    }
}



