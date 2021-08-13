using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// all in one -> generic, iterations, indexres
namespace CollectionsGenerics
{
    // trying to mimic the ArrayList but only for same type of data like an array 
    // to do se we need to define the following class as Generic
    // Generic class Syntax "class" classname<T>
    class MyList<T> : IEnumerable<T> 
    { 
        public int Count { get; set; }
        int size;
        T[] arr;

        public T this [int pos] // using indexers as we want to access elements of this object individually using position of that element 
        {
            get { return arr[pos];  }

        }

        public MyList(int size)
        {
            this.size = size;
            arr = new T[size]; // T will be what ever the user will decide to keep it
        }

        public void Add(T data) // to add new element in the list 
        {
            Console.WriteLine(Count);
            if (Count < size)
            {
                Console.WriteLine("Gor inside");
                arr[Count] = data;
                Count++;
            }
            else throw new Exception("Array Full");
        }

        public IEnumerator<T> GetEnumerator() // 
        {
            for(int i=0; i<Count; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // explicit one need to be written both implicit and explicit, if not required do not use 
        {
            return arr.GetEnumerator();
        }
    }
}
