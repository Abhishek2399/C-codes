using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class MyFacebookIndexers
    {
        // Indexers Concept 
        // This is all about making the object access private elements using indexing 
        public string Username { get; set; } // auto implemented Property 
        // creating an object type reference to the array 
        string[] MyPost; // private string array element 

        public MyFacebookIndexers(int size)
        {
            MyPost = new string[size]; // allocation will be done while the object is created , hence every object will be having of "MyPost"
        }

        public string this[int pos] // indexer property, "this" can be termed as the object it self, we want to acess the object related array data with the position passed
        {
            // Property Indexer is just a Property which works on basis of "indexes"
            get { return MyPost[pos]; } // getter using indexer 
            set { MyPost[pos] = value; } // setter using indexer
        } // "this" represent the current object

        // Property Indexers Syntax : <access modifier> <return type>  "this" [int pos]{ }
        // eg: making the Property indexer to return the name when initial passed is 'a' 
        public string this[char intial]
        {
            get
            {
                if (intial == 'a') return Username;
                else return null;
            }
            
        }
        // similarly making an indexer property to return name when passed string "name"
        public string this[string data]
        {
            get
            {
                if (data.Equals("name")) return Username;  else return null;
            }
        }
    }
}
