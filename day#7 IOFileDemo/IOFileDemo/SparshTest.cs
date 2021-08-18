using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;
using Newtonsoft.Json;


namespace IOFileDemo
{
    class SparshTest
    {

        static string BinarySerialize(object toSerialize)
        {
            string inFile = @"D:\capgemini\training\technical\C#\day#7 IOFileDemo\IOFileDemo\Sparsh.bin";
            using (FileStream fs =  new FileStream(inFile, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, toSerialize); // where and what {to write}
            }
            Console.WriteLine("Done bin Serln");
            return inFile;
        }

        static object BinaryDeSerialize(string fromFile)
        {
            object deserialized;
            using (FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                deserialized = bf.Deserialize(fs); 
            }
            Console.WriteLine("Done bin De-Serln");
            return deserialized;
        }


        static string XmlSerialize(object toSerialize)
        {
            string inFile = @"D:\capgemini\training\technical\C#\day#7 IOFileDemo\IOFileDemo\Sparsh.xml";
            using (FileStream fs = new FileStream(inFile, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SerializableSparsh)); // will take metadata -> typeof() -> obj to be serialized
                xs.Serialize(fs, toSerialize);
            }
            Console.WriteLine("Done xml Serln");
            return inFile;
        }

        static object XmlDeSerialize(string fromFile)
        {
            object deserialized;
            using (FileStream fs = new FileStream(fromFile, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SerializableSparsh));
                deserialized = xs.Deserialize(fs); // where and what {to write}
            }
            Console.WriteLine("Done xml De-Serln");
            return deserialized;
        }


        // {'Name':'Abhi', 'Age':21}

        static string JsonSerialize(object toSerialize)
        {
            string inFile = @"D:\capgemini\training\technical\C#\day#7 IOFileDemo\IOFileDemo\Sparsh.json";
            using (StreamWriter sw = new StreamWriter(inFile))
            {
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jw, toSerialize);
                }
            }
            Console.WriteLine("Done JSON Serln");
            return inFile;
        }

        static object JsonDeSerialize(string fromFile)
        {
            object deserialized;
            using (StreamReader sr = new StreamReader(fromFile))
            {
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    deserialized = js.Deserialize<SerializableSparsh>(jr);
                }
            }
            Console.WriteLine("Done JSON De-Serln");
            return deserialized;
        }


        static string JsonConvertSerialize(object toSerialize)
        {
            string inFile = @"D:\capgemini\training\technical\C#\day#7 IOFileDemo\IOFileDemo\Sparsh.txt";
            using (StreamWriter sw = new StreamWriter(inFile))
            {
                string data = JsonConvert.SerializeObject(toSerialize);
                sw.WriteLine(data);
            }
            Console.WriteLine("Done JSON Convert Serln");
            return inFile;
        }

        static object JsonConvertDeSerialize(string fromFile)
        {
            object deserialized;
            using (StreamReader sr = new StreamReader(fromFile))
            {
                string data = sr.ReadLine();
                deserialized = JsonConvert.DeserializeObject<SerializableSparsh>(data);

            }
            Console.WriteLine("Done JSON Convert De-Serln");
            return deserialized;
        }




        static void Main()
        {
            SerializableSparsh abhi = new SerializableSparsh() { Name = "Abhi", Age = 21 };
            Console.WriteLine(abhi);
            string inFile;
            SerializableSparsh abhiDeserial;
            try
            {
                /*
                inFile = BinarySerialize(abhi);
                abhiDeserial = (SerializableSparsh)BinaryDeSerialize(inFile);
                Console.WriteLine(abhiDeserial);



                inFile = XmlSerialize(abhi);
                abhiDeserial = XmlDeSerialize(inFile) as SerializableSparsh;
                Console.WriteLine(abhiDeserial);


                inFile = JsonSerialize(abhi);
                abhiDeserial = JsonDeSerialize(inFile) as SerializableSparsh;
                Console.WriteLine(abhiDeserial);

                 */

                inFile = JsonConvertSerialize(abhi);
                abhiDeserial = (SerializableSparsh)JsonConvertDeSerialize(inFile);
                Console.WriteLine(abhiDeserial);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
