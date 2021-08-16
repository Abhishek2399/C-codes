using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Demo
    {
        private string name;
        private int mks;
        public Demo()
        {
            name = null;
            mks = 0;
        }
        public string Name
        {
            get {
                if (Name != null) return name;
                else return "Null";
            }
            set { name = value; }
        }

        public int Mks
        {
            get { return mks; }
            set {
                if (Name != null) mks = value;
                else mks = 0;
            }
        }

        public string GetDetails()
        {
            string details = $"{Name} : {Mks}";
            return details;
        }
    }

    class DemoTest
    {
        
        static void Main()
        {
            Demo abhi = new Demo();
            abhi.Name = "Abhishek";
            abhi.Mks = 75;

            Demo rahul = new Demo();
            //rahul.Name = "Rahul";
            rahul.Mks = 90;

            Console.WriteLine(abhi.GetDetails());
            Console.WriteLine(rahul.GetDetails());
        }

    }
}
