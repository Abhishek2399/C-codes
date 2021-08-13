using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SchoolDemo
    {
        public int RollNo { get; set; }
        public string StudName { get; set; }
        public short Age { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string Address { get; set; }
        public float Percent { get; set; }

        public override string ToString()
        {
            string info = $"Name:{StudName}\nAge:{Age}\nGender:{Gender}\nDOB:{DateOfBirth.ToString("d")}\nAddress:{Address}\nPercent:{Percent}";
            return info;
        }

    }

    class Q4Soln
    {
        static void Main()
        {
            SchoolDemo abhi = new SchoolDemo();
            abhi.StudName = "Abhishek";
            abhi.Age = 21;
            abhi.RollNo = 19;
            abhi.Percent = 74;
            abhi.Address = "Andheri";
            abhi.DateOfBirth = new DateTime(1999, 08, 23);

            Console.WriteLine(abhi);

        }
    }
}
