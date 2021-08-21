using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsGenerics
{
    class QueueTest
    {
        // FIFO -> first in first out 
        static void Main()
        {
            Queue q = new Queue();
            Pen p = new Pen { Color = "Red", Rate = 12};
            // Enqueue to add the element in the Queue
            q.Enqueue(12); // store at the start 
            q.Enqueue("abhi"); // store at the next location 
            q.Enqueue(p); // store at the next location 
            // Dequeue to get the element from the Queue

            Console.WriteLine(q.Peek());
        
            /*
            Console.WriteLine(q.Dequeue()); // very first comes out very first 
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            */
        }
    }
}
