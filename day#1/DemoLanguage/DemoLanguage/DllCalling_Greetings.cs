using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mymath; // using Mymath namespace so that we can ref. the class inside it 
using Greet; // using Greet namespace so that we can ref. the class inside it 
using Abhishek;

namespace DemoLanguage
{
    class DllCalling_Greetings
    {
        static void Main()
        {

            Abhi a = new Abhi();
            Console.WriteLine(a.GetName());

            Console.ReadLine(); // not for running in the visual code {this is will hold the program on its own} this is for the console execution / application execution outside the visual code 


        }
    }
}
