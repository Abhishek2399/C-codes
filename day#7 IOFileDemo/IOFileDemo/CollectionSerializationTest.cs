using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace IOFileDemo
{
    class CollectionSerializationTest
    {
        static string path = @"D:\capgemini\training\technical\C#\IOFileDemo\IOFileDemo\";
        static List<SerializableMovie> movies = new List<SerializableMovie>()
            {
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
                new SerializableMovie { Name = "The Bottle Rocket", ID = 139, Rating = 5, Year = 2000 },
                new SerializableMovie { Name = "The Fantastic Mr.Fox", ID = 187, Rating = 7, Year = 1999 },
                new SerializableMovie { Name = "Aquatic Life with Steve Zissou", ID = 171, Rating = 5, Year = 2014 },
                new SerializableMovie { Name = "The Grand Budapest Hotel", ID = 127, Rating = 5, Year = 2018 },
            };

        static string BinarySerialize()
        {
            string toFile = "CollectionBinSerialize.bin";
            using( FileStream fs = new FileStream(path + toFile, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, movies);
            }
            return toFile;
        }
        static void BinaryDeSerialize(string fromFile)
        {
            List<SerializableMovie> movieList; 
            using (FileStream fs = new FileStream(path + fromFile, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                movieList = bf.Deserialize(fs) as List<SerializableMovie>;
            }

            foreach(SerializableMovie mv in movieList)
            {
                Console.WriteLine(mv);
            }
        }

        //------------------------------JSON serialization of collection using JsonConvert----------------------//
        static string JsonConvertSerialize() // using JSON convert 
        {
            string toFile = "CollectionJSONConvertSerialize.txt";
            using (StreamWriter sw = new StreamWriter(path + toFile))
            {
                string data = JsonConvert.SerializeObject(movies); // serializing the object we want returns string of JSON
                Console.WriteLine(data);
                sw.WriteLine(data); // data stored in form of text and in one single line 
            }
            Console.WriteLine("Done JSON Convert serializaton");
            return toFile;
        }
        // JSON convert just to convert string to JSON format
        static void JsonConvertDeSerialize(string fromFile) // using JSON convert 
        {
            
            List<SerializableMovie> moviesList;
            using (StreamReader sr = new StreamReader(path + fromFile))
            {
                string data = sr.ReadToEnd();
                moviesList = JsonConvert.DeserializeObject(data) as List<SerializableMovie>;
            }
            foreach (var mv in moviesList)
            {
                Console.WriteLine(mv);
            }
            Console.WriteLine("Done JSON deserializaton");
        }

        //------------------------------JSON serialization of collection using JSON----------------------//

        static string JsonSerialize()
        {
            string toFile = "CollectionJSONSerialize.json";
            using (StreamWriter fileStream = new StreamWriter(path+toFile))
            {
                using (JsonWriter jWriter= new JsonTextWriter(fileStream))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jWriter, movies);
                }
            }
            Console.WriteLine("Done JSON Serialization");
            return toFile;
        }

        static void JsonDeserialize(string fromFile)
        {
            try
            {
                List<SerializableMovie> deSerializedMovies = new List<SerializableMovie>();            
                using (StreamReader fileStream = new StreamReader(path + fromFile))
                {
                    using (JsonReader jReader = new JsonTextReader(fileStream))
                    {
                        JsonSerializer js = new JsonSerializer();
                        deSerializedMovies = js.Deserialize<List<SerializableMovie>>(jReader);
                    }
                }
                foreach (var mv in deSerializedMovies)
                {
                    Console.WriteLine(mv);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done JSON De-Serialization");

        }

        static void Main()
        {
            /*
            string serialFile = BinarySerialize();
            BinaryDeSerialize(serialFile);
            */
            try
            {
                string jsonFile = JsonSerialize();
                JsonDeserialize(jsonFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
