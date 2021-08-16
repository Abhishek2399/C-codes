using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class DictionaryTest
    {
        static void Main()
        {
            Dictionary<int, string> players = new Dictionary<int, string>(); // key{int} value{string}
            players.Add(1, "Dhoni");// stored in key value pair 
            players.Add(2, "Abhi"); 
            players.Add(3, "Rahul");
            players.Add(4, "Sarvesh");
            players.Add(5, "Sahil");
           
            foreach(int key in players.Keys)
            {
                Console.WriteLine($"Player[{key}] -> {players[key]}");
            }
        }
    }
}
