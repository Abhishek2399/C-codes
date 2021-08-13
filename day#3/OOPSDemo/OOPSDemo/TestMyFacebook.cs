using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class TestMyFacebook
    {
        public static void Main()
        {
            MyFacebookIndexers my = new MyFacebookIndexers(3); //
            my.Username = "Abhishek"; 
            my[0] = "Hey this is abhi"; // here we are accessing the private element array value with an index 
            my[1] = "BE is what i have done ";
            my[2] = "kuch nahi ata";
            Console.WriteLine(my[1]); // here we are accessing the private element array value with an index 
            Console.WriteLine(my['a']); // as of the porperty indexer this should return the my username 
            Console.WriteLine(my["name"]);

        }
    }
}
