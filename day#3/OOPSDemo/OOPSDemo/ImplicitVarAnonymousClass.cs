using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ImplicitVarAnonymousClass
    {
        // implicit vars and explicit vars difference 
        // explicit is something which is already present and we are just initializing it "we konw the data type while declaration"
        // implicit is something we give on our own, we don't know the data type while declaration the initialization will decide the data type
        /* 
         * <Limitations Var>
         * cannot be used as class variables
         * cannot bs used as method params 
         * cannot be used as return 
         * needs to be declared and implemented at the same time 
        */
        static void Main()
        {
            //<Syntax Implicit Var> => var <var name> = value/expression
            /* Follwoing will throw error 
             * wrong way 
             * var abhi ;
             * abhi = "Abhi";
            */

            var a = 10; // here compiler will declare a as int 
            var b = "string"; // here compiler will declare b as string 
            
            // along with this we also have Anonymous class, class with no name and created by compiler when declared by us 
            // object of such class is to be stored in implicit variable var 
            // <Syntax> var person = new {Name = "abhishek", Age = 21}
            // anonymous just use for project purpose i.e. displaying the data


        }
    }
}
