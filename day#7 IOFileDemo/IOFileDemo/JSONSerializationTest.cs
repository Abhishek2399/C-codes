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
         * with the help of using(){...} this will close all the resources by itself no need to close explicitly like fs.close , closing stream writer 
         * or jwriter.close closing JSON writer
         */
        static private string JSONSerializeData()
        {
            string toFile = @"D:\capgemini\training\technical\C#\IOFileDemo\IOFileDemo\JSONSerializationTest.json";
            SerializableMovie serialMovie = new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 };
            using(StreamWriter sw = new StreamWriter(toFile)) // using stream writer to create a .json file 
            { 
                using (JsonWriter jWriter = new JsonTextWriter(sw)) // this like the stream writer obj we need JSON writer to write to a JSON file 
                {
                    JsonSerializer js = new JsonSerializer(); // works only with JSON reader and JSON writer
                    js.Serialize(jWriter, serialMovie); // this is like formatter obj where to serialize and what to serialize 
                }// jwriter is closed by itself here 
            }// stream writer is closed here 
            Console.WriteLine("Done JSON Serialization");
            return toFile;
        }

        static private object JSONDeSerializeData(string fromFile)
        {
            Console.WriteLine($"From file {fromFile}");
            SerializableMovie mv;
            using (StreamReader sr = new StreamReader(fromFile))
            {
                using(JsonReader jReader = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    mv = js.Deserialize<SerializableMovie>(jReader);
                }
            }
            Console.WriteLine("Done JSON De-Serialization");
            return mv;
        }
        
        static void Main()
        {
            string jsonSerialFile = JSONSerializeData();

            SerializableMovie mv = JSONDeSerializeData(jsonSerialFile) as SerializableMovie;
            Console.WriteLine($"this is the object:\n {mv}");

            Console.WriteLine(JsonConvert.SerializeObject(mv));
        }
    }
}
