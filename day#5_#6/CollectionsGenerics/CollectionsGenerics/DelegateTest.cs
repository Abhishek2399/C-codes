using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    
    class DelegateTest
    {
        // MyPizza testing 
        public static void CheeseToppings(string name)
        {
            Console.WriteLine($"Add {name}");
        }

        public static void CapsicumToppings(string name)
        {
            Console.WriteLine("Cut it ");
            Console.WriteLine($"Add {name}");
        }

        

        static void Main()
        {
            Pen pen = new Pen(); // these is where the delegate testing methods are 
            MyDelegates myDel = new MyDelegates();// creating an object of class where the delegate is declared 
            //myDel. here the intellisense will not show the delegate, since the delegate is an inner class{class inside another class} nested class/ in .net nested type 
            // hence to access it we need to create the object of the inner class
            // inner class is always visible with the ref. of outer class hence objects cant see the inner class
            // outerclass.innerclass 
            // here MyDelegates is the outer class and CalDelegates is the innner class
            MyDelegates.calDelegate dCalc = new MyDelegates.calDelegate(pen.Add); //  assigning Add method to the Delegate object 
            dCalc(10, 30);
            dCalc = pen.Mul;
            dCalc(10, 30);
            dCalc = pen.Sub;
            dCalc(10, 30);

            // Multicast delegate is when we associate multiple methods together to perform a task
            // eg if we want to perform 2 methods add and then mul
            dCalc = pen.Add;
            dCalc += pen.Mul; // adding another method in the delegate so here first add will be called and then Mul sequentially as it is being added to the delegate
            dCalc(5, 4); // Add => Mul
            // we can also remove an method from the sequence 
            dCalc -= pen.Add; // Add will be reomveed and no sub will be added 
            dCalc += pen.Sub; // adding another method in the delegate so here first add will be called and then Mul sequentially as it is being added to the delegate
            dCalc(5, 4); // Mul => Sub
            Console.WriteLine();

            // Note : Multicast only works on the methods with no return values 

            #region Funcitonal Callback
            MyDelegates makeMyPizza = new MyDelegates();
            MyDelegates.ToppingDelegate td = new MyDelegates.ToppingDelegate(CheeseToppings);
            makeMyPizza.MakePizza(td, "Amul"); // here the td called will be the "CheeseToppings"
            Console.WriteLine();
            td = CapsicumToppings;
            makeMyPizza.MakePizza(td, "Red Pepper"); // here the td called will be the "CapsicumToppings"
            #endregion

            Pen useMethod = new Pen();
            List<Pen> pens = new List<Pen>()
            {
                new Pen{ Rate = 129, Color = "red"},
                new Pen{ Rate = 179, Color = "violet"},
                new Pen{ Rate = 159, Color = "red"},
                new Pen{ Rate = 139, Color = "yellow"},
                new Pen{ Rate = 19, Color = "orange"},
                new Pen{ Rate = 197, Color = "green"},

            };
            MyDelegates.SortDelegate<Pen> sd = new MyDelegates.SortDelegate<Pen>(useMethod.ColorSort); // sorting by color 
            myDel.MySort<Pen>(pens, sd); 
            foreach(Pen penObj in pens)
            {
                Console.WriteLine(penObj);
            }
            Console.WriteLine();
            sd = useMethod.RateSort;
            myDel.MySort<Pen>(pens, sd);
            foreach (Pen penObj in pens)
            {
                Console.WriteLine(penObj);
            }

        }
    }
}
