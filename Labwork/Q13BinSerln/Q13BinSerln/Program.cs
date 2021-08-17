using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
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
            Console.WriteLine("Done Serializing");
            return toFile;
        }

        static object BinDeSerialize<T>(T fromFile)
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
            Console.WriteLine("Done De-Serializing");
            return toSend;
        }


        static void Main(string[] args)
        {
            List<Contacts> Diary;
            Diary = new List<Contacts>();
            string serialFile; 
            try
            {
                
                Diary.Add(new Contacts() { Name = "Yash", Num = 666516513 });
                Diary.Add(new Contacts() { Name = "Abhi", Num = 652665162 });
                Diary.Add(new Contacts() { Name = "Sarvesh", Num = 9598956545 });
                Diary.Add(new Contacts() { Name = "Suresh", Num = 7452565854 });
                Diary.Add(new Contacts() { Name = "Ramesh", Num = 665989513 });

                serialFile = BinSerialize<List<Contacts>>(Diary);
                List<Contacts> deSerialized = BinDeSerialize(serialFile) as List<Contacts>;

                foreach (var person in Diary)
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
