using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13BinSerln
{
    [Serializable]
    class Contacts
    {
        public string Name { get; set; }
        private long num;


        public long Num{
            get { return num; }
            set
            {
                if (value < 7000000000 & value > 9999999999)
                {
                    throw new Exception($"Number of digits InValid for {Name}");
                }
                else
                {
                    num = value;
                }
            }
        
        }

        public override string ToString()
        {
            string info = $"-------------------\n{Name} : {Num}\n-------------------";
            return info;
        }

    }
}
