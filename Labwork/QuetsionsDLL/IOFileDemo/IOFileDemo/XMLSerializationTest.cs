using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization; // for XML type serialization

namespace IOFileDemo
{
    public class XMLSerializationTest
    {
        static private string XMLSerializeData() // for xml serialization of any class the class has to be public 
        {
            SerializableMovie serialMovie = new SerializableMovie { Name = "Rushmore", ID = 127, Rating = 5, Year = 2009 };
            XmlSerializer xmlSerialize = new XmlSerializer(typeof(SerializableMovie)); // this will give meta data of class movie 
            
            // as we will be getting the meta data of the class Movie we will have to write it to .xml file
            string toFile = "SOAPMovieSerializedObjs.xml";
            
            FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write); // here we will be creating a .xml file 
            xmlSerialize.Serialize(fs, serialMovie);
            fs.Close();
            
            Console.WriteLine("XML Serialization done ");
            return toFile;
        }

        static private object XMLDeSerializeData(string fromFile)
        {
            SerializableMovie deSerialMovie = null;
            XmlSerializer xmlSerialize = new XmlSerializer(typeof(SerializableMovie)); // this will give meta data of class movie 
            
            FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read);
            deSerialMovie = xmlSerialize.Deserialize(fs) as SerializableMovie;
            Console.WriteLine("XML DeSerialization done ");

            return deSerialMovie;
        }

        static void Main()
        {
            //XMLSerializeData();
            
            try
            {
                string soapSerialFile = XMLSerializeData();
                SerializableMovie serialMovie = XMLDeSerializeData(soapSerialFile) as SerializableMovie;
                Console.WriteLine(serialMovie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //SerializableMovie mv = XMLDeSerializeData(soapSerialFile) as SerializableMovie;
            //Console.WriteLine(mv);
            
        }

    }
}
