using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFileDemo
{
    [Serializable]
    public class SerializableSparsh
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            string info = $"------------\nName : {Name}\nAge : {Age}\n------------";
            return info;
        }
    }
}
