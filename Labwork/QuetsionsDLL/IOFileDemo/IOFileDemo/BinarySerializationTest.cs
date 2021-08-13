using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // as wel will be writing the serialized objs in file 
using System.Runtime.Serialization.Formatters.Binary; // as we will be performing binary serialization formating

namespace IOFileDemo
{
    class BinarySerializationTest
    {
        static void Main()
        {
            string file;
            file = SerializeData();
            Console.WriteLine("Done Bin. Serialization");
            SerializableMovie mv = DeSerializeData(file) as SerializableMovie;
            Console.WriteLine("Done obj DeSerialization");
            Console.WriteLine(mv);

        }

        private static string SerializeData()
        {
            string toFile = "MovieSerialzedObjs.bin";
            SerializableMovie serialMovie = new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 };
            FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write); // creating a binary file to write the serialized obj 
            BinaryFormatter bf = new BinaryFormatter(); // to format the object in binary 
            bf.Serialize(fs, serialMovie); // serialize in binary format in the filestream 'fs' the obj 'mv'
            fs.Close(); // to save the written content 
            // file created after execution of the following code block wont be in the readable format 
            // to get it into understand able format we need to DeSerialize it 
            return toFile;
        }

        private static object DeSerializeData(string fromFile)
            // logic for creating a file by deserializing the object 
        {
            SerializableMovie deSerialMovie = null; // just declare dont initiate 
            FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read); // here we have created a new file stream to open the already present file in filemode open and file access as read
            BinaryFormatter bf = new BinaryFormatter();
            deSerialMovie = bf.Deserialize(fs) as SerializableMovie;
            fs.Close();
            return deSerialMovie;
        }

    }

}
