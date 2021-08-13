using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json; // for converison of and from json type data 
// new things which are not installed need to be downloaded form "Nugget" 
// Project -> manage nugget pkgs -> Browse -> newton(for json)


namespace IOFileDemo
{
    
    class JSONSerializationTest
    {

        /*
         * with the help of using(){...} this will close all the resources by itself no need to close explicitly like fs.close , closing streamwriter 
         * or jwriter.close closing json writer
         * 
         */
        static private string JSONSerializeData()
        {
            string toFile = "JSONSerialzedObjs.txt";
            SerializableMovie serialMovie = new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 };
            using(System.IO.StreamWriter sw = new System.IO.StreamWriter(toFile)) // using streamwriter to create a .json file 
            { 
                using (JsonWriter jwriter = new JsonTextWriter(sw)) // this like the streamwriter obj we need json writer to wrtie to a json file 
                {
                    JsonSerializer js = new JsonSerializer(); // works only with json reader and json writer
                    js.Serialize(jwriter, serialMovie); // this is like formatter obj where to searialize and what to serialize 
                }// jwriter is closed by itself here 
            }// streamwriter is closed here 
            Console.WriteLine("Done JSON Serialization");
            return toFile;
        }
        

        static private object JSONDeSerializeData(string fromFile)
        {
            SerializableMovie mv;
            using (StreamReader sr = new StreamReader(fromFile))
            {
                using(JsonReader jReader = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    mv = js.Deserialize(jReader) as SerializableMovie;
                }
            }
            Console.WriteLine("Done Deserialization");
            return mv;
        }
        


        static void Main()
        {
            string jsonSerialFile = JSONSerializeData();

            SerializableMovie mv = JSONDeSerializeData(jsonSerialFile) as SerializableMovie;
            Console.WriteLine(mv);

        }
    }
}
