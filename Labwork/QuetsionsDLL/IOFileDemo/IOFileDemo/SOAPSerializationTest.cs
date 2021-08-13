using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap; // for this we had to add reference to the soap dll from assemblies in add ref window
using System.IO;
namespace IOFileDemo
{
    
    class SOAPSerializationTest
    {
        static private string SOAPSerializeData()
        {
            string toFile = "SOAPMovieSerializedObjs.soap";
            SerializableMovie serialMovie = new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 };
            FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, serialMovie);
            fs.Close();
            Console.WriteLine("Done SOAP Serialization");
            return toFile;
        }

        static private object SOAPDeSerializeData(string fromFile)
        {

            SerializableMovie deSerialMovie = null;
            FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            deSerialMovie = sf.Deserialize(fs) as SerializableMovie;
            fs.Close();
            Console.WriteLine("Done SOAP DeSerialization");
            return deSerialMovie;
        }

        static void Main()
        {
            string soapSerialFile = SOAPSerializeData();
            SerializableMovie mv = SOAPDeSerializeData(soapSerialFile) as SerializableMovie;
            Console.WriteLine(mv);
        }

    }

}
