using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

using System.IO;

namespace Q13BinSerln
{
    class Program
    {
        static string BinSerialize<T>(T toSerialize)
        {
            string toFile = @"D:\capgemini\training\technical\C#\Labwork\Q13BinSerln\Q13BinSerln\Contacts.bin";
            try
            {
                using (FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, toSerialize);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Bin Serializing");
            return toFile;
        }
        static object BinDeSerialize(string fromFile)
        {
            object toSend;
            try
            {
                using (FileStream fs = new FileStream(fromFile as string, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    toSend = bf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Bin De-Serializing");
            return toSend;
        }



        static string SoapSerialize(object toSerialize)
        {
            string toFile = @"D:\capgemini\training\technical\C#\Labwork\Q13BinSerln\Q13BinSerln\Contacts.soap";
            try
            {
                using (FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write))
                {
                    SoapFormatter sf = new SoapFormatter();
                    sf.Serialize(fs, toSerialize);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Soap Serializing");
            return toFile;
        }

        static object SoapDeSerialize(string fromFile)
        {
            object toSend;
            try
            {
                using (FileStream fs = new FileStream(fromFile as string, FileMode.Open, FileAccess.Read))
                {
                    SoapFormatter sf = new SoapFormatter();
                    toSend = sf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Soap De-Serializing");
            return toSend;
        }


        static string XmlSerialize(object toSerialize)
        {
            string toFile = @"D:\capgemini\training\technical\C#\Labwork\Q13BinSerln\Q13BinSerln\Contacts.xml";
            try
            {
                using (FileStream fs = new FileStream(toFile, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Contacts>));
                    xs.Serialize(fs, toSerialize);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Xml Serializing");
            return toFile;
        }

        static object XmlDeSerialize(string fromFile)
        {
            object toSend;
            try
            {
                using (FileStream fs = new FileStream(fromFile as string, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Contacts>));
                    toSend = xs.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Done Soap De-Serializing");
            return toSend;
        }



        static void Main(string[] args)
        {
            List<Contacts> diary;
            List<Contacts> deSerialized;
            diary = new List<Contacts>();
            string serialFile; 
            try
            {   
                diary.Add(new Contacts() { Name = "Yash", Num = 666516513 });
                diary.Add(new Contacts() { Name = "Abhi", Num = 652665162 });
                diary.Add(new Contacts() { Name = "Sarvesh", Num = 9598956545 });
                diary.Add(new Contacts() { Name = "Suresh", Num = 7452565854 });
                diary.Add(new Contacts() { Name = "Ramesh", Num = 665989513 });

                serialFile = BinSerialize(diary);
                deSerialized = BinDeSerialize(serialFile) as List<Contacts>;

                //serialFile = SoapSerialize(diary);
                //deSerialized = SoapDeSerialize(serialFile) as List<Contacts>;

                serialFile = XmlSerialize(diary);
                deSerialized = XmlDeSerialize(serialFile) as List<Contacts>;

                foreach (var person in diary)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
