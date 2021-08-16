using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ExceptionTest
    {
        static void Main()
        {
            try // one try can have multiple catches but the last one catch should be the "Exception ex" 
            {
                int a = 10, c = 0, b = 20;
                
                // Application based exception 
                if (b <= a) // 'b' should be less then 'a' is the Application Requirement 
                {
                    c = b / a;
                }
                else
                {
                    throw new MyException("Value of b should be greater than a"); // self made exception class

                    throw new Exception("Value of b should be greater than a"); // throwing an user defined exception this will be caught by the universal catch 
                }

                someMethod1();
                Console.WriteLine("Exception handled by someMethod1");

                someMethod2();
                Console.WriteLine("Exception handled by someMethod2");



            } // if no exception occured code will directly go to "finally" else "catch"
            // we can provide a "Catch" method to accept specific exceptions also
            catch (DivideByZeroException ex) // if divide by 0 occurs this catch will run and program will go to finally
            {
                //Console.WriteLine(ex.Message);
            }
            // universal catch block will catch the user define
            catch (Exception ex) // will catch any exception 
            {
                Console.WriteLine(ex.Message);
            }
            finally // executed at the very end of program after going through all the catches
            {
                Console.WriteLine("Welcome to Exception");
            }

        }
        // creating self exceptions 
        public static void someMethod1() // when in some mehtod an exception is not handled as in try . . . catch block it will be handled by outside try catch i.e. is in main and exception caught by line 25 catch 
        {
            Pen p = null;
            p.Rate = 90;
            Console.WriteLine("Object successful");
        }

        public static void someMethod2()
        {
            try
            {
                Pen p = null;
                p.Rate = 90;
                Console.WriteLine("Object successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
