using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {

        /*
         * we have 2 types of Error {Runtime, CompileTime},
         * CompileTime is syntactical error where we get error at the compile time 
         * Runtime error can be because of various reasons {Wrong Implementation (Logical), Wrong Input Supplied, Missing Required Resources}
        */
        static void Main(string[] args)
        {
            int a = 10, b = 0, c = 0;
            try
            {
                c = a / b; // here we will get the runtime error which is a logical error we can't divide an integer by 0 
                           // such type of errors need special ways of implementation to be checked 
                           // this is where we need the try catch block 
                           // try -> tries the code gets the exceptions and throws them to the catch block 
            }
            catch(Exception ex) // will catch the exception thrown by the try block 

            {
                Console.WriteLine(ex.Message); 
            }
            finally // will run no matter exception occur or not 
            {
                Console.WriteLine("Finally . . . .");
            }
            
            Console.WriteLine(c);
        }// code doesn't stop in any of the block 
        // but if try catch not used program will terminate 
    }
}
