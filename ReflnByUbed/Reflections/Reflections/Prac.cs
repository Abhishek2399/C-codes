using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Prac
    {
        private static int num = 10;

        public int Num {
            get { return num; }
            set { num = value; } 
        }

        static void Main()
        {
            Type mirror = typeof(Prac);
            object obj = Activator.CreateInstance(typeof(Prac));
            PropertyInfo[] props = mirror.GetProperties();

            object newVal = 99;
            Console.WriteLine(mirror.GetProperty("Num").GetIndexParameters());
            mirror.GetProperty("Num").SetValue(obj, newVal);
            Console.WriteLine(num);
        }
    }
}
