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
        static List<SerializableMovie> movies = new List<SerializableMovie>()
            {
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
                new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 },
            };

        static string BinarySerialize()
        {
            string toFile = "CollectionBinSerialize.bin";
            using( FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, movies);
            }
            return toFile;
        }
        static void BinaryDeSerialize(string fromFile)
        {
            List<SerializableMovie> movieList; 
            using (FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                movieList = bf.Deserialize(fs) as List<SerializableMovie>;
            }

            foreach(SerializableMovie mv in movieList)
            {
                Console.WriteLine(mv);
            }
        }

        //------------------------------Json serialization of collection----------------------//
        static string JSONSerialize() // using json convert 
        {
            string toFile = "CollectionJSONSerialize.txt";
            using (StreamWriter sw = new StreamWriter(toFile))
            {
                string data = JsonConvert.SerializeObject(movies); // serializing the object we want returns string of json
                Console.WriteLine(data);
                sw.WriteLine(data); // data stored in in form of text and in one single line 
            }
            Console.WriteLine("Done json serializaton");
            return toFile;
        }
        // json convert jsut to convert string to json format
        static void JSONDeSerialize(string fromFile) // using json convert 
        {
            
            List<SerializableMovie> moviesList;
            using (StreamReader sr = new StreamReader(fromFile))
            {
                string data = sr.ReadToEnd();
                moviesList = JsonConvert.DeserializeObject(data) as List<SerializableMovie>;
            }
            foreach (var mv in moviesList)
            {
                Console.WriteLine(mv);
            }
            Console.WriteLine("Done json deserializaton");
        }


        static void Main()
        {
            /*
            string serialFile = BinarySerialize();
            BinaryDeSerialize(serialFile);
            */
            string jsonSerialFile = JSONSerialize();
            JSONDeSerialize(jsonSerialFile);

        }
    }
}
