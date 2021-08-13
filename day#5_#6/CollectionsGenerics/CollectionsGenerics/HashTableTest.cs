using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsGenerics
{
    class HashTableTest
    {
        static void Main()
        {
            Hashtable players = new Hashtable();
            Pen parkor = new Pen { Color = "Blue", Rate = 21 };
            players.Add(1, "Dhoni");// stored in key value pair 
            players.Add(2, "Abhi"); // key is also an object and the pair is also an object 
            players.Add(3, "Rahul");
            players.Add(4, "Sarvesh");
            players.Add(5, "Sahil");
            // 
            int key = 9;
            if (players.ContainsKey(key))  // checks if the key is present in the Hashtable
            {
                Console.WriteLine(players[key]); // access the values with the help of keys ht[keys] => value associated to that key 
            }
            else
            {
                Console.WriteLine("Not present ");
            }

            // iteration -> to do this we need the keys 
            //  we can get all the keys using .Keys 
            foreach(var player_key in players.Keys) // as the key can be of any data type it is safer to use "var"
            {
                Console.WriteLine($"{player_key} -> {players[player_key]}"); 
            } // everytime we use this block it will print in the random order as keys might be different objects we can't sort them

            // Limitation 
            // as key objects can be of anytype there is no uniformity and no type safety
            // we need to unbox the objects

        }
    }
}
