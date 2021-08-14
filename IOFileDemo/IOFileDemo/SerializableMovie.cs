using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IOFileDemo
{
    [Serializable] // [] -> this is an attribute 
    // to tell the compiler that this class can be serializable 
    // for XML serialization the class has to be public 
    public class SerializableMovie : ISerializable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        // custom serialization 
        public void GetObjectData(SerializationInfo info, StreamingContext context) // adding additional info 
        {
            info.AddValue("nm", Name);
            info.AddValue("id", ID);
            info.AddValue("yr", Year);
            info.AddValue("rt", Rating);
        }

        public  SerializableMovie(SerializationInfo info, StreamingContext context)// getting values from the additional info 
        {
            ID = info.GetInt32("id"); // using the same keys to get data 
            Name = info.GetString("nm");
            Year = info.GetInt32("yr");
            Rating = info.GetInt32("rt");
        }

        public SerializableMovie() { }

        //------------------------


        public override string ToString()
        {
            string objInfo = ($"----------------------\nName:{Name}\nID:{ID}\nRating:{Rating}\nYear:{Year}\n----------------------");
            return objInfo;
        }
    }
}
